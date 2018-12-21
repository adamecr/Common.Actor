namespace net.adamec.lib.common.actor.actorsystem
{
    /// <summary>
    /// User defined configuration of <see cref="ActorSystem"/>
    /// </summary>
    public class ActorSystemOptions
    {
        /// <summary>
        /// Returns the default <see cref="ActorSystemOptions"/>
        /// </summary>
        public static ActorSystemOptions Default { get; }
        /// <summary>
        /// If enabled, logs each enqueued message with DEBUG level (default false)
        /// </summary>
        public bool LogEnqueuedMessages { get; set; } = false;
        /// <summary>
        /// If enabled, logs each message before dispatched to actor with DEBUG level (default false)
        /// </summary>
        public bool LogDispatchMessages { get; set; } = false;
        /// <summary>
        /// If enabled, logs each not handled message with WARN level (default false)
        /// </summary>
        public bool LogNotHandledMessages { get; set; } = false;

        /// <summary>
        /// Defines the maximum number of messages send for processing to single actor during one cycle of ActorDispatcher executor  (default 10)
        /// </summary>
        public int MaxDispatchMessagesInBatch { get; set; } = 10;

        /// <summary>
        /// Static CTOR - initialize default options instance
        /// </summary>
        static ActorSystemOptions()
        {
            Default = new ActorSystemOptions();
        }
    }
}
