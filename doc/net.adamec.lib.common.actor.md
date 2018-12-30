#  RAD Actor System Documentation #
##  <a id="namespace-list" />  Namespaces ##

 | Name | Summary | 
 | ------ | --------- | 
 | [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba) |  | 
 | [net.adamec.lib.common.actor.actor.exchanges.@base](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h) |  | 
 | [net.adamec.lib.common.actor.actor.exchanges.single](net.adamec.lib.common.actor.actor.exchanges.single__6r83x4.md#n-net.adamec.lib.common.actor.actor.exchanges.single__6r83x4) |  | 
 | [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao) |  | 
 | [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md) |  | 
 | [net.adamec.lib.common.actor.message](net.adamec.lib.common.actor.message__m00bpk.md#n-net.adamec.lib.common.actor.message__m00bpk) |  | 
 | [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc) |  | 
 | [net.adamec.lib.common.extensions](net.adamec.lib.common.extensions__1vwuhoq.md#n-net.adamec.lib.common.extensions__1vwuhoq) |  | 
 | [net.adamec.lib.common.logging](net.adamec.lib.common.logging__1g9pm29.md#n-net.adamec.lib.common.logging__1g9pm29) |  | 
 | [net.adamec.lib.common.utils](net.adamec.lib.common.utils__7vdji9.md#n-net.adamec.lib.common.utils__7vdji9) |  | 

##  <a id="type-list" />  Types ##

 | Name | Modifier | Kind | Summary | 
 | ------ | ---------- | ------ | --------- | 
 | [Actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actor__buuxwr) | public abstract | Class | Reference implementation of [IActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi) that can be simply inherited in own actors. It provides the automatic registration in constructor and de-registration while disposing. The actor reference is published via [Self](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actor.self__1kgayjx) property. | 
 | [ActorRefEmpty](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefempty__c8py9n) | public | Class | Reference to empty virtual actor | 
 | [ActorRefInternal](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal) | internal | Class | Internal implementation of actor reference. Encapsulates the mailbox (queue) for the actor | 
 | [ActorRefNameOnly](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefnameonly__eu2rbh) | public abstract | Class | Base class for the virtual actors | 
 | [ActorRefs](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefs__17fr5vh) | public | Class | Common references to virtual actors | 
 | [ActorRefSystem](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefsystem__43zotr) | public | Class | Reference to system virtual actor | 
 | [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3) | public | Class | Implementation of actor system | 
 | [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe) | internal | Class | Message dispatched used by [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.actorsystem__1osgm3w) | 
 | [ActorSystemOptions](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j) | public | Class | User defined configuration of [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3) | 
 | [BaseDisposable](net.adamec.lib.common.utils__7vdji9.md#t-net.adamec.lib.common.utils.basedisposable__7s72ps) | public abstract | Class | Helper class for implementation of <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> types | 
 | [CommonLogging](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.commonlogging__1dar5wb) | internal static | Class | [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm) factory | 
 | [Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) | public | Class | Message envelope | 
 | [ErrorMessage](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.errormessage__1gj1wb) | public | Class | Specialized [Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) for messages in [ErrorMessageQueue](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.iactorsystem.errormessagequeue__v9i6fy) | 
 | [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq) | public abstract | Class | Exchange actor base class providing the common logic for implementation of exchanges - the actors routing the messages to another actors based on subscriptions. | 
 | [InternalQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8) | internal | Class | An unbounded mailbox managed message queue used by [ManagedMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09) as the main message queue Allows access to stored messages for monitoring using [Copy()](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.internalqueue.copy__1co1b8y) . Note: the messages in the array must not be modified!!! | 
 | [LoggerExt](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.loggerext__ac9km2) | internal | Class | [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm) extensions | 
 | [ManagedMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09) | public | Class | Message queue for <em>net.adamec.home.control.common.actor.manager.mailbox.ManagedUnboundedDequeBasedMailbox</em> allowing the monitoring (access to) messages stores in the queue The main queue is implemented using <em>net.adamec.home.control.common.actor.manager.mailbox.ManagedMessageQueue</em> and also uses a <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1" target="_blank" >System.Collections.Generic.Stack`1</a> internally to store each individual <em>net.adamec.home.control.common.actor.manager.mailbox.ManagedMessageQueue.EnqueueFirst(Akka.Actor.Envelope)</em> messages - supports stashing | 
 | [RoutingKeyExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor__1inw5x7) | public | Class | Exchange Actor with zero or more actors per message type with routing based also on routing key Subscriptions are per actor, type and routing key. Subscription filter gets the all subscriptions where message is instance of  filter type or its children and the routing keys match | 
 | [RoutingKeySubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0) | public | Class | Subscription for exchanges that routes the messages based on their type and routing key | 
 | [RoutingKeySubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage__1h3lr73) | public | Class | Subscription message for [RoutingKeySubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0) | 
 | [RoutingKeyUnSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage__emjdu2) | public | Class | UnSubscription message for [RoutingKeySubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0) | 
 | [ScheduledMessageInfo](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5) | internal | Class | Scheduled message definition | 
 | [SingleExchangeActor](net.adamec.lib.common.actor.actor.exchanges.single__6r83x4.md#t-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor__1q6rr7y) | public | Class | Exchange Actor with zero or one subscriber | 
 | [Subscription](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm) | public | Class | Base exchange actor subscription | 
 | [SubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage__1d4egm1) | public | Class | Base exchange actor subscription messages | 
 | [SyncActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6) | internal | Class | Internal actor used in [Ask(IActorRef, object, Type, int, bool)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.ask_net.adamec.lib.common.actor.actor.iactorref-system.object-system.type-system.int32-system.boolean___14ecl67) methods to implement Request-Reply pattern | 
 | [TypedMultiExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor__1rgmwat) | public | Class | Exchange Actor with zero or more actors per message type Subscriptions are per actor and type. Subscription filter gets the all subscriptions where message is instance of  filter type or its children | 
 | [TypedSingleExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor__i752da) | public | Class | Exchange Actor with zero or one actor per message type Subscriptions are per type. Subscription filter gets the exact type match and if not found, then first match where message is instance of  filter type or its children | 
 | [TypedSubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) | public | Class | Subscription for exchanges that routes the messages based on their type | 
 | [TypedSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage__1hh0wlc) | public | Class | Subscription message for [TypedSubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) | 
 | [TypedUnSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage__9g51i3) | public | Class | UnSubscription message for [TypedSubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) | 
 | [TypeExtensions](net.adamec.lib.common.extensions__1vwuhoq.md#t-net.adamec.lib.common.extensions.typeextensions__63ezc8) | internal static | Class | <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> extensions | 
 | [UnSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.unsubscriptionmessage__15gfzkw) | public | Class | Base exchange actor un-subscription message | 
 | [IActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi) | public abstract | Interface | Actor interface | 
 | [IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) | public abstract | Interface | Reference to actor | 
 | [IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs) | public abstract | Interface | The Actor System published interface Provides access to options and system queues, supports the actor (de)registration, dispatcher management (start/stop) as well as message scheduling and synchronous (Request-Reply) messaging. | 
 | [ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm) | internal abstract | Interface | Logger interface - wrapper around the <em>NLog.ILogger</em> with some additional methods | 
 | [IMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl) | public abstract | Interface |  | 
 | [Receive](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.receive__1adwyjn) | public | Delegate | Delegate describing the recipient target (method processing the messages) | 

Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="package-list" />  Source-only packages ##

 | Name | Summary | 
 | ------ | --------- | 
 | [RadCommons.extensions.TypeExtensions.DefaultValue](src-only-packages--.md#src-only-package--RadCommons.extensions.TypeExtensions.DefaultValue) | Provides default value for types (Source only package). | 
 | [RadCommons.logging.CommonLogging](src-only-packages--.md#src-only-package--RadCommons.logging.CommonLogging) | RadCommons logging wrapper around NLog with some extended functionality (Source only package). | 
 | [RadCommons.utils.BaseDisposable](src-only-packages--.md#src-only-package--RadCommons.utils.BaseDisposable) | Helper class for implementation of IDisposable types (Source only package). | 

Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 



