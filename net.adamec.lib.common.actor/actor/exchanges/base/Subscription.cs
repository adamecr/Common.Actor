using System;

namespace net.adamec.lib.common.actor.actor.exchanges.@base
{
    /// <summary>
    /// Base exchange actor subscription
    /// </summary>
    public class Subscription
    {
        /// <summary>
        /// Reference to subscribed actor
        /// </summary>
        public IActorRef ActorRef { get; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="actorRef">Reference to subscribed actor</param>
        public Subscription(IActorRef actorRef)
        {
            ActorRef = actorRef ?? throw new ArgumentNullException(nameof(actorRef));
        }
    }
}
