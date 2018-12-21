using net.adamec.lib.common.actor.message;

namespace net.adamec.lib.common.actor.queue
{
    public interface IMessageQueue
    {
        /// <summary> 
        /// Tests if the message queue contains any messages 
        /// </summary>
        bool HasMessages { get; }

        /// <summary> 
        /// Returns the count of messages currently in the message queue 
        /// </summary>
        int Count { get; }

        /// <summary> 
        /// Enqueue an mailbox envelope onto the message queue 
        /// </summary>
       /// <param name="envelope"> The envelope to enqueue </param>
        void Enqueue(Envelope envelope);

        /// <summary> 
        /// Tries to pull an envelope of the message queue 
        /// </summary>
        /// <param name="envelope"> The envelope that was dequeued </param>
        /// <returns><c>true</c> if there's a message in the queue. <c>false</c> otherwise.</returns>
        bool TryDequeue(out Envelope envelope);

        /// <summary>
        /// Called when the <see cref="common.actor.actor.IActorRef"/> this queue belongs to is de-registered.
        /// All remaining messages are transferred  into the <paramref name="deadletters">dead-letter queue</paramref>
        /// </summary>
        /// <param name="deadletters">The dead letters message queue.</param>
        void CleanUp( IMessageQueue deadletters);
    }
}
