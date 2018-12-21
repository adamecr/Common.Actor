using System.Linq;
using net.adamec.lib.common.actor.actor.exchanges.@base;
using net.adamec.lib.common.actor.actorsystem;
using net.adamec.lib.common.actor.message;

namespace net.adamec.lib.common.actor.actor.exchanges.typed
{
    /// <inheritdoc />
    /// <summary>
    /// Exchange Actor with zero or more actors per message type with routing based also on routing key
    /// Subscriptions are per actor, type and routing key.
    /// Subscription filter gets the all subscriptions where message is instance of  filter type or its children and the routing keys match
    /// </summary>
    public class RoutingKeyExchangeActor : ExchangeActor<RoutingKeySubscription, RoutingKeySubscriptionMessage, RoutingKeyUnSubscriptionMessage>
    {
        /// <inheritdoc />
        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="actorSystem">Actor system</param>
        /// <param name="name">Name of the exchange actor</param>
        public RoutingKeyExchangeActor(IActorSystem actorSystem, string name) : base(actorSystem, name)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Creates a new <see cref="T:net.adamec.lib.common.actor.actor.exchanges.typed.TypedRoutingKeySubscription" /> instance based on the <paramref name="subscriptionMessage" />
        /// </summary>
        /// <param name="actorRef">Reference to subscribing actor</param>
        /// <param name="subscriptionMessage">Subscription message</param>
        /// <returns>Subscription instance</returns>
        protected override RoutingKeySubscription SubscriptionFactory(IActorRef actorRef, RoutingKeySubscriptionMessage subscriptionMessage)
        {
            return new RoutingKeySubscription(subscriptionMessage.MessageType, subscriptionMessage.RoutingKey, actorRef);
        }

        /// <inheritdoc />
        /// <summary>
        /// Removes existing subscriptions for <paramref name="actorRef"/> with the same "subscription type" when a new subscription message arrives.
        /// </summary>
        /// <param name="actorRef">Reference to subscribing actor</param>
        /// <param name="subscriptionMessage">Subscription message</param>
        /// <returns>List of all existing subscriptions</returns>
        protected override RoutingKeySubscription[] ReplaceOnSubscribe(IActorRef actorRef, RoutingKeySubscriptionMessage subscriptionMessage)
        {
            return Subscriptions.Where(s => actorRef == s.ActorRef &&
                                            subscriptionMessage.MessageType == s.MessageType &&
                                            subscriptionMessage.RoutingKey == s.RoutingKey).ToArray();
        }

        /// <inheritdoc />
        /// <summary>
        /// Checks whether the <paramref name="unSubscriptionMessage" /> can unsubscribe the <paramref name="subscription" /> (both related to the same actor)
        /// The match is when both <paramref name="subscription" /> and <paramref name="unSubscriptionMessage" /> use the same message type
        /// </summary>
        /// <param name="subscription">Existing subscription</param>
        /// <param name="unSubscriptionMessage">UnSubscription message</param>
        /// <returns>Returns true when the <paramref name="unSubscriptionMessage" /> unsubscribes the <paramref name="subscription" />, otherwise false is returned</returns>
        protected override bool IsUnSubscribeMatch(RoutingKeySubscription subscription, RoutingKeyUnSubscriptionMessage unSubscriptionMessage)
        {
            return subscription.MessageType == unSubscriptionMessage.MessageType &&
                   subscription.RoutingKey == unSubscriptionMessage.RoutingKey;
        }

        /// <inheritdoc />
        /// <summary>
        /// Returns the list of subscriptions that match the incoming <paramref name="envelope" />
        ///  The filter gets all matches where message is instance of  filter type or its children and the routing key matches the subscription
        /// </summary>
        /// <param name="envelope">Incoming message</param>
        /// <returns>List of subscriptions that match the incoming <paramref name="envelope" /></returns>
        protected override RoutingKeySubscription[] GetSubscriptionsForMessage(Envelope envelope)
        {
            return Subscriptions.Where(s =>
                s.MessageType.IsInstanceOfType(envelope.Message) &&
                (s.RoutingKey == null || IsRoutingKeyMatch(s.RoutingKey, envelope.RoutingKey))).ToArray();
        }

        /// <summary>
        /// Checks whether the message routing key matches the subscription routing key
        /// The default implementation is for the exact match, override this method for more complex matching (for example regexp)
        /// </summary>
        /// <param name="subscriptionRoutingKey">Subscription routing key</param>
        /// <param name="messageRoutingKey">Message routing key</param>
        /// <returns>True when the message routing key matches the subscription routing key, otherwise false</returns>
        protected virtual bool IsRoutingKeyMatch(string subscriptionRoutingKey, string messageRoutingKey)
        {
            return subscriptionRoutingKey == messageRoutingKey;
        }
    }
}
