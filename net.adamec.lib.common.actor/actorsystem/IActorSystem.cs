using System;
using net.adamec.lib.common.actor.actor;
using net.adamec.lib.common.actor.queue;

namespace net.adamec.lib.common.actor.actorsystem
{
    /// <summary>
    /// The Actor System published interface
    /// Provides access to options and system queues, supports the actor (de)registration, dispatcher management (start/stop) as well as
    /// message scheduling and synchronous (Request-Reply) messaging.
    /// </summary>
    public interface IActorSystem
    {
        /// <summary>
        /// Returns the reference to current <see cref="ActorSystemOptions"/>
        /// </summary>
        ActorSystemOptions Options { get; }

        /// <summary>
        /// Provides the access to dead letters queue
        /// </summary>
        IMessageQueue DeadLetters { get; }
        /// <summary>
        /// Provides the access to error messages queue
        /// </summary>
        IMessageQueue ErrorMessageQueue { get; }

        /// <summary>
        /// Registers the <paramref name="actor"/> to actor system.
        /// Name of the actor should be unique, but this is not checked. Each actor must register first to be able to receive the messages within the actor system.
        /// </summary>
        /// <param name="actor">Actor to be registered</param>
        /// <param name="name">Name of the actor. Name of the actor should be unique, but this is not checked. Name is mandatory and can't be empty</param>
        /// <returns>Actor reference to the registered actor</returns>
        IActorRef RegisterActor(IActor actor, string name);
        /// <summary>
        /// De-register actor identified by <paramref name="actorRef"/> from the actor system
        /// If <paramref name="actorRef"/> is not found within the actor system, WARN message is logged, but raises no error/exception
        /// </summary>
        /// <param name="actorRef">Reference to actor to be de-registered</param>
        void DeRegisterActor(IActorRef actorRef);

        /// <summary>
        /// Starts the message dispatcher (started by default within ActorSystem constructor)
        /// </summary>
        void Start();
        /// <summary>
        /// Stops the message dispatcher (can be restarted using <see cref="Start"/> method)
        /// </summary>
        void Stop();

        /// <summary>
        /// Schedule periodic <paramref name="message"/> to be sent to <paramref name="recipient"/> each <paramref name="period"/>.
        /// </summary>
        /// <param name="sender">Optional information about the sender, usually used by <paramref name="recipient"/> to respond to the <paramref name="message"/></param>
        /// <param name="recipient">Recipient of the message</param>
        /// <param name="period">Period after which the message is periodically enqueued to the <paramref name="recipient"/> queue</param>
        /// <param name="message">Message to be periodically sent to the <paramref name="recipient"/></param>
        /// <returns>Unique ID of scheduled message</returns>
        string ScheduleMessage(IActorRef sender, IActorRef recipient, TimeSpan period, object message);
        /// <summary>
        /// Schedule one-time <paramref name="message"/> to be sent to <paramref name="recipient"/> at given <paramref name="nextFire">date and time</paramref>
        /// </summary>
        /// <param name="sender">Optional information about the sender, usually used by <paramref name="recipient"/> to respond to the <paramref name="message"/></param>
        /// <param name="recipient">Recipient of the message</param>
        /// <param name="nextFire">Date and time after which the message is enqueued to the <paramref name="recipient"/> queue</param>
        /// <param name="message">Message to be sent to the <paramref name="recipient"/></param>
        /// <returns>Unique ID of scheduled message</returns>
        string ScheduleMessage(IActorRef sender, IActorRef recipient, DateTime nextFire, object message);
        /// <summary>
        /// Cancels the scheduled message with given <paramref name="id"/> - removes the message from list of the scheduled messages
        ///  </summary>
        /// <param name="id">Unique ID of the scheduled message. When the id is not found, it's just ignored.</param>
        /// <returns>True if the message has been found and canceled, false when the message has not been found</returns>
        bool CancelScheduledMessage(string id);
        /// <summary>
        /// Cancels all messages scheduled for <paramref name="recipient"/> that are of given <paramref name="messageType"/> - removes the messages from list of the scheduled messages
        ///  </summary>
        /// <param name="recipient">The recipient of the scheduled messages to be canceled.</param>
        /// <param name="messageType">The type of the scheduled messages to be canceled. </param>
        /// <returns>True if at least one message has been found and canceled, false when none has been found</returns>
        bool CancelScheduledMessages(IActorRef recipient, Type messageType);

        /// <summary>
        /// Sends a request <paramref name="message"/> to <paramref name="recipient"/> and waits for the response of type <typeparam name="T"></typeparam>.
        /// </summary>
        /// <typeparam name="T"><see cref="Type"/> of the message to wait for</typeparam>
        /// <param name="recipient">Reference to recipient actor</param>
        /// <param name="message">Request message</param>
        /// <param name="timeoutMilliseconds">Timeout for the response</param>
        /// <param name="throwTimeoutException">If true, the <see cref="TimeoutException"/> is raised, otherwise the default(T) response is returned</param>
        /// <returns>The "synchronous" response</returns>
        T Ask<T>(IActorRef recipient, object message, int timeoutMilliseconds, bool throwTimeoutException = false);

        /// <summary>
        /// Sends a request <paramref name="message"/> to <paramref name="recipient"/> and waits for the response of required <paramref name="responseType"/>.
        /// </summary>
        /// <param name="recipient">Reference to recipient actor</param>
        /// <param name="message">Request message</param>
        /// <param name="responseType"><see cref="Type"/> of the message to wait for</param>
        /// <param name="timeoutMilliseconds">Timeout for the response</param>
        /// <param name="throwTimeoutException">If true, the <see cref="TimeoutException"/> is raised, otherwise the default(T) response is returned</param>
        /// <returns>The "synchronous" response</returns>
        object Ask(IActorRef recipient, object message, Type responseType, int timeoutMilliseconds, bool throwTimeoutException = false);
    }
}
