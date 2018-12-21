using System.Linq;
using net.adamec.lib.common.actor.actor.exchanges.@base;
using net.adamec.lib.common.actor.actorsystem;
using net.adamec.lib.common.actor.message;

namespace net.adamec.lib.common.actor.actor.exchanges.typed
{
    /// <inheritdoc />
    /// <summary>
    /// Exchange Actor with zero or more actors per message type
    /// Subscriptions are per actor and type.
    /// Subscription filter gets the all subscriptions where message is instance of  filter type or its children
    /// </summary>
    public class TypedMultiExchangeActor : ExchangeActor<TypedSubscription, TypedSubscriptionMessage, TypedUnSubscriptionMessage>
    {
        /// <inheritdoc />
        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="actorSystem">Actor system</param>
        /// <param name="name">Name of the exchange actor</param>
        public TypedMultiExchangeActor(IActorSystem actorSystem, string name) : base(actorSystem, name)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Creates a new <see cref="T:net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription" /> instance based on the <paramref name="subscriptionMessage" />
        /// </summary>
        /// <param name="actorRef">Reference to subscribing actor</param>
        /// <param name="subscriptionMessage">Subscription message</param>
        /// <returns>Subscription instance</returns>
        protected override TypedSubscription SubscriptionFactory(IActorRef actorRef, TypedSubscriptionMessage subscriptionMessage)
        {
            return new TypedSubscription(subscriptionMessage.MessageType, actorRef);
        }

        /// <inheritdoc />
        /// <summary>
        /// Removes existing subscriptions for <paramref name="actorRef"/> with the same "subscription type" when a new subscription message arrives.
        /// </summary>
        /// <param name="actorRef">Reference to subscribing actor</param>
        /// <param name="subscriptionMessage">Subscription message</param>
        /// <returns>List of all existing subscriptions</returns>
        protected override TypedSubscription[] ReplaceOnSubscribe(IActorRef actorRef, TypedSubscriptionMessage subscriptionMessage)
        {
            return Subscriptions.Where(s => actorRef == s.ActorRef && subscriptionMessage.MessageType == s.MessageType).ToArray();
        }

        /// <inheritdoc />
        /// <summary>
        /// Checks whether the <paramref name="unSubscriptionMessage" /> can unsubscribe the <paramref name="subscription" /> (both related to the same actor)
        /// The match is when both <paramref name="subscription" /> and <paramref name="unSubscriptionMessage" /> use the same message type
        /// </summary>
        /// <param name="subscription">Existing subscription</param>
        /// <param name="unSubscriptionMessage">UnSubscription message</param>
        /// <returns>Returns true when the <paramref name="unSubscriptionMessage" /> unsubscribes the <paramref name="subscription" />, otherwise false is returned</returns>
        protected override bool IsUnSubscribeMatch(TypedSubscription subscription, TypedUnSubscriptionMessage unSubscriptionMessage)
        {
            return subscription.MessageType == unSubscriptionMessage.MessageType;
        }

        /// <inheritdoc />
        /// <summary>
        /// Returns the list of subscriptions that match the incoming <paramref name="envelope" />
        ///  The filter gets all matches where message is instance of  filter type or its children
        /// </summary>
        /// <param name="envelope">Incoming message</param>
        /// <returns>List of subscriptions that match the incoming <paramref name="envelope" /></returns>
        protected override TypedSubscription[] GetSubscriptionsForMessage(Envelope envelope)
        {
            return Subscriptions.Where(s => s.MessageType.IsInstanceOfType(envelope.Message)).ToArray();
        }
    }
}

