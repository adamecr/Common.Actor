using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using net.adamec.lib.common.actor.message;

namespace net.adamec.lib.common.actor.queue
{
    /// <inheritdoc cref="IMessageQueue" />
    /// <summary>
    /// Message queue for <see cref="T:net.adamec.home.control.common.actor.manager.mailbox.ManagedUnboundedDequeBasedMailbox" /> allowing the monitoring (access to) messages stores in the queue
    /// The main queue is implemented using <see cref="T:net.adamec.home.control.common.actor.manager.mailbox.ManagedMessageQueue" /> and also
    /// uses a <see cref="T:System.Collections.Generic.Stack`1" /> internally to store each individual <see cref="M:net.adamec.home.control.common.actor.manager.mailbox.ManagedMessageQueue.EnqueueFirst(Akka.Actor.Envelope)" /> messages - supports stashing
    /// </summary>
    public class ManagedMessageQueue : IMessageQueue
    {
        // doesn't need to be thread-safe - only called from within actor
        private readonly Stack<Envelope> prependBuffer = new Stack<Envelope>();

        /// <summary>
        /// The underlying <see cref="InternalQueue"/>.
        /// </summary>
        protected readonly IMessageQueue MessageQueue;

        /// <summary>
        /// Creates <see cref="ManagedMessageQueue"/>
        /// </summary>
        public ManagedMessageQueue()
        {
            MessageQueue = new InternalQueue();
        }

        /// <inheritdoc />
        /// <summary>
        /// Returns true if there are any messages inside the queue.
        /// </summary>
        public bool HasMessages => Count > 0;

        /// <inheritdoc />
        /// <summary>
        /// Returns the number of messages in both the internal message queue
        /// and the prepend buffer.
        /// </summary>
        public int Count => MessageQueue.Count + prependBuffer.Count;

        /// <inheritdoc cref="IMessageQueue"/>
        /// <summary>
        /// Enqueue a new message envelope 
        /// </summary>
        /// <param name="envelope">Message envelope</param>
        public void Enqueue(Envelope envelope)
        {
            MessageQueue.Enqueue(envelope);
        }

        /// <inheritdoc cref="IMessageQueue"/>
        /// <summary>
        /// Attempt to dequeue a message from the front of the prepend buffer.
        /// 
        /// If the prepend buffer is empty, dequeue a message from the main message queue
        /// </summary>
        /// <param name="envelope">The message to return, if any</param>
        /// <returns><c>true</c> if a message was available, <c>false</c> otherwise.</returns>
        public bool TryDequeue(out Envelope envelope)
        {
            // ReSharper disable once InvertIf
            if (prependBuffer.Count > 0)
            {
                envelope = prependBuffer.Pop();
                return true;
            }

            return MessageQueue.TryDequeue(out envelope);
        }

        /// <inheritdoc cref="IMessageQueue"/>
        /// <summary>
        /// Cleans the queue, the messages are sent to <paramref name="deadletters"/> queue
        /// </summary>
        /// <param name="deadletters">DeadLetters queue</param>
        public void CleanUp(IMessageQueue deadletters)
        {
            while (TryDequeue(out var msg))
            {
                deadletters.Enqueue(msg);
            }
        }

        /// <summary>
        /// Add a message to the front of the queue via the prepend buffer.
        /// </summary>
        /// <param name="envelope">The message we wish to append to the front of the queue.</param>
        public void EnqueueFirst(Envelope envelope)
        {
            prependBuffer.Push(envelope);
        }

        /// <summary>
        /// Gets the all queued messages stored in the prepend buffer and main queue. The messages in the array must not be modified!!!
        /// </summary>
        /// <returns>All queued messages stored in the prepend buffer and main queue. The messages in the array must not be modified!!!</returns>
        [ExcludeFromCodeCoverage]
        public Envelope[] Copy()
        {
            var prepend = prependBuffer.ToArray();
            var message = ((InternalQueue)MessageQueue).Copy();
            var list = new List<Envelope>();
            list.AddRange(prepend);
            list.AddRange(message);
            return list.ToArray();
        }
    }
}
