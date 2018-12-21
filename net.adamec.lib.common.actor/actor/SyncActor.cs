using System;
using System.Threading;
using net.adamec.lib.common.actor.actorsystem;
using net.adamec.lib.common.actor.message;
using net.adamec.lib.common.utils;

namespace net.adamec.lib.common.actor.actor
{
    /// <inheritdoc cref="IActor"/>
    /// <summary>
    /// Internal actor used in <see cref="IActorSystem.Ask"/> methods to implement Request-Reply pattern
    /// </summary>
    internal class SyncActor : BaseDisposable, IActor
    {
        private IActorSystem ActorSystem { get; }
        /// <summary>
        /// Wait handle used to signal that the response has arrived
        /// </summary>
        public AutoResetEvent WaitHandle { get; }
        /// <summary>
        /// Expected response type
        /// </summary>
        public Type ResponseType { get; }
        /// <summary>
        /// Response message envelope
        /// </summary>
        public Envelope Response { get; private set; }
        /// <summary>
        /// Actor reference to self
        /// </summary>
        public IActorRef Self { get; }
        /// <inheritdoc />
        /// <summary>
        /// Current method processing the messages (to where the messages are dispatched to)
        /// </summary>
        public Receive ReceiveTarget { get; }
        /// <inheritdoc />
        /// <summary>
        /// Returns true if the actor can receive messages. If false, the messages will not be dispatched to the actor (they will still be enqueued to actor's mailbox)
        /// </summary>
        public bool CanReceive { get; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="actorSystem">Actor system</param>
        /// <param name="responseType">Expected type of the response</param>
        /// <param name="waitHandle">Wait handle used to signal that the response has arrived </param>
        public SyncActor(IActorSystem actorSystem, Type responseType, AutoResetEvent waitHandle)
        {
            ActorSystem = actorSystem;
            ReceiveTarget = Receive;
            ReceiveTarget = Receive;
            Self = actorSystem.RegisterActor(this, $"SyncActor{Guid.NewGuid()}");
            CanReceive = true;
            ResponseType = responseType;
            WaitHandle = waitHandle;
        }

        /// <inheritdoc />
        /// <summary>
        /// Deregisters itself from actor system
        /// </summary>
        protected override void DisposeManaged()
        {
            base.DisposeManaged();
            ActorSystem.DeRegisterActor(Self);
        }

        /// <summary>
        /// Message handler - waits for the message of required <see cref="ResponseType"/> and when arrived, the message envelope is set to <see cref="Response"/>
        /// and the <see cref="WaitHandle"/> is set to signal the blocked "parent" thread that the response has been received.
        /// </summary>
        /// <param name="envelope">Incoming message envelope </param>
        /// <returns>True when message processed (handled) otherwise false</returns>
        protected virtual bool Receive(Envelope envelope)
        {
            if (!ResponseType.IsInstanceOfType(envelope.Message)) return false;

            Response = envelope;
            WaitHandle.Set();
            return true;
        }
    }
}
