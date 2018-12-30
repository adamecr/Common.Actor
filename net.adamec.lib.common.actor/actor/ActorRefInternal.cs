using System;
using System.Collections.Generic;
using net.adamec.lib.common.actor.actorsystem;
using net.adamec.lib.common.actor.message;
using net.adamec.lib.common.actor.queue;
using net.adamec.lib.common.logging;

namespace net.adamec.lib.common.actor.actor
{
    /// <inheritdoc />
    /// <summary>
    /// Internal implementation of actor reference.
    /// Encapsulates the mailbox (queue) for the actor
    /// </summary>
    internal class ActorRefInternal : IActorRef
    {
        protected static ILogger MessageLogger = CommonLogging.CreateLogger(typeof(ActorRefInternal).Name + ".[MESSAGE]");

        /// <summary>
        /// Actor systems
        /// </summary>
        private readonly IActorSystem actorSystem;
        /// <summary>
        /// Actor the reference belongs to
        /// </summary>
        internal IActor Actor { get; }
        /// <summary>
        /// Actor's mailbox (message queue)
        /// </summary>
        internal IMessageQueue Queue { get; }

        /// <summary>
        /// Log used for <see cref="isBeingProcessed"/> flag ensuring the thread safe operations
        /// </summary>
        private readonly object isBeingProcessedLock = new object();
        /// <summary>
        /// Flag whether the actor (mailbox) is being processed
        /// </summary>
        private bool isBeingProcessed;
        /// <summary>
        /// Flag whether the actor (mailbox) is being processed
        /// </summary>
        internal bool IsBeingProcessed
        {
            get
            {
                lock (isBeingProcessedLock)
                {
                    return isBeingProcessed;
                }
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Name of the actor
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// CTOR
        /// Creates the mailbox (queue) for the actor
        /// </summary>
        /// <param name="actor">Actor</param>
        /// <param name="name">Name of the actor</param>
        /// <param name="actorSystem">Actor system</param>
        internal ActorRefInternal(IActor actor, string name, IActorSystem actorSystem)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));

            Actor = actor ?? throw new ArgumentNullException(nameof(actor));
            this.actorSystem = actorSystem;
            Name = name;
            Queue = new ManagedMessageQueue();
        }

        /// <summary>
        /// Locks the actor for message processing
        /// </summary>
        internal void LockForProcessing()
        {
            lock (isBeingProcessedLock)
            {
                isBeingProcessed = true;
            }
        }

        /// <summary>
        /// Unlocks the actor for message processing
        /// </summary>
        internal void ProcessingFinished()
        {
            lock (isBeingProcessedLock)
            {
                isBeingProcessed = false;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Asynchronously delivers a message actor's mailbox in a non-blocking fashion.
        /// </summary>
        /// <param name="message">The message to be sent to the actor.</param>
        /// <param name="sender">The sender of this message. Defaults to <see cref="P:net.adamec.lib.common.actor.actor.ActorRefs.Empty" /> if left to <c>null</c>.</param>
        /// <param name="routingKey">Optional routing key - additional information that can be used for routing/processing the message</param>
        public void Tell(object message, IActorRef sender, string routingKey = null)
        {
            var envelope = new Envelope(sender ?? ActorRefs.Empty, this, message, routingKey);
            Queue.Enqueue(envelope);
            // ReSharper disable once InvertIf
            if (MessageLogger.IsDebugEnabled && actorSystem.Options.LogEnqueuedMessages)
            {
                var props = new Dictionary<string, object>
                {
                    {"CorrelationId", envelope.CorrelationId},
                    {"MessageIsError", "false"},
                    {"MessageEvent", "Enqueue"},
                    {"MessageType", envelope.Message.GetType().Name},
                    {"MessageSender", envelope.Sender.Name},
                    {"MessageTarget", envelope.Recipient.Name}
                };
                MessageLogger.Debug(props, envelope.Message.ToString());
            }
        }
    }
}
