using net.adamec.lib.common.actor.actorsystem;
using net.adamec.lib.common.actor.message;
using net.adamec.lib.common.utils;

namespace net.adamec.lib.common.actor.actor
{
    /// <inheritdoc cref="IActor"/>
    /// <summary>
    /// Reference implementation of <see cref="IActor"/>that can be simply inherited in own actors.
    /// It provides the automatic registration in constructor and de-registration while disposing.
    /// The actor reference is published via <see cref="Self"/> property.
    /// </summary>
    public abstract class Actor : BaseDisposable, IActor
    {
        /// <summary>
        /// Actor system
        /// </summary>
        protected IActorSystem ActorSystem { get; }
        /// <summary>
        /// Actor reference to self
        /// </summary>
        public IActorRef Self { get; }
        /// <inheritdoc />
        /// <summary>
        /// Current method processing the messages (to where the messages are dispatched to)
        /// </summary>
        public Receive ReceiveTarget { get; protected set; }
        /// <inheritdoc />
        /// <summary>
        /// Returns true if the actor can receive messages. If false, the messages will not be dispatched to the actor (they will still be enqueued to actor's mailbox)
        /// </summary>
        public bool CanReceive { get; protected set; }

        /// <summary>
        /// CTOR
        /// Registers the actor into <paramref name="actorSystem"/> using given <paramref name="name"/>
        /// Enables the message processing of the actor and sets the <see cref="ReceiveTarget"/> to <see cref="Receive"/> method
        /// </summary>
        /// <param name="actorSystem">Actor system</param>
        /// <param name="name">Actor name</param>
        protected Actor(IActorSystem actorSystem, string name)
        {
            ActorSystem = actorSystem;
            ReceiveTarget = Receive;
            Self = actorSystem.RegisterActor(this, name);
            CanReceive = true;
        }

        /// <inheritdoc />
        /// <summary>
        /// De-registers the actor from actor system
        /// </summary>
        protected override void DisposeManaged()
        {
            base.DisposeManaged();
            ActorSystem.DeRegisterActor(Self);
        }

        /// <summary>
        /// Message handler that drops all messages and returns false (unhandled)
        /// </summary>
        protected Receive DropAllReceive { get; } = (e) => false;

        /// <summary>
        /// Switches the actor behavior by setting the message <paramref name="handler"/>.
        /// When the <paramref name="handler"/> is not set, <see cref="DropAllReceive"/> handler is used.
        /// </summary>
        /// <param name="handler">New message handler</param>
        protected virtual void Become(Receive handler)
        {
            ReceiveTarget = handler ?? DropAllReceive;
        }

        /// <summary>
        /// Switch the message handler to <see cref="Receive"/> method
        /// </summary>
        protected virtual void BecomeDefault()
        {
            ReceiveTarget = Receive;
        }

        /// <summary>
        /// Default message handler.
        /// </summary>
        /// <param name="envelope">Envelope with incoming message</param>
        /// <returns>True if handled, false if not handled. The default implementation calls <see cref="Unhandled"/> method that returns false</returns>
        protected virtual bool Receive(Envelope envelope)
        {
            return Unhandled(envelope);
        }

        /// <summary>
        /// Helper for processing unhandled messages, returns false by default
        /// </summary>
        /// <param name="envelope">Envelope with incoming message</param>
        /// <returns>Should return false for unhandled messages and true if message has been finally handled here</returns>
        protected virtual bool Unhandled(Envelope envelope)
        {
            return false;
        }
    }
}
