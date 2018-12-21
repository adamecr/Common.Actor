using System.Collections.Generic;
using System.Linq;
using net.adamec.lib.common.actor.actorsystem;
using net.adamec.lib.common.actor.message;

namespace net.adamec.lib.common.actor.actor.exchanges.@base
{
    /// <inheritdoc />
    /// <summary>
    /// Exchange actor base class providing the common logic for implementation of exchanges - the actors routing the messages to another actors based on subscriptions.
    /// </summary>
    /// <typeparam name="TSubscription">Type of the subscription</typeparam>
    /// <typeparam name="TSubscriptionMessage">Type of the subscription message</typeparam>
    /// <typeparam name="TUnSubscriptionMessage">Type of the unSubscription message</typeparam>
    public abstract class ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage> : Actor
        where TSubscription:Subscription
        where TSubscriptionMessage : SubscriptionMessage 
        where TUnSubscriptionMessage : UnSubscriptionMessage
    {
        /// <summary>
        /// List of subscriptions
        /// </summary>
        protected List<TSubscription> Subscriptions { get; } = new List<TSubscription>();

        /// <inheritdoc />
        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="actorSystem">Actor system</param>
        /// <param name="name">Name of the exchange actor</param>
        protected ExchangeActor(IActorSystem actorSystem, string name) : base(actorSystem, name)
        {
        }

        /// <summary>
        /// Starts the exchange actor
        /// </summary>
        public virtual void Start()
        {
            CanReceive = true;
        }

        /// <summary>
        /// Stops the exchange actor
        /// </summary>
        public virtual void Stop()
        {
            CanReceive = false;
        }

        /// <summary>
        /// Creates a new subscription instance based on the <paramref name="subscriptionMessage"/>
        /// </summary>
        /// <param name="actorRef">Reference to subscribing actor</param>
        /// <param name="subscriptionMessage">Subscription message</param>
        /// <returns>Subscription instance</returns>
        protected abstract TSubscription SubscriptionFactory(IActorRef actorRef,TSubscriptionMessage subscriptionMessage);

        /// <summary>
        /// Checks for the list of existing subscriptions that are to be replaced by the new subscription defined in <paramref name="subscriptionMessage"/>
        /// The new subscription can replace the existing subscriptions of other actors.There is no "signaling" to the actors, that their subscription has been replaced (canceled).
        /// </summary>
        /// <param name="actorRef">Reference to subscribing actor</param>
        /// <param name="subscriptionMessage">Subscription message</param>
        /// <returns>List of existing subscriptions to be removed from the <see cref="Subscriptions"/> list</returns>
        protected virtual TSubscription[] ReplaceOnSubscribe(IActorRef actorRef,TSubscriptionMessage subscriptionMessage)
        {
            return null;
        }

        /// <summary>
        /// Processes the subscription message
        /// It first checks, whether the new subscription replaces any existing subscription by calling <see cref="ReplaceOnSubscribe"/>.
        /// If the returned list is not empty, the replaces subscriptions are removed from the <see cref="Subscriptions"/> list.
        /// The <see cref="SubscriptionFactory"/> is called to create the new instance of subscription and the subscription is added to the <see cref="Subscriptions"/> list.
        /// </summary>
        /// <param name="actorRef">Reference to subscribing actor</param>
        /// <param name="subscriptionMessage">Subscription message</param>
        protected virtual void Subscribe(IActorRef actorRef, TSubscriptionMessage subscriptionMessage)
        {
            var subscriptionsToReplace = ReplaceOnSubscribe(actorRef, subscriptionMessage);
            if (subscriptionsToReplace != null && subscriptionsToReplace.Length > 0)
            {
                foreach (var subscription in subscriptionsToReplace)
                {
                    Subscriptions.Remove(subscription);
                }
            }
            Subscriptions.Add(SubscriptionFactory(actorRef,subscriptionMessage));
        }

        /// <summary>
        /// Checks whether the <paramref name="unSubscriptionMessage"/> can unsubscribe the <paramref name="subscription"/> (both related to the same actor)
        /// </summary>
        /// <param name="subscription">Existing subscription</param>
        /// <param name="unSubscriptionMessage">UnSubscription message</param>
        /// <returns>Returns true when the <paramref name="unSubscriptionMessage"/> unsubscribes the <paramref name="subscription"/>, otherwise false is returned</returns>
        protected virtual bool IsUnSubscribeMatch(TSubscription subscription,TUnSubscriptionMessage unSubscriptionMessage)
        {
            return true;
        }

        /// <summary>
        /// Processes the unsubscription message
        /// Checks the existing subscriptions of <paramref name="actorRef"/> whether they match the <paramref name="unSubscriptionMessage"/>
        /// and removes the matching ones from <see cref="Subscriptions"/> list.
        /// </summary>
        /// <param name="actorRef">Reference to unsubscribing actor</param>
        /// <param name="unSubscriptionMessage">UnSubscription message</param>
        protected virtual void UnSubscribe(IActorRef actorRef, TUnSubscriptionMessage unSubscriptionMessage)
        {
            var subscriptions = Subscriptions.Where(s => s.ActorRef == actorRef && IsUnSubscribeMatch(s,unSubscriptionMessage)).ToArray();
            foreach (var subscription in subscriptions)
            {
                Subscriptions.Remove(subscription);
            }
        }

        /// <summary>
        /// Returns the list of subscriptions that match the incoming <paramref name="envelope"/>
        /// </summary>
        /// <param name="envelope">Incoming message</param>
        /// <returns>List of subscriptions that match the incoming <paramref name="envelope"/></returns>
        protected virtual TSubscription[] GetSubscriptionsForMessage(Envelope envelope)
        {
            return Subscriptions.ToArray();
        }

        /// <inheritdoc />
        /// <summary>
        /// Message handler
        /// The subscription/unsubscription messages are handled first,
        /// the other messages are matched to the existing subscriptions and distributed to matching subscribers
        /// </summary>
        /// <param name="envelope">Message envelope</param>
        /// <returns>True if the messages has been handled, otherwise false</returns>
        protected override bool Receive(Envelope envelope)
        {
            var msg = envelope.Message;
            //subscriptions or unsubscriptions
            switch (msg)
            {
                case TSubscriptionMessage subscriptionMessage:
                    Subscribe(envelope.Sender, subscriptionMessage);
                    return true;

                case TUnSubscriptionMessage unSubscriptionMessage:
                    UnSubscribe(envelope.Sender, unSubscriptionMessage);
                    return true;
            }

            //regular messages
            var subscriptions = GetSubscriptionsForMessage(envelope);
            if (subscriptions == null) return base.Receive(envelope);

            foreach (var subscription in subscriptions)
            {
                DistributeMessage(envelope,subscription);
            }

            return subscriptions.Length > 0 || base.Receive(envelope);
        }

        /// <summary>
        /// Distributes the message according to single <paramref name="subscription"/>
        /// </summary>
        /// <param name="envelope">Message envelope</param>
        /// <param name="subscription">Subscriptions matching the message</param>
        protected virtual void DistributeMessage(Envelope envelope, TSubscription subscription)
        {
            envelope.ForwardTo(subscription.ActorRef);
        }
    }
}
