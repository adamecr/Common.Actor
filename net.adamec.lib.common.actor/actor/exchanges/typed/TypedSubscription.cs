using System;
using net.adamec.lib.common.actor.actor.exchanges.@base;

namespace net.adamec.lib.common.actor.actor.exchanges.typed
{
    /// <inheritdoc />
    /// <summary>
    /// Subscription for exchanges that routes the messages based on their type
    /// </summary>
    public class TypedSubscription : Subscription
    {
        /// <summary>
        /// <see cref="Type"/> of the message
        /// </summary>
        public Type MessageType { get; }

        /// <inheritdoc />
        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="messageType"><see cref="T:System.Type" /> of the message</param>
        /// <param name="actorRef">Reference to subscribed actor</param>
        public TypedSubscription(Type messageType, IActorRef actorRef) : base(actorRef)
        {
            MessageType = messageType ?? throw new ArgumentNullException(nameof(messageType));
        }
    }
}
