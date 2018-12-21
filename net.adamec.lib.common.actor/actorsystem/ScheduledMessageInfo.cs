using System;
using net.adamec.lib.common.actor.actor;

namespace net.adamec.lib.common.actor.actorsystem
{
    /// <summary>
    /// Scheduled message definition
    /// </summary>
    internal class ScheduledMessageInfo
    {
        /// <summary>
        /// Unique ID of scheduled message
        /// </summary>
        internal string Id { get; }
        /// <summary>
        /// Optional information about the sender, usually used by <see cref="Recipient"/> to respond to the <see cref="Message"/>
        /// </summary>
        internal IActorRef Sender { get; }
        /// <summary>
        /// Recipient of the message
        /// </summary>
        internal IActorRef Recipient { get; }
        /// <summary>
        /// Period after which the message is periodically enqueued to the <see cref="Recipient"/> queue. Null for non-periodic messages
        /// </summary>
        internal TimeSpan? Period { get; }
        /// <summary>
        /// Message to be (periodically) sent to the <see cref="Recipient"/>
        /// </summary>
        internal object Message { get; }
        /// <summary>
        /// Date and Time after which the message is enqueued to the <see cref="Recipient"/> queue
        /// </summary>
        internal DateTime NextFire { get; }

        /// <summary>
        ///  CTOR for periodic scheduled message info
        /// </summary>
        /// <param name="sender">Optional information about the sender, usually used by <paramref name="recipient"/> to respond to the <paramref name="message"/></param>
        /// <param name="recipient">Recipient of the message</param>
        /// <param name="period">Period after which the message is enqueued to the <paramref name="recipient"/> queue</param>
        /// <param name="message">Message to be periodically sent to the <paramref name="recipient"/></param>
        /// <returns>Scheduled message definition instance with unique ID of scheduled message</returns>
        internal ScheduledMessageInfo(IActorRef sender, IActorRef recipient, TimeSpan period, object message)
        {
            Id = Guid.NewGuid().ToString();
            Sender = sender ?? ActorRefs.Empty;
            Recipient = recipient ?? throw new ArgumentNullException(nameof(recipient));
            Period = period;
            Message = message ?? throw new ArgumentNullException(nameof(message));
            NextFire = DateTime.Now + period;
        }

        /// <summary>
        ///  CTOR for one-time scheduled message info
        /// </summary>
        /// <param name="sender">Optional information about the sender, usually used by <paramref name="recipient"/> to respond to the <paramref name="message"/></param>
        /// <param name="recipient">Recipient of the message</param>
        /// <param name="nextFire">Date and time after which the message is enqueued to the <paramref name="recipient"/> queue</param>
        /// <param name="message">Message to be sent to the <paramref name="recipient"/></param>
        /// <returns>Scheduled message definition instance with unique ID of scheduled message</returns>
        internal ScheduledMessageInfo(IActorRef sender, IActorRef recipient, DateTime nextFire, object message)
        {
            Id = Guid.NewGuid().ToString();
            Sender = sender ?? ActorRefs.Empty;
            Recipient = recipient ?? throw new ArgumentNullException(nameof(recipient));
            Period = null;
            Message = message ?? throw new ArgumentNullException(nameof(message));
            NextFire = nextFire;
        }

        /// <summary>
        /// CTOR for the new instance of scheduled message definition for existing periodic scheduled message
        /// Used when creating the definition of each new run of the periodic schedule. Copies the information from current definition and preservers the ID
        /// </summary>
        /// <param name="existingPeriodicScheduledMessageInfo"></param>
        /// <returns>Scheduled message definition instance while preserving the ID of scheduled message</returns>
        internal ScheduledMessageInfo(ScheduledMessageInfo existingPeriodicScheduledMessageInfo)
        {
            if (existingPeriodicScheduledMessageInfo == null) throw new ArgumentNullException(nameof(existingPeriodicScheduledMessageInfo));
            Id = existingPeriodicScheduledMessageInfo.Id;
            Sender = existingPeriodicScheduledMessageInfo.Sender;
            Recipient = existingPeriodicScheduledMessageInfo.Recipient;
            Period = existingPeriodicScheduledMessageInfo.Period ?? throw new ArgumentOutOfRangeException(nameof(Period));
            Message = existingPeriodicScheduledMessageInfo.Message;
            NextFire = DateTime.Now + Period.Value;
        }

    }
}
