using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using net.adamec.lib.common.actor.actor;
using net.adamec.lib.common.actor.message;
using net.adamec.lib.common.logging;
using net.adamec.lib.common.utils;

namespace net.adamec.lib.common.actor.actorsystem
{
    /// <inheritdoc />
    /// <summary>
    /// Message dispatched used by <see cref="P:net.adamec.lib.common.actor.actorsystem.ActorSystemDispatcher.ActorSystem" />
    /// </summary>
    internal class ActorSystemDispatcher : BaseDisposable
    {
        protected static ILogger Logger = CommonLogging.CreateLogger<ActorSystemDispatcher>();
        /// <summary>
        /// Message logger
        /// </summary>
        protected static ILogger MessageLogger = CommonLogging.CreateLogger(typeof(ActorSystemDispatcher).Name + ".[MESSAGE]");

        /// <summary>
        /// Actor System options
        /// </summary>
        protected ActorSystemOptions Options { get; }

        /// <summary>
        /// Flag whether the dispatcher is active (dispatching messages)
        /// </summary>
        public bool IsActive => isActive;
        private volatile bool isActive;

        private ActorSystem ActorSystem { get; }
        /// <summary>
        /// Dispatcher executor thread
        /// </summary>
        private Thread ExecutorThread { get; set; }
        
        private List<ScheduledMessageInfo> ScheduledMessages { get; } = new List<ScheduledMessageInfo>();
        private readonly object scheduledMessagesLock = new object();

        /// <summary>
        /// Initialize dispatcher
        /// </summary>
        /// <param name="actorSystem">Actor System the dispatcher belongs to</param>
        public ActorSystemDispatcher(ActorSystem actorSystem)
        {
            ActorSystem = actorSystem;
            Options = actorSystem.Options;
        }

        /// <summary>
        /// Starts the dispatcher
        /// Creates the executor thread and starts processing the messages
        /// </summary>
        public void Start()
        {
            if (IsActive) return;
            Logger.Info("Starting Dispatcher...");

            ExecutorThread = new Thread(Execute);
            ExecutorThread.Start(ActorSystem);

            isActive = true;
            Logger.Info("Started Dispatcher");
        }

        /// <summary>
        /// Stops the dispatcher
        /// Finish current processing and "close" the executor thread
        /// </summary>
        public void Stop()
        {
            Logger.Info("Stopping Dispatcher...");
            isActive = false;
            Logger.Info("Waiting for executor to finish...");

            ExecutorThread?.Join(TimeSpan.FromSeconds(5)); //wait for current processing in executor thread
            if (ExecutorThread != null && ExecutorThread.IsAlive) //abort the executor thread if still needed
            {
                Logger.Info("Aborting executor...");
                ExecutorThread.Abort();
                Logger.Info("Executor aborted");
            }
            
            ExecutorThread = null;

            Logger.Info("Stopped Dispatcher");
        }

        /// <summary>
        /// Main dispatcher loop (runs within the <see cref="ExecutorThread"/>)
        /// The loop is active while <see cref="isActive"/> is set to true, so setting <see cref="isActive"/> to false forces the loop to exit
        /// Each run of the loop enqueue the due scheduled messages (if any) and process mailboxes (actors) with any pending messages.
        /// Actor (actor reference) is locked for processing and the task is scheduled in thread pool to process the actor's queue.
        /// The actor remains locked until the task is not finished, so it's not picked up by executor again during the processing
        /// </summary>
        /// <param name="actorSystemObj">Actor System</param>
        private void Execute(object actorSystemObj)
        {
            if (!(actorSystemObj is ActorSystem actorSystem)) return;
            Logger.Info("Executor started");
            while (isActive)
            {
                //Process scheduled messages
                var scheduledMessages = GetScheduledMessagesDue();
                foreach (var message in scheduledMessages)
                {
                    message.Recipient.Tell(message.Message, message.Sender);
                }
                //Process mailboxes
                var toProcess = actorSystem.GetMailboxesWithMessages();
                foreach (var actorRef in toProcess)
                {
                    actorRef.LockForProcessing();
                    ThreadPool.QueueUserWorkItem(ProcessActorQueue, actorRef);
                }
            }
            Logger.Info("Executor finished");
        }

        /// <summary>
        /// Main actor queue processor - scheduled by executor within the thread pool for each eligible actor (actor ref)
        /// Processes the batch of the messages for given actor. The messages are being processed sequentially in FIFO order within the loop with following constraints
        ///  - there are still messages in actor's queue
        ///  - actor can receive the messages
        ///  - the batch size (number of messages for single actor processed in one cycle) has not been reached
        ///  - dispatcher is not stopped
        /// The messages are sent to current actor receive target 
        /// </summary>
        /// <param name="actorRef">Actor to process</param>
        private void ProcessActorQueue(object actorRef)
        {
            if (!(actorRef is ActorRefInternal actorRefInternal)) return;

            var cnt = 0;
            while (actorRefInternal.Queue.HasMessages &&
                   actorRefInternal.Actor.CanReceive &&
                   cnt++ < ActorSystem.Options.MaxDispatchMessagesInBatch &&
                   isActive)
            {
                if (!actorRefInternal.Queue.TryDequeue(out var envelope)) continue;

                var actor = actorRefInternal.Actor;
                if (actor == null) continue; //TODO ?Exception

                bool handled;
                try
                {
                    if (actor.ReceiveTarget == null)
                        throw new InvalidOperationException($"ReceiveTarget for actor {actorRefInternal.Name} is not set");

                    if (MessageLogger.IsDebugEnabled && Options.LogDispatchMessages)
                    {
                        var props = new Dictionary<string, object>
                        {
                            {"CorrelationId", envelope.CorrelationId},
                            {"MessageIsError", "false"},
                            {"MessageEvent", "Dispatch"},
                            {"MessageType", envelope.Message.GetType().Name},
                            {"MessageSender", envelope.Sender.Name},
                            {"MessageTarget", envelope.Recipient.Name}
                        };
                        MessageLogger.Debug(props, envelope.Message.ToString());
                    }

                    handled = actor.ReceiveTarget(envelope);
                }
                catch (Exception exception)
                {
                    //send the erroneous messages to error queue and log the error (don't break the execution)
                    var errMessage = new ErrorMessage(envelope, exception.Message, exception);
                    ActorSystem.ErrorMessageQueue.Enqueue(errMessage);
                    handled = true;

                    var props = new Dictionary<string, object>
                    {
                        {"CorrelationId", envelope.CorrelationId},
                        {"MessageIsError", "true"},
                        {"MessageEvent", "DispatchError"},
                        {"MessageType", envelope.Message.GetType().Name},
                        {"MessageSender", envelope.Sender.Name},
                        {"MessageTarget", envelope.Recipient.Name}
                    };
                    MessageLogger.Error(props, envelope.Message.ToString());
                    Logger.Error(exception, $"Error while handling the message #{envelope.CorrelationId }of type {envelope.Message.GetType().Name} from {envelope.Sender.Name} to {envelope.Recipient.Name}");
                }

                // ReSharper disable once InvertIf
                if (!handled)
                {
                    if (Options.LogNotHandledMessages)

                    {
                        var props = new Dictionary<string, object>
                        {
                            {"CorrelationId", envelope.CorrelationId},
                            {"MessageIsError", "true"},
                            {"MessageEvent", "DispatchNotHandled"},
                            {"MessageType", envelope.Message.GetType().Name},
                            {"MessageSender", envelope.Sender.Name},
                            {"MessageTarget", envelope.Recipient.Name}
                        };
                        MessageLogger.Warn(props, envelope.Message.ToString());
                    }

                    Logger.Warn($"Not handled message #{envelope.CorrelationId }of type {envelope.Message.GetType().Name} from {envelope.Sender.Name} to {envelope.Recipient.Name}");
                    ActorSystem.DeadLetters.Enqueue(envelope); //send the non-handled message to dead letters queue
                }
            }

            actorRefInternal.ProcessingFinished(); //unlock the actor for further processing by executor
        }


        /// <summary>
        /// Schedule periodic <paramref name="message"/> to be sent to <paramref name="recipient"/> each <paramref name="period"/>.
        /// Creates the <see cref="ScheduledMessageInfo"/> instance based on the parameters and let it add to the internal list of the scheduled messages
        /// </summary>
        /// <param name="sender">Optional information about the sender, usually used by <paramref name="recipient"/> to respond to the <paramref name="message"/></param>
        /// <param name="recipient">Recipient of the message</param>
        /// <param name="period">Period after which the message is enqueued to the <paramref name="recipient"/> queue</param>
        /// <param name="message">Message to be periodically sent to the <paramref name="recipient"/></param>
        /// <returns>Unique ID of scheduled message</returns>
        internal string ScheduleMessage(IActorRef sender, IActorRef recipient, TimeSpan period, object message)
        {
            var msg = new ScheduledMessageInfo(sender, recipient, period, message);
            ScheduleMessage(msg);
            return msg.Id;
        }

        /// <summary>
        /// Schedule one-time <paramref name="message"/> to be sent to <paramref name="recipient"/> at given <paramref name="nextFire">date and time</paramref>
        /// Creates the <see cref="ScheduledMessageInfo"/> instance based on the parameters and let it add to the internal list of the scheduled messages
        /// </summary>
        /// <param name="sender">Optional information about the sender, usually used by <paramref name="recipient"/> to respond to the <paramref name="message"/></param>
        /// <param name="recipient">Recipient of the message</param>
        /// <param name="nextFire">Date and time after which the message is enqueued to the <paramref name="recipient"/> queue</param>
        /// <param name="message">Message to be sent to the <paramref name="recipient"/></param>
        /// <returns>Unique ID of scheduled message</returns>
        internal string ScheduleMessage(IActorRef sender, IActorRef recipient, DateTime nextFire, object message)
        {
            var msg = new ScheduledMessageInfo(sender, recipient, nextFire, message);
            ScheduleMessage(msg);
            return msg.Id;
        }

        /// <summary>
        /// Get's the given <see cref="ScheduledMessageInfo"/> and adds it to internal list of scheduled messages.
        /// </summary>
        /// <param name="msg">Scheduled message description to be added to the internal list of scheduled messages.</param>
        private void ScheduleMessage(ScheduledMessageInfo msg)
        {
            lock (scheduledMessagesLock)
            {
                ScheduledMessages.Add(msg);
            }
        }

        /// <summary>
        /// Cancels the scheduled message with given <paramref name="id"/> - removes the message from list of the scheduled messages
        ///  </summary>
        /// <param name="id">Unique ID of the scheduled message. When the id is not found, it's just ignored.</param>
        /// <returns>True if the message has been found and canceled, false when the message has not been found</returns>
        internal bool CancelScheduledMessage(string id)
        {
            lock (scheduledMessagesLock)
            {
                var item = ScheduledMessages.FirstOrDefault(i => i.Id == id);
                if (item == null) return false;

                ScheduledMessages.Remove(item);
                return true;
            }
        }

        /// <summary>
        /// Cancels all messages scheduled for <paramref name="recipient"/> that are of given <paramref name="messageType"/> - removes the messages from list of the scheduled messages
        ///  </summary>
        /// <param name="recipient">The recipient of the scheduled messages to be canceled.</param>
        /// <param name="messageType">The type of the scheduled messages to be canceled. </param>
        /// <returns>True if at least one message has been found and canceled, false when none has been found</returns>
        internal bool CancelScheduledMessages(IActorRef recipient, Type messageType)
        {
            lock (scheduledMessagesLock)
            {
                var atLeastOne = false;
                var items = ScheduledMessages.FindAll(i => i.Recipient == recipient && i.Message.GetType() == messageType);
                foreach (var item in items)
                {
                    ScheduledMessages.Remove(item);
                    atLeastOne = true;
                }
                return atLeastOne;
            }
        }

        /// <summary>
        /// Gets the list of scheduled messages that should be enqueued (are due)
        /// When the scheduled message is periodic, the next fire time is calculated and a new instance of scheduled message is added to to schedule
        /// </summary>
        /// <returns>The list of scheduled messages that to be enqueued</returns>
        private IEnumerable<ScheduledMessageInfo> GetScheduledMessagesDue()
        {
            List<ScheduledMessageInfo> retVal;
            var refDateTime = DateTime.Now;
            lock (scheduledMessagesLock)
            {
                retVal = ScheduledMessages.FindAll(i => i.NextFire <= refDateTime);
                foreach (var scheduledMessage in retVal)
                {
                    ScheduledMessages.Remove(scheduledMessage);
                    if (scheduledMessage.Period == null) continue;

                    var msg = new ScheduledMessageInfo(scheduledMessage);
                    ScheduledMessages.Add(msg);
                }
            }

            return retVal;
        }

        /// <inheritdoc />
        /// <summary>
        /// Stops the dispatched when disposing
        /// </summary>
        protected override void DisposeManaged()
        {
            Logger.Info("Disposing Dispatcher...");
            base.DisposeManaged();
            Stop();
            Logger.Info("Disposed Dispatcher");
        }
    }
}
