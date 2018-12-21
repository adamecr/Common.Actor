using net.adamec.lib.common.actor.actor.exchanges.@base;
using net.adamec.lib.common.actor.actorsystem;

namespace net.adamec.lib.common.actor.actor.exchanges.single
{
    /// <inheritdoc />
    /// <summary>
    /// Exchange Actor with zero or one subscriber 
    /// </summary>
    public class SingleExchangeActor : ExchangeActor<Subscription, SubscriptionMessage, UnSubscriptionMessage>
    {
        /// <inheritdoc />
        /// <summary>
        /// CTOR 
        /// </summary>
        /// <param name="actorSystem">Actor system</param>
        /// <param name="name">Name of the exchange actor</param>
        public SingleExchangeActor(IActorSystem actorSystem, string name) : base(actorSystem, name)
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Creates a new <see cref="Subscription"/> instance for incoming <paramref name="subscriptionMessage"/>
        /// </summary>
        /// <param name="actorRef">Reference to subscribing actor</param>
        /// <param name="subscriptionMessage">Subscription message</param>
        /// <returns>Subscription instance</returns>
        protected override Subscription SubscriptionFactory(IActorRef actorRef, SubscriptionMessage subscriptionMessage)
        {
            return new Subscription(actorRef);
        }

        /// <inheritdoc />
        /// <summary>
        /// Removes all existing subscription when a new subscription message arrives.
        /// </summary>
        /// <param name="actorRef">Reference to subscribing actor</param>
        /// <param name="subscriptionMessage">Subscription message</param>
        /// <returns>List of all existing subscriptions</returns>
        protected override Subscription[] ReplaceOnSubscribe(IActorRef actorRef, SubscriptionMessage subscriptionMessage)
        {
            return Subscriptions.ToArray();
        }
    }
}
