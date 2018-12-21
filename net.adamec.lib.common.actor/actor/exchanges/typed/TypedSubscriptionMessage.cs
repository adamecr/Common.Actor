using System;
using net.adamec.lib.common.actor.actor.exchanges.@base;

namespace net.adamec.lib.common.actor.actor.exchanges.typed
{
    /// <inheritdoc />
    /// <summary>
    /// Subscription message for <see cref="TypedSubscription"/>
    /// </summary>
    public class TypedSubscriptionMessage:SubscriptionMessage
    {
        /// <summary>
        /// <see cref="T:System.Type" /> of the message
        /// </summary>
        public Type MessageType { get; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="messageType"><see cref="T:System.Type" /> of the message</param>
        public TypedSubscriptionMessage(Type messageType)
        {
            MessageType = messageType ?? throw new ArgumentNullException(nameof(messageType));
        }
    }

    /// <inheritdoc />
    /// <summary>
    /// UnSubscription message for <see cref="TypedSubscription"/>
    /// </summary>
    public class TypedUnSubscriptionMessage:UnSubscriptionMessage
    {
        /// <summary>
        /// <see cref="T:System.Type" /> of the message
        /// </summary>
        public Type MessageType { get; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="messageType"><see cref="T:System.Type" /> of the message</param>
        public TypedUnSubscriptionMessage(Type messageType)
        {
            MessageType = messageType ?? throw new ArgumentNullException(nameof(messageType));
        }
    }
}
