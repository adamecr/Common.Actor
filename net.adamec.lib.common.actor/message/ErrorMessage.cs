using System;
using System.Diagnostics.CodeAnalysis;

namespace net.adamec.lib.common.actor.message
{
    /// <inheritdoc />
    /// <summary>
    /// Specialized <see cref="T:net.adamec.lib.common.actor.message.Envelope" /> for messages in <see cref="P:net.adamec.lib.common.actor.actorsystem.IActorSystem.ErrorMessageQueue" />
    /// </summary>
    public class ErrorMessage : Envelope
    {
        /// <summary>
        /// Error message
        /// </summary>
        public string Error { get; }
        /// <summary>
        /// Exception thrown
        /// </summary>
        public Exception Exception { get; }
        /// <summary>
        /// Timestamp when the error envelope has been created
        /// </summary>
        public DateTime ErrorOn { get; }

        /// <inheritdoc />
        /// <summary>
        /// CTOR - creates the error message envelope based on given message <paramref name="envelope" />
        /// </summary>
        /// <param name="envelope">Envelope of message causing the error</param>
        /// <param name="error">Error message</param>
        /// <param name="exception">Exception thrown</param>
        public ErrorMessage(Envelope envelope, string error, Exception exception) :
            base(envelope)
        {
            Error = error;
            Exception = exception;
            ErrorOn = DateTime.Now;
        }

        [ExcludeFromCodeCoverage]
        public override string ToString()
        {
            return base.ToString() + $", ERROR: {Error}";
        }
    }
}
