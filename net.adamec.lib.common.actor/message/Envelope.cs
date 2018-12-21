using System;
using System.Diagnostics.CodeAnalysis;
using net.adamec.lib.common.actor.actor;

namespace net.adamec.lib.common.actor.message
{
    /// <summary>
    /// Message envelope
    /// </summary>
    public class Envelope
    {
        /// <summary>
        /// Correlation ID used to identify the message (envelope)
        /// </summary>
        public string CorrelationId { get; }
        /// <summary>
        /// Message sender
        /// </summary>
        public IActorRef Sender { get; }
        /// <summary>
        /// Message recipient
        /// </summary>
        public IActorRef Recipient { get; }
        /// <summary>
        /// Optional routing key that can be used by actors (as "a parameter outside the message")
        /// </summary>
        public string RoutingKey { get; }
        /// <summary>
        /// Message
        /// </summary>
        public object Message { get; }
        /// <summary>
        /// Timestamp when the envelope has been created
        /// </summary>
        public DateTime CreatedOn { get; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="sender">Message sender</param>
        /// <param name="recipient">Message recipient</param>
        /// <param name="message">Message (payload)</param>
        /// <param name="routingKey">Optional routing key that can be used by actors (as "a parameter outside the message")</param>
        internal Envelope(IActorRef sender,IActorRef recipient, object message ,string routingKey=null)
        {
            Sender = sender;
            Recipient = recipient;
            Message = message;
            RoutingKey = routingKey;

            CorrelationId = Guid.NewGuid().ToString();
            CreatedOn=DateTime.Now;
        }

        /// <summary>
        /// CTOR - creates the exact copy of <paramref name="original"/> message including the <see cref="CorrelationId"/> and <see cref="CreatedOn"/> timestamp
        /// </summary>
        /// <param name="original"></param>
        protected Envelope(Envelope original)
        {
            Sender = original.Sender;
            Recipient = original.Recipient;
            Message = original.Message;
            RoutingKey = original.RoutingKey;

            CorrelationId = original.CorrelationId;
            CreatedOn = original.CreatedOn;
        }

        /// <summary>
        /// Forwards the message to another recipient. Keeps the original message, sender and routing key.
        /// </summary>
        /// <param name="recipient">Target recipient</param>
        public virtual void ForwardTo(IActorRef recipient)
        {
            if (recipient == null) throw new ArgumentNullException(nameof(recipient));

            recipient.Tell(Message, Sender, RoutingKey);
        }

        /// <summary>
        /// Forwards the message to another recipient. Keeps the original message and sender, but cleans/set the <see cref="RoutingKey"/> based on <paramref name="routingKey"/> parameter.
        /// </summary>
        /// <param name="recipient">Target recipient</param>
        /// <param name="routingKey">New <see cref="RoutingKey"/>, if not provided, the routing key will be cleaned up (set to null)!</param>
        public virtual void ForwardTo(IActorRef recipient,string routingKey)
        {
            if(recipient==null) throw new ArgumentNullException(nameof(recipient));

            recipient.Tell(Message,Sender,routingKey);
        }

        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return $"#{CorrelationId} {Sender.Name}->{Recipient.Name} @{CreatedOn}, type {Message.GetType().Name}";
        }
    }
}
