namespace net.adamec.lib.common.actor.actor
{
    /// <summary>
    /// Reference to actor
    /// </summary>
    public interface IActorRef
    {
        /// <summary>
        /// Name of the actor
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Asynchronously delivers a message to this <see cref="IActorRef"/> in a non-blocking fashion.
        /// Uses "at most once" delivery semantics.
        /// </summary>
        /// <param name="message">The message to be sent to the target.</param>
        /// <param name="sender">The sender of this message. Defaults to <see cref="ActorRefs.Empty"/> if left to <c>null</c>.</param>
        /// <param name="routingKey">Optional routing key - additional information that can be used for routing/processing the message</param>
        void Tell(object message, IActorRef sender, string routingKey = null);
    }

    /// <summary>
    /// Common references to virtual actors
    /// </summary>
    public class ActorRefs
    {
        /// <summary>
        /// Empty actor (means no real actor defined)
        /// </summary>
        public static IActorRef Empty { get; }
        /// <summary>
        /// System actor (to be used internally if needed)
        /// </summary>
        public static IActorRef System { get; }

        /// <summary>
        /// Static CTOR - Creates the static references
        /// </summary>
        static ActorRefs()
        {
            Empty = new ActorRefEmpty();
            System = new ActorRefSystem();
        }
    }

    /// <inheritdoc />
    /// <summary>
    /// Base class for the virtual actors
    /// </summary>
    public abstract class ActorRefNameOnly : IActorRef
    {
        /// <inheritdoc />
        /// <summary>
        /// Name of the actor
        /// </summary>
        public abstract string Name { get; }

        /// <inheritdoc />
        /// <summary>
        /// Empty implementation of the <see cref="M:net.adamec.lib.common.actor.actor.IActorRef.Tell(System.Object,net.adamec.lib.common.actor.actor.IActorRef,System.String)" /> for the virtual actors
        /// </summary>
        /// <param name="message">Ignored</param>
        /// <param name="sender">Ignored</param>
        /// <param name="routingKey">Ignored</param>
        public void Tell(object message, IActorRef sender, string routingKey = null)
        {
            //do nothing
        }
    }

    /// <inheritdoc />
    /// <summary>
    /// Reference to empty virtual actor
    /// </summary>
    public class ActorRefEmpty : ActorRefNameOnly
    {
        /// <inheritdoc />
        /// <summary>
        /// Name of the actor - [EMPTY]
        /// </summary>
        public override string Name => "[EMPTY]";
    }

    /// <inheritdoc />
    /// <summary>
    /// Reference to system virtual actor
    /// </summary>
    public class ActorRefSystem : ActorRefNameOnly
    {
        /// <inheritdoc />
        /// <summary>
        /// Name of the actor - [SYSTEM]
        /// </summary>
        public override string Name => "[SYSTEM]";
    }
}
