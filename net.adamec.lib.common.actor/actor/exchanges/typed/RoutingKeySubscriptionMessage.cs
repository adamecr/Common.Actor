using System;

namespace net.adamec.lib.common.actor.actor.exchanges.typed
{
    /// <inheritdoc />
    /// <summary>
    /// Subscription message for <see cref="RoutingKeySubscription"/>
    /// </summary>
    public class RoutingKeySubscriptionMessage : TypedSubscriptionMessage
    {
        /// <summary>
        /// Routing key filter (if null, matches all messages)
        /// </summary>
        public string RoutingKey { get; }

        /// <inheritdoc />
        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="messageType"><see cref="T:System.Type" /> of the message</param>
        /// <param name="routingKey">Routing key filter (if null, matches all messages)</param>
        public RoutingKeySubscriptionMessage(Type messageType, string routingKey):base(messageType)
        {
            RoutingKey = routingKey;
        }
    }

    /// <inheritdoc />
    /// <summary>
    /// UnSubscription message for <see cref="RoutingKeySubscription"/>
    /// </summary>
    public class RoutingKeyUnSubscriptionMessage : TypedUnSubscriptionMessage
    {
        /// <summary>
        /// Routing key filter (if null, matches all messages)
        /// </summary>
        public string RoutingKey { get; }

        /// <inheritdoc />
        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="messageType"><see cref="T:System.Type" /> of the message</param>
        /// <param name="routingKey">Routing key filter (if null, matches all messages)</param>
        public RoutingKeyUnSubscriptionMessage(Type messageType, string routingKey) : base(messageType)
        {
            RoutingKey = routingKey;
        }
    }
}
