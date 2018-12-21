using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using net.adamec.lib.common.actor.actor;
using net.adamec.lib.common.actor.queue;
using net.adamec.lib.common.extensions;
using net.adamec.lib.common.logging;
using net.adamec.lib.common.utils;

namespace net.adamec.lib.common.actor.actorsystem
{
    /// <inheritdoc cref="IActorSystem"/>
    /// <summary>
    /// Implementation of actor system
    /// </summary>
    public class ActorSystem : BaseDisposable, IActorSystem
    {
        protected static ILogger Logger = CommonLogging.CreateLogger<ActorSystem>();

        /// <inheritdoc />
        /// <summary>
        /// Returns the reference to current <see cref="T:net.adamec.lib.common.actor.actorsystem.ActorSystemOptions" />
        /// </summary>
        public ActorSystemOptions Options { get; }

        /// <summary>
        /// Dictionary of actors by actor reference
        /// </summary>
        private ConcurrentDictionary<IActorRef, IActor> ActorsByRef { get; } =
            new ConcurrentDictionary<IActorRef, IActor>();

        /// <inheritdoc />
        /// <summary>
        /// Provides the access to dead letters queue
        /// </summary>
        public IMessageQueue DeadLetters { get; }
        /// <inheritdoc />
        /// <summary>
        /// Provides the access to error messages queue
        /// </summary>
        public IMessageQueue ErrorMessageQueue { get; }

        /// <summary>
        /// Reference to dispatcher used by actor system
        /// </summary>
        private ActorSystemDispatcher Dispatcher { get; }

        /// <summary>
        /// <see cref="ActorSystem"/> constructor
        /// </summary>
        /// <param name="options">Actor system configuration options</param>
        public ActorSystem(ActorSystemOptions options)
        {
            Logger.Info("Starting Actor System...");
            Options = options;
            DeadLetters = new ManagedMessageQueue();
            ErrorMessageQueue = new ManagedMessageQueue();

            Dispatcher = new ActorSystemDispatcher(this);
            Dispatcher.Start();

            Logger.Info("Actor System started");
        }

        /// <inheritdoc />
        /// <summary>
        /// Registers the <paramref name="actor"/> to actor system.
        /// Name of the actor should be unique, but this is not checked. Each actor must register first to be able to receive the messages within the actor system.
        /// </summary>
        /// <param name="actor">Actor to be registered</param>
        /// <param name="name">Name of the actor. Name of the actor should be unique, but this is not checked. Name is mandatory and can't be empty</param>
        /// <returns>Actor reference to the registered actor</returns>
        public IActorRef RegisterActor(IActor actor, string name)
        {
            Logger.Info($"Registering actor {name}...");
            var actorRef = new ActorRefInternal(actor, name, this);

            ActorsByRef.TryAdd(actorRef, actor);

            Logger.Info($"Registered actor {name}");
            return actorRef;
        }

        /// <inheritdoc />
        /// <summary>
        /// De-register actor identified by <paramref name="actorRef" /> from the actor system
        /// If <paramref name="actorRef" /> is not found within the actor system, WARN message is logged, but raises no error/exception
        /// </summary>
        /// <param name="actorRef">Reference to actor to be de-registered</param>
        public void DeRegisterActor(IActorRef actorRef)
        {
            Logger.Info($"DeRegistering actor {actorRef.Name}");
            if (!ActorsByRef.ContainsKey(actorRef))
            {
                Logger.Warn($"DeRegistering actor {actorRef.Name} - actor not found");
                return;
            }

            if (actorRef is ActorRefInternal actorRefInternal)
            {
                actorRefInternal.Queue.CleanUp(DeadLetters);
            }

            ActorsByRef.TryRemove(actorRef, out _);
            Logger.Info($"DeRegistered actor {actorRef.Name}");
        }

        /// <inheritdoc />
        /// <summary>
        /// Starts the message dispatcher (started by default within ActorSystem constructor)
        /// </summary>
        public void Start()
        {
            Dispatcher.Start();
        }

        /// <inheritdoc />
        /// <summary>
        /// Stops the message dispatcher (can be restarted using <see cref="M:net.adamec.lib.common.actor.actorsystem.ActorSystem.Start" /> method)
        /// </summary>
        public void Stop()
        {
            Dispatcher.Stop();
        }

        /// <summary>
        /// Returns the list of the mailboxes (internal actor references) that have at least one message and the actor is not being already processed
        /// </summary>
        /// <returns>List of mailboxes(internal actor references) having the messages for processing</returns>
        internal List<ActorRefInternal> GetMailboxesWithMessages()
        {
            var retVal = new List<ActorRefInternal>();
            foreach (var actorRef in ActorsByRef.Keys)
            {
                if (!(actorRef is ActorRefInternal actorRefInternal)) continue;

                if (actorRefInternal.Queue.HasMessages && !actorRefInternal.IsBeingProcessed)
                {
                    retVal.Add(actorRefInternal);
                }
            }

            return retVal;
        }

        /// <inheritdoc />
        /// <summary>
        /// Schedule periodic <paramref name="message" /> to be sent to <paramref name="recipient" /> each <paramref name="period" />.
        /// </summary>
        /// <param name="sender">Optional information about the sender, usually used by <paramref name="recipient" /> to respond to the <paramref name="message" /></param>
        /// <param name="recipient">Recipient of the message</param>
        /// <param name="period">Period after which the message is periodically enqueued to the <paramref name="recipient" /> queue</param>
        /// <param name="message">Message to be periodically sent to the <paramref name="recipient" /></param>
        /// <returns>Unique ID of scheduled message</returns>
        public string ScheduleMessage(IActorRef sender, IActorRef recipient, TimeSpan period, object message)
        {
            return Dispatcher.ScheduleMessage(sender, recipient, period, message);
        }

        /// <inheritdoc />
        /// <summary>
        /// Schedule one-time <paramref name="message" /> to be sent to <paramref name="recipient" /> at given <paramref name="nextFire">date and time</paramref>
        /// </summary>
        /// <param name="sender">Optional information about the sender, usually used by <paramref name="recipient" /> to respond to the <paramref name="message" /></param>
        /// <param name="recipient">Recipient of the message</param>
        /// <param name="nextFire">Date and time after which the message is enqueued to the <paramref name="recipient" /> queue</param>
        /// <param name="message">Message to be sent to the <paramref name="recipient" /></param>
        /// <returns>Unique ID of scheduled message</returns>
        public string ScheduleMessage(IActorRef sender, IActorRef recipient, DateTime nextFire, object message)
        {
            return Dispatcher.ScheduleMessage(sender, recipient, nextFire, message);
        }

        /// <inheritdoc />
        /// <summary>
        /// Cancels the scheduled message with given <paramref name="id" /> - removes the message from list of the scheduled messages
        ///  </summary>
        /// <param name="id">Unique ID of the scheduled message. When the id is not found, it's just ignored.</param>
        /// <returns>True if the message has been found and canceled, false when the message has not been found</returns>
        public bool CancelScheduledMessage(string id)
        {
            return Dispatcher.CancelScheduledMessage(id);
        }
        /// <inheritdoc />
        /// <summary>
        /// Cancels all messages scheduled for <paramref name="recipient" /> that are of given <paramref name="messageType" /> - removes the messages from list of the scheduled messages
        ///  </summary>
        /// <param name="recipient">The recipient of the scheduled messages to be canceled.</param>
        /// <param name="messageType">The type of the scheduled messages to be canceled. </param>
        /// <returns>True if at least one message has been found and canceled, false when none has been found</returns>
        public bool CancelScheduledMessages(IActorRef recipient, Type messageType)
        {
            return Dispatcher.CancelScheduledMessages(recipient, messageType);
        }

        /// <inheritdoc />
        /// <summary>
        /// Sends a request <paramref name="message" /> to <paramref name="recipient" /> and waits for the response of type <typeparam name="T"></typeparam>.
        /// </summary>
        /// <typeparam name="T"><see cref="T:System.Type" /> of the message to wait for</typeparam>
        /// <param name="recipient">Reference to recipient actor</param>
        /// <param name="message">Request message</param>
        /// <param name="timeoutMilliseconds">Timeout for the response</param>
        /// <param name="throwTimeoutException">If true, the <see cref="T:System.TimeoutException" /> is raised, otherwise the default(T) response is returned</param>
        /// <returns>The "synchronous" response</returns>
        public T Ask<T>(IActorRef recipient, object message, int timeoutMilliseconds, bool throwTimeoutException = false)
        {
            return (T)Ask(recipient, message, typeof(T), timeoutMilliseconds, throwTimeoutException);
        }

        /// <inheritdoc />
        /// <summary>
        /// Sends a request <paramref name="message" /> to <paramref name="recipient" /> and waits for the response of required <paramref name="responseType" />.
        /// </summary>
        /// <param name="recipient">Reference to recipient actor</param>
        /// <param name="message">Request message</param>
        /// <param name="responseType"><see cref="T:System.Type" /> of the message to wait for</param>
        /// <param name="timeoutMilliseconds">Timeout for the response</param>
        /// <param name="throwTimeoutException">If true, the <see cref="T:System.TimeoutException" /> is raised, otherwise the default(T) response is returned</param>
        /// <returns>The "synchronous" response</returns>
        public object Ask(IActorRef recipient, object message, Type responseType, int timeoutMilliseconds, bool throwTimeoutException = false)
        {
            if (recipient == null) throw new ArgumentNullException(nameof(recipient));
            if (message == null) throw new ArgumentNullException(nameof(message));
            if (responseType == null) throw new ArgumentNullException(nameof(responseType));

            using (var waitHandle = new AutoResetEvent(false))
            {
                using (var actor = new SyncActor(this, responseType, waitHandle))
                {
                    recipient.Tell(message, actor.Self);

                    if (waitHandle.WaitOne(timeoutMilliseconds, false))
                    {
                        return actor.Response.Message;
                    }
                }
            }
            if (throwTimeoutException) throw new TimeoutException();
            return responseType.GetDefaultValue();
        }

        /// <inheritdoc />
        /// <summary>
        /// Stops and disposes the <see cref="Dispatcher"/>
        /// </summary>
        protected override void DisposeManaged()
        {
            Logger.Info("Disposing Actor System ...");
            base.DisposeManaged();
            Dispatcher.Stop();
            Dispatcher.Dispose();
            Logger.Info("Disposed Actor System");
        }
    }
}

