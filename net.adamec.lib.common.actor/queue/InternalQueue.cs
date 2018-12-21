using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using net.adamec.lib.common.actor.message;

namespace net.adamec.lib.common.actor.queue
{
    /// <inheritdoc cref="IMessageQueue"/>
    /// <summary>
    /// An unbounded mailbox managed message queue used by <see cref="ManagedMessageQueue"/> as the main message queue
    /// Allows access to stored messages for monitoring using <see cref="Copy"/>. Note: the messages in the array must not be modified!!!
    /// </summary>
    internal class InternalQueue :IMessageQueue
    {
        /// <summary>
        /// Internal queue
        /// </summary>
        private readonly ConcurrentQueue<Envelope> queue = new ConcurrentQueue<Envelope>();

        /// <inheritdoc cref="IMessageQueue"/>
        /// <summary>
        /// Flag whether the queue contains any messages
        /// </summary>
        public bool HasMessages => !queue.IsEmpty;

        /// <inheritdoc cref="IMessageQueue"/>
        /// <summary>
        /// Number of messages in the queue
        /// </summary>
        public int Count => queue.Count;

        /// <inheritdoc cref="IMessageQueue"/>
        /// <summary>
        /// Enqueue a new message envelope
        /// </summary>
        /// <param name="envelope">Message envelope</param>
        public void Enqueue(Envelope envelope)
        {
            queue.Enqueue(envelope);
        }

        /// <inheritdoc cref="IMessageQueue"/>
        /// <summary>
        /// Tries to dequeue a message from the queue
        /// </summary>
        /// <param name="envelope">Message envelope dequeued</param>
        /// <returns>True if any message is returned in <paramref name="envelope"/></returns>
        public bool TryDequeue(out Envelope envelope)
        {
            return queue.TryDequeue(out envelope);
        }

        /// <inheritdoc cref="IMessageQueue"/>
        /// <summary>
        /// Cleans the queue, the messages are sent to <paramref name="deadletters"/> queue
        /// </summary>
        /// <param name="deadletters">DeadLetters queue</param>
        ///
        /// 
        [ExcludeFromCodeCoverage]
        public void CleanUp( IMessageQueue deadletters)
        {
            while (TryDequeue(out var envelope))
            {
                deadletters.Enqueue( envelope);
            }
        }

        /// <summary>
        /// Gets the messages stored in the queue. The messages in the array must not be modified!!!
        /// </summary>
        /// <returns>Messages stored in the queue. The messages in the array must not be modified!!!</returns>
        [ExcludeFromCodeCoverage]
        public Envelope[] Copy()
        {
            return queue.ToArray();
        }
    }
}
