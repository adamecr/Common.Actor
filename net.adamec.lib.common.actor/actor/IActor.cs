using net.adamec.lib.common.actor.message;

namespace net.adamec.lib.common.actor.actor
{
    /// <summary>
    /// Delegate describing the recipient target (method processing the messages)
    /// </summary>
    /// <param name="envelope">Message envelope</param>
    /// <returns>Recipient's method processing the messages</returns>
    public delegate bool Receive(Envelope envelope);

    /// <summary>
    /// Actor interface
    /// </summary>
    public interface IActor
    {
        /// <summary>
        /// Returns true if the actor can receive messages. If false, the messages will not be dispatched to the actor (they will still be enqueued to actor's mailbox)
        /// </summary>
        bool CanReceive { get; }
        /// <summary>
        /// Current method processing the messages (to where the messages are dispatched to)
        /// </summary>
        Receive ReceiveTarget { get; }
    }
}
