using System;

namespace net.adamec.lib.common.actor.actor.exchanges.typed
{
    /// <inheritdoc />
    /// <summary>
    /// Subscription for exchanges that routes the messages based on their type and routing key
    /// </summary>
    public class RoutingKeySubscription : TypedSubscription
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
        /// <param name="actorRef">Reference to subscribed actor</param>
        public RoutingKeySubscription(Type messageType, string routingKey, IActorRef actorRef) : base(messageType,actorRef)
        {
            RoutingKey = routingKey;
        }
    }
}
