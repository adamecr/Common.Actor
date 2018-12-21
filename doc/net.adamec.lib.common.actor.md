#  Documentation #
##  <a id="namespace-list" />  Namespaces ##

 | Name | Summary | 
 | ------ | --------- | 
 | [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba) |  | 
 | [net.adamec.lib.common.actor.actor.exchanges.@base](#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h) |  | 
 | [net.adamec.lib.common.actor.actor.exchanges.single](#n-net.adamec.lib.common.actor.actor.exchanges.single__6r83x4) |  | 
 | [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao) |  | 
 | [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md) |  | 
 | [net.adamec.lib.common.actor.message](#n-net.adamec.lib.common.actor.message__m00bpk) |  | 
 | [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc) |  | 
 | [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq) |  | 
 | [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29) |  | 
 | [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9) |  | 

##  <a id="type-list" />  Types ##

 | Name | Modifier | Kind | Summary | 
 | ------ | ---------- | ------ | --------- | 
 | [Actor](#t-net.adamec.lib.common.actor.actor.actor__buuxwr) | public abstract | Class | Reference implementation of [IActor](#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi) that can be simply inherited in own actors. It provides the automatic registration in constructor and de-registration while disposing. The actor reference is published via [Self](#p-net.adamec.lib.common.actor.actor.actor.self__1kgayjx) property. | 
 | [ActorRefEmpty](#t-net.adamec.lib.common.actor.actor.actorrefempty__c8py9n) | public | Class | Reference to empty virtual actor | 
 | [ActorRefInternal](#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal) | internal | Class | Internal implementation of actor reference. Encapsulates the mailbox (queue) for the actor | 
 | [ActorRefNameOnly](#t-net.adamec.lib.common.actor.actor.actorrefnameonly__eu2rbh) | public abstract | Class | Base class for the virtual actors | 
 | [ActorRefs](#t-net.adamec.lib.common.actor.actor.actorrefs__17fr5vh) | public | Class | Common references to virtual actors | 
 | [ActorRefSystem](#t-net.adamec.lib.common.actor.actor.actorrefsystem__43zotr) | public | Class | Reference to system virtual actor | 
 | [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3) | public | Class | Implementation of actor system | 
 | [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe) | internal | Class | Message dispatched used by [ActorSystem](#p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.actorsystem__1osgm3w) | 
 | [ActorSystemOptions](#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j) | public | Class | User defined configuration of [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3) | 
 | [BaseDisposable](#t-net.adamec.lib.common.utils.basedisposable__7s72ps) | public abstract | Class | Helper class for implementation of <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> types | 
 | [CommonLogging](#t-net.adamec.lib.common.logging.commonlogging__1dar5wb) | public static | Class | [ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) factory | 
 | [Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) | public | Class | Message envelope | 
 | [ErrorMessage](#t-net.adamec.lib.common.actor.message.errormessage__1gj1wb) | public | Class | Specialized [Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) for messages in [ErrorMessageQueue](#p-net.adamec.lib.common.actor.actorsystem.iactorsystem.errormessagequeue__v9i6fy) | 
 | [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq) | public abstract | Class | Exchange actor base class providing the common logic for implementation of exchanges - the actors routing the messages to another actors based on subscriptions. | 
 | [InternalQueue](#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8) | internal | Class | An unbounded mailbox managed message queue used by [ManagedMessageQueue](#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09) as the main message queue Allows access to stored messages for monitoring using [Copy()](#m-net.adamec.lib.common.actor.queue.internalqueue.copy__1co1b8y) . Note: the messages in the array must not be modified!!! | 
 | [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv) | internal static | Class | [ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) extensions | 
 | [ManagedMessageQueue](#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09) | public | Class | Message queue for <em>net.adamec.home.control.common.actor.manager.mailbox.ManagedUnboundedDequeBasedMailbox</em> allowing the monitoring (access to) messages stores in the queue The main queue is implemented using <em>net.adamec.home.control.common.actor.manager.mailbox.ManagedMessageQueue</em> and also uses a <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1" target="_blank" >System.Collections.Generic.Stack`1</a> internally to store each individual <em>net.adamec.home.control.common.actor.manager.mailbox.ManagedMessageQueue.EnqueueFirst(Akka.Actor.Envelope)</em> messages - supports stashing | 
 | [RoutingKeyExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor__1inw5x7) | public | Class | Exchange Actor with zero or more actors per message type with routing based also on routing key Subscriptions are per actor, type and routing key. Subscription filter gets the all subscriptions where message is instance of  filter type or its children and the routing keys match | 
 | [RoutingKeySubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0) | public | Class | Subscription for exchanges that routes the messages based on their type and routing key | 
 | [RoutingKeySubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage__1h3lr73) | public | Class | Subscription message for [RoutingKeySubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0) | 
 | [RoutingKeyUnSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage__emjdu2) | public | Class | UnSubscription message for [RoutingKeySubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0) | 
 | [ScheduledMessageInfo](#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5) | internal | Class | Scheduled message definition | 
 | [SingleExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor__1q6rr7y) | public | Class | Exchange Actor with zero or one subscriber | 
 | [Subscription](#t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm) | public | Class | Base exchange actor subscription | 
 | [SubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage__1d4egm1) | public | Class | Base exchange actor subscription messages | 
 | [SyncActor](#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6) | internal | Class | Internal actor used in [Ask(IActorRef, object, Type, int, bool)](#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.ask_net.adamec.lib.common.actor.actor.iactorref-system.object-system.type-system.int32-system.boolean___14ecl67) methods to implement Request-Reply pattern | 
 | [TypedMultiExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor__1rgmwat) | public | Class | Exchange Actor with zero or more actors per message type Subscriptions are per actor and type. Subscription filter gets the all subscriptions where message is instance of  filter type or its children | 
 | [TypedSingleExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor__i752da) | public | Class | Exchange Actor with zero or one actor per message type Subscriptions are per type. Subscription filter gets the exact type match and if not found, then first match where message is instance of  filter type or its children | 
 | [TypedSubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) | public | Class | Subscription for exchanges that routes the messages based on their type | 
 | [TypedSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage__1hh0wlc) | public | Class | Subscription message for [TypedSubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) | 
 | [TypedUnSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage__9g51i3) | public | Class | UnSubscription message for [TypedSubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) | 
 | [TypeExtensions](#t-net.adamec.lib.common.extensions.typeextensions__63ezc8) | internal static | Class | <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> extensions | 
 | [UnSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.base.unsubscriptionmessage__15gfzkw) | public | Class | Base exchange actor un-subscription message | 
 | [IActor](#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi) | public abstract | Interface | Actor interface | 
 | [IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) | public abstract | Interface | Reference to actor | 
 | [IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs) | public abstract | Interface | The Actor System published interface Provides access to options and system queues, supports the actor (de)registration, dispatcher management (start/stop) as well as message scheduling and synchronous (Request-Reply) messaging. | 
 | [ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) | public abstract | Interface | Logger interface - wrapper around the <em>NLog.ILogger</em> | 
 | [IMessageQueue](#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl) | public abstract | Interface |  | 
 | [Receive](#t-net.adamec.lib.common.actor.actor.receive__1adwyjn) | public | Delegate | Delegate describing the recipient target (method processing the messages) | 

Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="package-list" />  Source-only packages ##

 | Name | Summary | 
 | ------ | --------- | 
 | [RadCommons.extensions.TypeExtensions.DefaultValue](#src-only-package--RadCommons.extensions.TypeExtensions.DefaultValue) | Provides default value for types (Source only package). | 
 | [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging) | RadCommons logging wrapper around NLog (Source only package). | 
 | [RadCommons.utils.BaseDisposable](#src-only-package--RadCommons.utils.BaseDisposable) | Helper class for implementation of IDisposable types (Source only package). | 

Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="n-net.adamec.lib.common.actor.actor__1ldg5ba" />  net.adamec.lib.common.actor.actor Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Actor](#t-net.adamec.lib.common.actor.actor.actor__buuxwr) | public abstract | Reference implementation of [IActor](#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi) that can be simply inherited in own actors. It provides the automatic registration in constructor and de-registration while disposing. The actor reference is published via [Self](#p-net.adamec.lib.common.actor.actor.actor.self__1kgayjx) property. | 
 | [ActorRefEmpty](#t-net.adamec.lib.common.actor.actor.actorrefempty__c8py9n) | public | Reference to empty virtual actor | 
 | [ActorRefInternal](#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal) | internal | Internal implementation of actor reference. Encapsulates the mailbox (queue) for the actor | 
 | [ActorRefNameOnly](#t-net.adamec.lib.common.actor.actor.actorrefnameonly__eu2rbh) | public abstract | Base class for the virtual actors | 
 | [ActorRefs](#t-net.adamec.lib.common.actor.actor.actorrefs__17fr5vh) | public | Common references to virtual actors | 
 | [ActorRefSystem](#t-net.adamec.lib.common.actor.actor.actorrefsystem__43zotr) | public | Reference to system virtual actor | 
 | [SyncActor](#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6) | internal | Internal actor used in [Ask(IActorRef, object, Type, int, bool)](#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.ask_net.adamec.lib.common.actor.actor.iactorref-system.object-system.type-system.int32-system.boolean___14ecl67) methods to implement Request-Reply pattern | 

 


###  Interfaces ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IActor](#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi) | public abstract | Actor interface | 
 | [IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) | public abstract | Reference to actor | 

 


###  Delegates ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Receive](#t-net.adamec.lib.common.actor.actor.receive__1adwyjn) | public | Delegate describing the recipient target (method processing the messages) | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.actor__buuxwr" />  Actor Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\Actor.cs</small>


Reference implementation of [IActor](#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi) that can be simply inherited in own actors. It provides the automatic registration in constructor and de-registration while disposing. The actor reference is published via [Self](#p-net.adamec.lib.common.actor.actor.actor.self__1kgayjx) property.



```csharp
public abstract class Actor : BaseDisposable, IActor
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.utils.BaseDisposable](#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>, [net.adamec.lib.common.actor.actor.IActor](#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorSystem](#p-net.adamec.lib.common.actor.actor.actor.actorsystem__1g6mmur) | protected | Actor system | 
 | [CanReceive](#p-net.adamec.lib.common.actor.actor.actor.canreceive__19sq0hk) | public | Returns true if the actor can receive messages. If false, the messages will not be dispatched to the actor (they will still be enqueued to actor&#39;s mailbox) | 
 | [DropAllReceive](#p-net.adamec.lib.common.actor.actor.actor.dropallreceive__1g3skf2) | protected | Message handler that drops all messages and returns false (unhandled) | 
 | [ReceiveTarget](#p-net.adamec.lib.common.actor.actor.actor.receivetarget__rq6a5r) | public | Current method processing the messages (to where the messages are dispatched to) | 
 | [Self](#p-net.adamec.lib.common.actor.actor.actor.self__1kgayjx) | public | Actor reference to self | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Actor(IActorSystem, string)](#m-net.adamec.lib.common.actor.actor.actor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___sft7zm) | protected | CTOR Registers the actor into <strong>actorSystem</strong> using given <strong>name</strong> Enables the message processing of the actor and sets the [ReceiveTarget](#p-net.adamec.lib.common.actor.actor.actor.receivetarget__rq6a5r) to [Receive(Envelope)](#m-net.adamec.lib.common.actor.actor.actor.receive_net.adamec.lib.common.actor.message.envelope___lic5c4) method | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Become(Receive)](#m-net.adamec.lib.common.actor.actor.actor.become_net.adamec.lib.common.actor.actor.receive___cfu8bb) | protected | Switches the actor behavior by setting the message <strong>handler</strong> . When the <strong>handler</strong> is not set, [DropAllReceive](#p-net.adamec.lib.common.actor.actor.actor.dropallreceive__1g3skf2) handler is used. | 
 | [BecomeDefault()](#m-net.adamec.lib.common.actor.actor.actor.becomedefault__gzylss) | protected | Switch the message handler to [Receive(Envelope)](#m-net.adamec.lib.common.actor.actor.actor.receive_net.adamec.lib.common.actor.message.envelope___lic5c4) method | 
 | [DisposeManaged()](#m-net.adamec.lib.common.actor.actor.actor.disposemanaged__m3e4v4) | protected | De-registers the actor from actor system | 
 | [Receive(Envelope)](#m-net.adamec.lib.common.actor.actor.actor.receive_net.adamec.lib.common.actor.message.envelope___lic5c4) | protected | Default message handler. | 
 | [Unhandled(Envelope)](#m-net.adamec.lib.common.actor.actor.actor.unhandled_net.adamec.lib.common.actor.message.envelope___1cb59zm) | protected | Helper for processing unhandled messages, returns false by default | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actor.actorsystem__1g6mmur" />  Actor.ActorSystem Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


Actor system



```csharp
protected IActorSystem ActorSystem { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actor.canreceive__19sq0hk" />  Actor.CanReceive Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


Returns true if the actor can receive messages. If false, the messages will not be dispatched to the actor (they will still be enqueued to actor&#39;s mailbox)



```csharp
public bool CanReceive { get; protected set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actor.dropallreceive__1g3skf2" />  Actor.DropAllReceive Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


Message handler that drops all messages and returns false (unhandled)



```csharp
protected Receive DropAllReceive { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.Receive](#t-net.adamec.lib.common.actor.actor.receive__1adwyjn)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actor.receivetarget__rq6a5r" />  Actor.ReceiveTarget Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


Current method processing the messages (to where the messages are dispatched to)



```csharp
public Receive ReceiveTarget { get; protected set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.Receive](#t-net.adamec.lib.common.actor.actor.receive__1adwyjn)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actor.self__1kgayjx" />  Actor.Self Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


Actor reference to self



```csharp
public IActorRef Self { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___sft7zm" />  Actor.Actor(IActorSystem, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


CTOR Registers the actor into <strong>actorSystem</strong> using given <strong>name</strong> Enables the message processing of the actor and sets the [ReceiveTarget](#p-net.adamec.lib.common.actor.actor.actor.receivetarget__rq6a5r) to [Receive(Envelope)](#m-net.adamec.lib.common.actor.actor.actor.receive_net.adamec.lib.common.actor.message.envelope___lic5c4) method



```csharp
protected Actor(IActorSystem actorSystem, string name)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs) <strong>actorSystem</strong></dt><dd>Actor system</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Actor name</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actor.become_net.adamec.lib.common.actor.actor.receive___cfu8bb" />  Actor.Become(Receive) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


Switches the actor behavior by setting the message <strong>handler</strong> . When the <strong>handler</strong> is not set, [DropAllReceive](#p-net.adamec.lib.common.actor.actor.actor.dropallreceive__1g3skf2) handler is used.



```csharp
protected virtual void Become(Receive handler)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.Receive](#t-net.adamec.lib.common.actor.actor.receive__1adwyjn) <strong>handler</strong></dt><dd>New message handler</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actor.becomedefault__gzylss" />  Actor.BecomeDefault() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


Switch the message handler to [Receive(Envelope)](#m-net.adamec.lib.common.actor.actor.actor.receive_net.adamec.lib.common.actor.message.envelope___lic5c4) method



```csharp
protected virtual void BecomeDefault()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actor.disposemanaged__m3e4v4" />  Actor.DisposeManaged() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


De-registers the actor from actor system



```csharp
protected override void DisposeManaged()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actor.receive_net.adamec.lib.common.actor.message.envelope___lic5c4" />  Actor.Receive(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


Default message handler.



```csharp
protected virtual bool Receive(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Envelope with incoming message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True if handled, false if not handled. The default implementation calls [Unhandled(Envelope)](#m-net.adamec.lib.common.actor.actor.actor.unhandled_net.adamec.lib.common.actor.message.envelope___1cb59zm) method that returns false</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actor.unhandled_net.adamec.lib.common.actor.message.envelope___1cb59zm" />  Actor.Unhandled(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


Helper for processing unhandled messages, returns false by default



```csharp
protected virtual bool Unhandled(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Envelope with incoming message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Should return false for unhandled messages and true if message has been finally handled here</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.actorrefempty__c8py9n" />  ActorRefEmpty Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\IActorRef.cs</small>


Reference to empty virtual actor



```csharp
public class ActorRefEmpty : ActorRefNameOnly
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.actor.actor.ActorRefNameOnly](#t-net.adamec.lib.common.actor.actor.actorrefnameonly__eu2rbh)           
Implements: [net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Name](#p-net.adamec.lib.common.actor.actor.actorrefempty.name__175l78m) | public | Name of the actor - [EMPTY] | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actorrefempty.name__175l78m" />  ActorRefEmpty.Name Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefEmpty](#t-net.adamec.lib.common.actor.actor.actorrefempty__c8py9n)           
Sources: actor\IActorRef.cs</small>


Name of the actor - [EMPTY]



```csharp
public override string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal" />  ActorRefInternal Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\ActorRefInternal.cs</small>


Internal implementation of actor reference. Encapsulates the mailbox (queue) for the actor



```csharp
internal class ActorRefInternal : IActorRef
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: [net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [actorSystem](#f-net.adamec.lib.common.actor.actor.actorrefinternal.actorsystem__vswqpr) | private | Actor systems | 
 | [isBeingProcessed](#f-net.adamec.lib.common.actor.actor.actorrefinternal.isbeingprocessed__15vnbvu) | private | Flag whether the actor (mailbox) is being processed | 
 | [isBeingProcessedLock](#f-net.adamec.lib.common.actor.actor.actorrefinternal.isbeingprocessedlock__1p7p9sp) | private | Log used for [isBeingProcessed](#f-net.adamec.lib.common.actor.actor.actorrefinternal.isbeingprocessed__15vnbvu) flag ensuring the thread safe operations | 
 | [MessageLogger](#f-net.adamec.lib.common.actor.actor.actorrefinternal.messagelogger__1vqsaru) | protected static |  | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Actor](#p-net.adamec.lib.common.actor.actor.actorrefinternal.actor__10pf4r2) | internal | Actor the reference belongs to | 
 | [IsBeingProcessed](#p-net.adamec.lib.common.actor.actor.actorrefinternal.isbeingprocessed__1cq6t5g) | internal | Flag whether the actor (mailbox) is being processed | 
 | [Name](#p-net.adamec.lib.common.actor.actor.actorrefinternal.name__1uhi1my) | public | Name of the actor | 
 | [Queue](#p-net.adamec.lib.common.actor.actor.actorrefinternal.queue__2gyn6w) | internal | Actor&#39;s mailbox (message queue) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorRefInternal(IActor, string, IActorSystem)](#m-net.adamec.lib.common.actor.actor.actorrefinternal.-ctor_net.adamec.lib.common.actor.actor.iactor-system.string-net.adamec.lib.common.actor.actorsystem.iactorsystem___8db4dq) | internal | CTOR Creates the mailbox (queue) for the actor | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [LockForProcessing()](#m-net.adamec.lib.common.actor.actor.actorrefinternal.lockforprocessing__i64cop) | internal | Locks the actor for message processing | 
 | [ProcessingFinished()](#m-net.adamec.lib.common.actor.actor.actorrefinternal.processingfinished__cj3e9v) | internal | Unlocks the actor for message processing | 
 | [Tell(object, IActorRef, string)](#m-net.adamec.lib.common.actor.actor.actorrefinternal.tell_system.object-net.adamec.lib.common.actor.actor.iactorref-system.string___ggyubr) | public | Asynchronously delivers a message actor&#39;s mailbox in a non-blocking fashion. | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.actor.actorrefinternal.actorsystem__vswqpr" />  ActorRefInternal.actorSystem Field ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


Actor systems



```csharp
private readonly IActorSystem actorSystem
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.actor.actorrefinternal.isbeingprocessed__15vnbvu" />  ActorRefInternal.isBeingProcessed Field ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


Flag whether the actor (mailbox) is being processed



```csharp
private bool isBeingProcessed
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.actor.actorrefinternal.isbeingprocessedlock__1p7p9sp" />  ActorRefInternal.isBeingProcessedLock Field ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


Log used for [isBeingProcessed](#f-net.adamec.lib.common.actor.actor.actorrefinternal.isbeingprocessed__15vnbvu) flag ensuring the thread safe operations



```csharp
private readonly object isBeingProcessedLock
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.actor.actorrefinternal.messagelogger__1vqsaru" />  ActorRefInternal.MessageLogger Field ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>



```csharp
protected static ILogger MessageLogger
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actorrefinternal.actor__10pf4r2" />  ActorRefInternal.Actor Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


Actor the reference belongs to



```csharp
internal IActor Actor { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActor](#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actorrefinternal.isbeingprocessed__1cq6t5g" />  ActorRefInternal.IsBeingProcessed Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


Flag whether the actor (mailbox) is being processed



```csharp
internal bool IsBeingProcessed { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actorrefinternal.name__1uhi1my" />  ActorRefInternal.Name Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


Name of the actor



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actorrefinternal.queue__2gyn6w" />  ActorRefInternal.Queue Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


Actor&#39;s mailbox (message queue)



```csharp
internal IMessageQueue Queue { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.queue.IMessageQueue](#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actorrefinternal.-ctor_net.adamec.lib.common.actor.actor.iactor-system.string-net.adamec.lib.common.actor.actorsystem.iactorsystem___8db4dq" />  ActorRefInternal.ActorRefInternal(IActor, string, IActorSystem) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


CTOR Creates the mailbox (queue) for the actor



```csharp
internal ActorRefInternal(IActor actor, string name, IActorSystem actorSystem)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActor](#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi) <strong>actor</strong></dt><dd>Actor</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the actor</dd><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs) <strong>actorSystem</strong></dt><dd>Actor system</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actorrefinternal.lockforprocessing__i64cop" />  ActorRefInternal.LockForProcessing() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


Locks the actor for message processing



```csharp
internal void LockForProcessing()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actorrefinternal.processingfinished__cj3e9v" />  ActorRefInternal.ProcessingFinished() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


Unlocks the actor for message processing



```csharp
internal void ProcessingFinished()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actorrefinternal.tell_system.object-net.adamec.lib.common.actor.actor.iactorref-system.string___ggyubr" />  ActorRefInternal.Tell(object, IActorRef, string) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


Asynchronously delivers a message actor&#39;s mailbox in a non-blocking fashion.



```csharp
public void Tell(object message, IActorRef sender, string routingKey = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>The message to be sent to the actor.</dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>The sender of this message. Defaults to [Empty](#p-net.adamec.lib.common.actor.actor.actorrefs.empty__6f5cpu) if left to `null` .</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>routingKey</strong></dt><dd>Optional routing key - additional information that can be used for routing/processing the message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.actorrefnameonly__eu2rbh" />  ActorRefNameOnly Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\IActorRef.cs</small>


Base class for the virtual actors



```csharp
public abstract class ActorRefNameOnly : IActorRef
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: [net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Name](#p-net.adamec.lib.common.actor.actor.actorrefnameonly.name__qk183e) | public abstract | Name of the actor | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Tell(object, IActorRef, string)](#m-net.adamec.lib.common.actor.actor.actorrefnameonly.tell_system.object-net.adamec.lib.common.actor.actor.iactorref-system.string___rh50yb) | public | Empty implementation of the [Tell(object, IActorRef, string)](#m-net.adamec.lib.common.actor.actor.iactorref.tell_system.object-net.adamec.lib.common.actor.actor.iactorref-system.string___1xlz161) for the virtual actors | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actorrefnameonly.name__qk183e" />  ActorRefNameOnly.Name Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefNameOnly](#t-net.adamec.lib.common.actor.actor.actorrefnameonly__eu2rbh)           
Sources: actor\IActorRef.cs</small>


Name of the actor



```csharp
public abstract string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actorrefnameonly.tell_system.object-net.adamec.lib.common.actor.actor.iactorref-system.string___rh50yb" />  ActorRefNameOnly.Tell(object, IActorRef, string) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefNameOnly](#t-net.adamec.lib.common.actor.actor.actorrefnameonly__eu2rbh)           
Sources: actor\IActorRef.cs</small>


Empty implementation of the [Tell(object, IActorRef, string)](#m-net.adamec.lib.common.actor.actor.iactorref.tell_system.object-net.adamec.lib.common.actor.actor.iactorref-system.string___1xlz161) for the virtual actors



```csharp
public void Tell(object message, IActorRef sender, string routingKey = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Ignored</dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>Ignored</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>routingKey</strong></dt><dd>Ignored</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.actorrefs__17fr5vh" />  ActorRefs Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\IActorRef.cs</small>


Common references to virtual actors



```csharp
public class ActorRefs
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Empty](#p-net.adamec.lib.common.actor.actor.actorrefs.empty__6f5cpu) | public static | Empty actor (means no real actor defined) | 
 | [System](#p-net.adamec.lib.common.actor.actor.actorrefs.system__1y8lt0o) | public static | System actor (to be used internally if needed) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorRefs()](#m-net.adamec.lib.common.actor.actor.actorrefs.-cctor__1qfbqdk) | private static | Static CTOR - Creates the static references | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actorrefs.empty__6f5cpu" />  ActorRefs.Empty Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefs](#t-net.adamec.lib.common.actor.actor.actorrefs__17fr5vh)           
Sources: actor\IActorRef.cs</small>


Empty actor (means no real actor defined)



```csharp
public static IActorRef Empty { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actorrefs.system__1y8lt0o" />  ActorRefs.System Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefs](#t-net.adamec.lib.common.actor.actor.actorrefs__17fr5vh)           
Sources: actor\IActorRef.cs</small>


System actor (to be used internally if needed)



```csharp
public static IActorRef System { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actorrefs.-cctor__1qfbqdk" />  ActorRefs.ActorRefs() Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefs](#t-net.adamec.lib.common.actor.actor.actorrefs__17fr5vh)           
Sources: actor\IActorRef.cs</small>


Static CTOR - Creates the static references



```csharp
private static ActorRefs()
```

Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.actorrefsystem__43zotr" />  ActorRefSystem Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\IActorRef.cs</small>


Reference to system virtual actor



```csharp
public class ActorRefSystem : ActorRefNameOnly
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.actor.actor.ActorRefNameOnly](#t-net.adamec.lib.common.actor.actor.actorrefnameonly__eu2rbh)           
Implements: [net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Name](#p-net.adamec.lib.common.actor.actor.actorrefsystem.name__q7wot2) | public | Name of the actor - [SYSTEM] | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actorrefsystem.name__q7wot2" />  ActorRefSystem.Name Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefSystem](#t-net.adamec.lib.common.actor.actor.actorrefsystem__43zotr)           
Sources: actor\IActorRef.cs</small>


Name of the actor - [SYSTEM]



```csharp
public override string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6" />  SyncActor Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\SyncActor.cs</small>


Internal actor used in [Ask(IActorRef, object, Type, int, bool)](#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.ask_net.adamec.lib.common.actor.actor.iactorref-system.object-system.type-system.int32-system.boolean___14ecl67) methods to implement Request-Reply pattern



```csharp
internal class SyncActor : BaseDisposable, IActor
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.utils.BaseDisposable](#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>, [net.adamec.lib.common.actor.actor.IActor](#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorSystem](#p-net.adamec.lib.common.actor.actor.syncactor.actorsystem__1jy3biw) | private |  | 
 | [CanReceive](#p-net.adamec.lib.common.actor.actor.syncactor.canreceive__37hi1h) | public | Returns true if the actor can receive messages. If false, the messages will not be dispatched to the actor (they will still be enqueued to actor&#39;s mailbox) | 
 | [ReceiveTarget](#p-net.adamec.lib.common.actor.actor.syncactor.receivetarget__fqhb9w) | public | Current method processing the messages (to where the messages are dispatched to) | 
 | [Response](#p-net.adamec.lib.common.actor.actor.syncactor.response__1nj5lt1) | public | Response message envelope | 
 | [ResponseType](#p-net.adamec.lib.common.actor.actor.syncactor.responsetype__13oqz9h) | public | Expected response type | 
 | [Self](#p-net.adamec.lib.common.actor.actor.syncactor.self__7tb7a6) | public | Actor reference to self | 
 | [WaitHandle](#p-net.adamec.lib.common.actor.actor.syncactor.waithandle__8yoz6j) | public | Wait handle used to signal that the response has arrived | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [SyncActor(IActorSystem, Type, AutoResetEvent)](#m-net.adamec.lib.common.actor.actor.syncactor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.type-system.threading.autoresetevent___2ekqnh) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DisposeManaged()](#m-net.adamec.lib.common.actor.actor.syncactor.disposemanaged__1ldukpd) | protected | Deregisters itself from actor system | 
 | [Receive(Envelope)](#m-net.adamec.lib.common.actor.actor.syncactor.receive_net.adamec.lib.common.actor.message.envelope___1adxu0d) | protected | Message handler - waits for the message of required [ResponseType](#p-net.adamec.lib.common.actor.actor.syncactor.responsetype__13oqz9h) and when arrived, the message envelope is set to [Response](#p-net.adamec.lib.common.actor.actor.syncactor.response__1nj5lt1) and the [WaitHandle](#p-net.adamec.lib.common.actor.actor.syncactor.waithandle__8yoz6j) is set to signal the blocked &quot;parent&quot; thread that the response has been received. | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.syncactor.actorsystem__1jy3biw" />  SyncActor.ActorSystem Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [SyncActor](#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6)           
Sources: actor\SyncActor.cs</small>



```csharp
private IActorSystem ActorSystem { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.syncactor.canreceive__37hi1h" />  SyncActor.CanReceive Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [SyncActor](#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6)           
Sources: actor\SyncActor.cs</small>


Returns true if the actor can receive messages. If false, the messages will not be dispatched to the actor (they will still be enqueued to actor&#39;s mailbox)



```csharp
public bool CanReceive { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.syncactor.receivetarget__fqhb9w" />  SyncActor.ReceiveTarget Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [SyncActor](#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6)           
Sources: actor\SyncActor.cs</small>


Current method processing the messages (to where the messages are dispatched to)



```csharp
public Receive ReceiveTarget { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.Receive](#t-net.adamec.lib.common.actor.actor.receive__1adwyjn)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.syncactor.response__1nj5lt1" />  SyncActor.Response Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [SyncActor](#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6)           
Sources: actor\SyncActor.cs</small>


Response message envelope



```csharp
public Envelope Response { get; private set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.syncactor.responsetype__13oqz9h" />  SyncActor.ResponseType Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [SyncActor](#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6)           
Sources: actor\SyncActor.cs</small>


Expected response type



```csharp
public Type ResponseType { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.syncactor.self__7tb7a6" />  SyncActor.Self Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [SyncActor](#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6)           
Sources: actor\SyncActor.cs</small>


Actor reference to self



```csharp
public IActorRef Self { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.syncactor.waithandle__8yoz6j" />  SyncActor.WaitHandle Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [SyncActor](#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6)           
Sources: actor\SyncActor.cs</small>


Wait handle used to signal that the response has arrived



```csharp
public AutoResetEvent WaitHandle { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.autoresetevent" target="_blank" >System.Threading.AutoResetEvent</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.syncactor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.type-system.threading.autoresetevent___2ekqnh" />  SyncActor.SyncActor(IActorSystem, Type, AutoResetEvent) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [SyncActor](#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6)           
Sources: actor\SyncActor.cs</small>


CTOR



```csharp
public SyncActor(IActorSystem actorSystem, Type responseType, AutoResetEvent waitHandle)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs) <strong>actorSystem</strong></dt><dd>Actor system</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>responseType</strong></dt><dd>Expected type of the response</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.autoresetevent" target="_blank" >System.Threading.AutoResetEvent</a> <strong>waitHandle</strong></dt><dd>Wait handle used to signal that the response has arrived</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.syncactor.disposemanaged__1ldukpd" />  SyncActor.DisposeManaged() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [SyncActor](#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6)           
Sources: actor\SyncActor.cs</small>


Deregisters itself from actor system



```csharp
protected override void DisposeManaged()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.syncactor.receive_net.adamec.lib.common.actor.message.envelope___1adxu0d" />  SyncActor.Receive(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [SyncActor](#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6)           
Sources: actor\SyncActor.cs</small>


Message handler - waits for the message of required [ResponseType](#p-net.adamec.lib.common.actor.actor.syncactor.responsetype__13oqz9h) and when arrived, the message envelope is set to [Response](#p-net.adamec.lib.common.actor.actor.syncactor.response__1nj5lt1) and the [WaitHandle](#p-net.adamec.lib.common.actor.actor.syncactor.waithandle__8yoz6j) is set to signal the blocked &quot;parent&quot; thread that the response has been received.



```csharp
protected virtual bool Receive(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Incoming message envelope</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True when message processed (handled) otherwise false</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.iactor__16hx1xi" />  IActor Interface ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\IActor.cs</small>


Actor interface



```csharp
public interface IActor
```

###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CanReceive](#p-net.adamec.lib.common.actor.actor.iactor.canreceive__f9x86f) | public abstract | Returns true if the actor can receive messages. If false, the messages will not be dispatched to the actor (they will still be enqueued to actor&#39;s mailbox) | 
 | [ReceiveTarget](#p-net.adamec.lib.common.actor.actor.iactor.receivetarget__n44wdg) | public abstract | Current method processing the messages (to where the messages are dispatched to) | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.iactor.canreceive__f9x86f" />  IActor.CanReceive Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [IActor](#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi)           
Sources: actor\IActor.cs</small>


Returns true if the actor can receive messages. If false, the messages will not be dispatched to the actor (they will still be enqueued to actor&#39;s mailbox)



```csharp
public abstract bool CanReceive { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.iactor.receivetarget__n44wdg" />  IActor.ReceiveTarget Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [IActor](#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi)           
Sources: actor\IActor.cs</small>


Current method processing the messages (to where the messages are dispatched to)



```csharp
public abstract Receive ReceiveTarget { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.Receive](#t-net.adamec.lib.common.actor.actor.receive__1adwyjn)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.iactorref__63mbv" />  IActorRef Interface ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\IActorRef.cs</small>


Reference to actor



```csharp
public interface IActorRef
```

###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Name](#p-net.adamec.lib.common.actor.actor.iactorref.name__1ukc8z4) | public abstract | Name of the actor | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Tell(object, IActorRef, string)](#m-net.adamec.lib.common.actor.actor.iactorref.tell_system.object-net.adamec.lib.common.actor.actor.iactorref-system.string___1xlz161) | public abstract | Asynchronously delivers a message to this [IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) in a non-blocking fashion. Uses &quot;at most once&quot; delivery semantics. | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.iactorref.name__1ukc8z4" />  IActorRef.Name Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)           
Sources: actor\IActorRef.cs</small>


Name of the actor



```csharp
public abstract string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.iactorref.tell_system.object-net.adamec.lib.common.actor.actor.iactorref-system.string___1xlz161" />  IActorRef.Tell(object, IActorRef, string) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)           
Sources: actor\IActorRef.cs</small>


Asynchronously delivers a message to this [IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) in a non-blocking fashion. Uses &quot;at most once&quot; delivery semantics.



```csharp
public abstract void Tell(object message, IActorRef sender, string routingKey = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>The message to be sent to the target.</dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>The sender of this message. Defaults to [Empty](#p-net.adamec.lib.common.actor.actor.actorrefs.empty__6f5cpu) if left to `null` .</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>routingKey</strong></dt><dd>Optional routing key - additional information that can be used for routing/processing the message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.receive__1adwyjn" />  Receive Delegate ##
<small>Namespace: [net.adamec.lib.common.actor.actor](#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\IActor.cs</small>


Delegate describing the recipient target (method processing the messages)



```csharp
public delegate bool Receive(Envelope envelope)
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Recipient&#39;s method processing the messages</dd></dl>


<strong>Delegate parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Message envelope</dd></dl>
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.delegate" target="_blank" >Delegate</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.multicastdelegate" target="_blank" >MulticastDelegate</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icloneable" target="_blank" >System.ICloneable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.iserializable" target="_blank" >System.Runtime.Serialization.ISerializable</a>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h" />  net.adamec.lib.common.actor.actor.exchanges.@base Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq) | public abstract | Exchange actor base class providing the common logic for implementation of exchanges - the actors routing the messages to another actors based on subscriptions. | 
 | [Subscription](#t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm) | public | Base exchange actor subscription | 
 | [SubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage__1d4egm1) | public | Base exchange actor subscription messages | 
 | [UnSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.base.unsubscriptionmessage__15gfzkw) | public | Base exchange actor un-subscription message | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt; Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


Exchange actor base class providing the common logic for implementation of exchanges - the actors routing the messages to another actors based on subscriptions.



```csharp
public abstract class ExchangeActor<TSubscription, TSubscriptionMessage, TUnSubscriptionMessage> : Actor
 where TSubscription: Subscription
 where TSubscriptionMessage: SubscriptionMessage
 where TUnSubscriptionMessage: UnSubscriptionMessage
```

<strong>Type parameters</strong><dl><dt><strong>TSubscription</strong></dt><dd>Type of the subscription</dd><dt><strong>TSubscriptionMessage</strong></dt><dd>Type of the subscription message</dd><dt><strong>TUnSubscriptionMessage</strong></dt><dd>Type of the unSubscription message</dd></dl>
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.utils.BaseDisposable](#t-net.adamec.lib.common.utils.basedisposable__7s72ps) -&gt; [net.adamec.lib.common.actor.actor.Actor](#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>, [net.adamec.lib.common.actor.actor.IActor](#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Subscriptions](#p-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptions__n0rnra) | protected | List of subscriptions | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;(IActorSystem, string)](#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___x732m3) | protected | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DistributeMessage(Envelope, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscription)](#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.distributemessage_net.adamec.lib.common.actor.message.envelope--0___10o2gwi) | protected | Distributes the message according to single <strong>subscription</strong> | 
 | [GetSubscriptionsForMessage(Envelope)](#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.getsubscriptionsformessage_net.adamec.lib.common.actor.message.envelope___1lba1kc) | protected | Returns the list of subscriptions that match the incoming <strong>envelope</strong> | 
 | [IsUnSubscribeMatch(ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscription, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TUnSubscriptionMessage)](#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.isunsubscribematch_-0--2___87gny2) | protected | Checks whether the <strong>unSubscriptionMessage</strong> can unsubscribe the <strong>subscription</strong> (both related to the same actor) | 
 | [Receive(Envelope)](#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.receive_net.adamec.lib.common.actor.message.envelope___k7qhyb) | protected | Message handler The subscription/unsubscription messages are handled first, the other messages are matched to the existing subscriptions and distributed to matching subscribers | 
 | [ReplaceOnSubscribe(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref--1___16aaybh) | protected | Checks for the list of existing subscriptions that are to be replaced by the new subscription defined in <strong>subscriptionMessage</strong> The new subscription can replace the existing subscriptions of other actors.There is no &quot;signaling&quot; to the actors, that their subscription has been replaced (canceled). | 
 | [Start()](#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.start__1sb73cd) | public | Starts the exchange actor | 
 | [Stop()](#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.stop__1wazv35) | public | Stops the exchange actor | 
 | [Subscribe(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscribe_net.adamec.lib.common.actor.actor.iactorref--1___ajhl0) | protected | Processes the subscription message It first checks, whether the new subscription replaces any existing subscription by calling [ReplaceOnSubscribe(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref--1___16aaybh) . If the returned list is not empty, the replaces subscriptions are removed from the [Subscriptions](#p-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptions__n0rnra) list. The [SubscriptionFactory(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref--1___hz2yob) is called to create the new instance of subscription and the subscription is added to the [Subscriptions](#p-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptions__n0rnra) list. | 
 | [SubscriptionFactory(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref--1___hz2yob) | protected abstract | Creates a new subscription instance based on the <strong>subscriptionMessage</strong> | 
 | [UnSubscribe(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TUnSubscriptionMessage)](#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.unsubscribe_net.adamec.lib.common.actor.actor.iactorref--2___198es5m) | protected | Processes the unsubscription message Checks the existing subscriptions of <strong>actorRef</strong> whether they match the <strong>unSubscriptionMessage</strong> and removes the matching ones from [Subscriptions](#p-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptions__n0rnra) list. | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptions__n0rnra" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.Subscriptions Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


List of subscriptions



```csharp
protected List<TSubscription> Subscriptions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;TSubscription&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___x732m3" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;(IActorSystem, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


CTOR



```csharp
protected ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>(IActorSystem actorSystem, string name)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs) <strong>actorSystem</strong></dt><dd>Actor system</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the exchange actor</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.distributemessage_net.adamec.lib.common.actor.message.envelope--0___10o2gwi" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.DistributeMessage(Envelope, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscription) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


Distributes the message according to single <strong>subscription</strong>



```csharp
protected virtual void DistributeMessage(Envelope envelope, ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>.TSubscription subscription)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Message envelope</dd><dt>net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscription <strong>subscription</strong></dt><dd>Subscriptions matching the message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.getsubscriptionsformessage_net.adamec.lib.common.actor.message.envelope___1lba1kc" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.GetSubscriptionsForMessage(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


Returns the list of subscriptions that match the incoming <strong>envelope</strong>



```csharp
protected virtual ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>.TSubscription[] GetSubscriptionsForMessage(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Incoming message</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscription[]</dt><dd>List of subscriptions that match the incoming <strong>envelope</strong></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.isunsubscribematch_-0--2___87gny2" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.IsUnSubscribeMatch(ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscription, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TUnSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


Checks whether the <strong>unSubscriptionMessage</strong> can unsubscribe the <strong>subscription</strong> (both related to the same actor)



```csharp
protected virtual bool IsUnSubscribeMatch(ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>.TSubscription subscription, ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>.TUnSubscriptionMessage unSubscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscription <strong>subscription</strong></dt><dd>Existing subscription</dd><dt>net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TUnSubscriptionMessage <strong>unSubscriptionMessage</strong></dt><dd>UnSubscription message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Returns true when the <strong>unSubscriptionMessage</strong> unsubscribes the <strong>subscription</strong> , otherwise false is returned</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.receive_net.adamec.lib.common.actor.message.envelope___k7qhyb" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.Receive(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


Message handler The subscription/unsubscription messages are handled first, the other messages are matched to the existing subscriptions and distributed to matching subscribers



```csharp
protected override bool Receive(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Message envelope</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True if the messages has been handled, otherwise false</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref--1___16aaybh" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.ReplaceOnSubscribe(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


Checks for the list of existing subscriptions that are to be replaced by the new subscription defined in <strong>subscriptionMessage</strong> The new subscription can replace the existing subscriptions of other actors.There is no &quot;signaling&quot; to the actors, that their subscription has been replaced (canceled).



```csharp
protected virtual ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>.TSubscription[] ReplaceOnSubscribe(IActorRef actorRef, ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>.TSubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscription[]</dt><dd>List of existing subscriptions to be removed from the [Subscriptions](#p-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptions__n0rnra) list</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.start__1sb73cd" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.Start() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


Starts the exchange actor



```csharp
public virtual void Start()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.stop__1wazv35" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.Stop() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


Stops the exchange actor



```csharp
public virtual void Stop()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscribe_net.adamec.lib.common.actor.actor.iactorref--1___ajhl0" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.Subscribe(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


Processes the subscription message It first checks, whether the new subscription replaces any existing subscription by calling [ReplaceOnSubscribe(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref--1___16aaybh) . If the returned list is not empty, the replaces subscriptions are removed from the [Subscriptions](#p-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptions__n0rnra) list. The [SubscriptionFactory(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref--1___hz2yob) is called to create the new instance of subscription and the subscription is added to the [Subscriptions](#p-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptions__n0rnra) list.



```csharp
protected virtual void Subscribe(IActorRef actorRef, ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>.TSubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref--1___hz2yob" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.SubscriptionFactory(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


Creates a new subscription instance based on the <strong>subscriptionMessage</strong>



```csharp
protected abstract ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>.TSubscription SubscriptionFactory(IActorRef actorRef, ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>.TSubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscription</dt><dd>Subscription instance</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.unsubscribe_net.adamec.lib.common.actor.actor.iactorref--2___198es5m" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.UnSubscribe(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TUnSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


Processes the unsubscription message Checks the existing subscriptions of <strong>actorRef</strong> whether they match the <strong>unSubscriptionMessage</strong> and removes the matching ones from [Subscriptions](#p-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptions__n0rnra) list.



```csharp
protected virtual void UnSubscribe(IActorRef actorRef, ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>.TUnSubscriptionMessage unSubscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to unsubscribing actor</dd><dt>net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TUnSubscriptionMessage <strong>unSubscriptionMessage</strong></dt><dd>UnSubscription message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm" />  Subscription Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\base\Subscription.cs</small>


Base exchange actor subscription



```csharp
public class Subscription
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorRef](#p-net.adamec.lib.common.actor.actor.exchanges.base.subscription.actorref__4ba6je) | public | Reference to subscribed actor | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Subscription(IActorRef)](#m-net.adamec.lib.common.actor.actor.exchanges.base.subscription.-ctor_net.adamec.lib.common.actor.actor.iactorref___1vbtza6) | public | CTOR | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.exchanges.base.subscription.actorref__4ba6je" />  Subscription.ActorRef Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [Subscription](#t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm)           
Sources: actor\exchanges\base\Subscription.cs</small>


Reference to subscribed actor



```csharp
public IActorRef ActorRef { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.subscription.-ctor_net.adamec.lib.common.actor.actor.iactorref___1vbtza6" />  Subscription.Subscription(IActorRef) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [Subscription](#t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm)           
Sources: actor\exchanges\base\Subscription.cs</small>


CTOR



```csharp
public Subscription(IActorRef actorRef)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribed actor</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage__1d4egm1" />  SubscriptionMessage Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\base\SubscriptionMessage.cs</small>


Base exchange actor subscription messages



```csharp
public class SubscriptionMessage
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.base.unsubscriptionmessage__15gfzkw" />  UnSubscriptionMessage Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\base\SubscriptionMessage.cs</small>


Base exchange actor un-subscription message



```csharp
public class UnSubscriptionMessage
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="n-net.adamec.lib.common.actor.actor.exchanges.single__6r83x4" />  net.adamec.lib.common.actor.actor.exchanges.single Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [SingleExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor__1q6rr7y) | public | Exchange Actor with zero or one subscriber | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor__1q6rr7y" />  SingleExchangeActor Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.single](#n-net.adamec.lib.common.actor.actor.exchanges.single__6r83x4)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\single\SingleExchangeActor.cs</small>


Exchange Actor with zero or one subscriber



```csharp
public class SingleExchangeActor : ExchangeActor<net.adamec.lib.common.actor.actor.exchanges.@base.Subscription,net.adamec.lib.common.actor.actor.exchanges.@base.SubscriptionMessage,net.adamec.lib.common.actor.actor.exchanges.@base.UnSubscriptionMessage>
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.utils.BaseDisposable](#t-net.adamec.lib.common.utils.basedisposable__7s72ps) -&gt; [net.adamec.lib.common.actor.actor.Actor](#t-net.adamec.lib.common.actor.actor.actor__buuxwr) -&gt; [net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;net.adamec.lib.common.actor.actor.exchanges.@base.Subscription,net.adamec.lib.common.actor.actor.exchanges.@base.SubscriptionMessage,net.adamec.lib.common.actor.actor.exchanges.@base.UnSubscriptionMessage&gt;](#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>, [net.adamec.lib.common.actor.actor.IActor](#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi)


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [SingleExchangeActor(IActorSystem, string)](#m-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___1090o6d) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ReplaceOnSubscribe(IActorRef, SubscriptionMessage)](#m-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage___1t22f9h) | protected | Removes all existing subscription when a new subscription message arrives. | 
 | [SubscriptionFactory(IActorRef, SubscriptionMessage)](#m-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage___kht5cf) | protected | Creates a new [Subscription](#t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm) instance for incoming <strong>subscriptionMessage</strong> | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___1090o6d" />  SingleExchangeActor.SingleExchangeActor(IActorSystem, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.single](#n-net.adamec.lib.common.actor.actor.exchanges.single__6r83x4)           
Assembly: net.adamec.lib.common.actor           
Type: [SingleExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor__1q6rr7y)           
Sources: actor\exchanges\single\SingleExchangeActor.cs</small>


CTOR



```csharp
public SingleExchangeActor(IActorSystem actorSystem, string name)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs) <strong>actorSystem</strong></dt><dd>Actor system</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the exchange actor</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage___1t22f9h" />  SingleExchangeActor.ReplaceOnSubscribe(IActorRef, SubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.single](#n-net.adamec.lib.common.actor.actor.exchanges.single__6r83x4)           
Assembly: net.adamec.lib.common.actor           
Type: [SingleExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor__1q6rr7y)           
Sources: actor\exchanges\single\SingleExchangeActor.cs</small>


Removes all existing subscription when a new subscription message arrives.



```csharp
protected override Subscription[] ReplaceOnSubscribe(IActorRef actorRef, SubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.@base.SubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage__1d4egm1) <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.@base.Subscription[]](#t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm)</dt><dd>List of all existing subscriptions</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage___kht5cf" />  SingleExchangeActor.SubscriptionFactory(IActorRef, SubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.single](#n-net.adamec.lib.common.actor.actor.exchanges.single__6r83x4)           
Assembly: net.adamec.lib.common.actor           
Type: [SingleExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor__1q6rr7y)           
Sources: actor\exchanges\single\SingleExchangeActor.cs</small>


Creates a new [Subscription](#t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm) instance for incoming <strong>subscriptionMessage</strong>



```csharp
protected override Subscription SubscriptionFactory(IActorRef actorRef, SubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.@base.SubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage__1d4egm1) <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.@base.Subscription](#t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm)</dt><dd>Subscription instance</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao" />  net.adamec.lib.common.actor.actor.exchanges.typed Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RoutingKeyExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor__1inw5x7) | public | Exchange Actor with zero or more actors per message type with routing based also on routing key Subscriptions are per actor, type and routing key. Subscription filter gets the all subscriptions where message is instance of  filter type or its children and the routing keys match | 
 | [RoutingKeySubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0) | public | Subscription for exchanges that routes the messages based on their type and routing key | 
 | [RoutingKeySubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage__1h3lr73) | public | Subscription message for [RoutingKeySubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0) | 
 | [RoutingKeyUnSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage__emjdu2) | public | UnSubscription message for [RoutingKeySubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0) | 
 | [TypedMultiExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor__1rgmwat) | public | Exchange Actor with zero or more actors per message type Subscriptions are per actor and type. Subscription filter gets the all subscriptions where message is instance of  filter type or its children | 
 | [TypedSingleExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor__i752da) | public | Exchange Actor with zero or one actor per message type Subscriptions are per type. Subscription filter gets the exact type match and if not found, then first match where message is instance of  filter type or its children | 
 | [TypedSubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) | public | Subscription for exchanges that routes the messages based on their type | 
 | [TypedSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage__1hh0wlc) | public | Subscription message for [TypedSubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) | 
 | [TypedUnSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage__9g51i3) | public | UnSubscription message for [TypedSubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor__1inw5x7" />  RoutingKeyExchangeActor Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\typed\RoutingKeyExchangeActor.cs</small>


Exchange Actor with zero or more actors per message type with routing based also on routing key Subscriptions are per actor, type and routing key. Subscription filter gets the all subscriptions where message is instance of  filter type or its children and the routing keys match



```csharp
public class RoutingKeyExchangeActor : ExchangeActor<net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscription,net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscriptionMessage,net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeyUnSubscriptionMessage>
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.utils.BaseDisposable](#t-net.adamec.lib.common.utils.basedisposable__7s72ps) -&gt; [net.adamec.lib.common.actor.actor.Actor](#t-net.adamec.lib.common.actor.actor.actor__buuxwr) -&gt; [net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscription,net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscriptionMessage,net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeyUnSubscriptionMessage&gt;](#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>, [net.adamec.lib.common.actor.actor.IActor](#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi)


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RoutingKeyExchangeActor(IActorSystem, string)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___17ryw0k) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetSubscriptionsForMessage(Envelope)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.getsubscriptionsformessage_net.adamec.lib.common.actor.message.envelope___1iabgbj) | protected | Returns the list of subscriptions that match the incoming <strong>envelope</strong> The filter gets all matches where message is instance of  filter type or its children and the routing key matches the subscription | 
 | [IsRoutingKeyMatch(string, string)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.isroutingkeymatch_system.string-system.string___102orov) | protected | Checks whether the message routing key matches the subscription routing key The default implementation is for the exact match, override this method for more complex matching (for example regexp) | 
 | [IsUnSubscribeMatch(RoutingKeySubscription, RoutingKeyUnSubscriptionMessage)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.isunsubscribematch_net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage___1qyhqkr) | protected | Checks whether the <strong>unSubscriptionMessage</strong> can unsubscribe the <strong>subscription</strong> (both related to the same actor) The match is when both <strong>subscription</strong> and <strong>unSubscriptionMessage</strong> use the same message type | 
 | [ReplaceOnSubscribe(IActorRef, RoutingKeySubscriptionMessage)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage___rj17km) | protected | Removes existing subscriptions for <strong>actorRef</strong> with the same &quot;subscription type&quot; when a new subscription message arrives. | 
 | [SubscriptionFactory(IActorRef, RoutingKeySubscriptionMessage)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage___3ufphk) | protected | Creates a new <em>net.adamec.lib.common.actor.actor.exchanges.typed.TypedRoutingKeySubscription</em> instance based on the <strong>subscriptionMessage</strong> | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___17ryw0k" />  RoutingKeyExchangeActor.RoutingKeyExchangeActor(IActorSystem, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeyExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor__1inw5x7)           
Sources: actor\exchanges\typed\RoutingKeyExchangeActor.cs</small>


CTOR



```csharp
public RoutingKeyExchangeActor(IActorSystem actorSystem, string name)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs) <strong>actorSystem</strong></dt><dd>Actor system</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the exchange actor</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.getsubscriptionsformessage_net.adamec.lib.common.actor.message.envelope___1iabgbj" />  RoutingKeyExchangeActor.GetSubscriptionsForMessage(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeyExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor__1inw5x7)           
Sources: actor\exchanges\typed\RoutingKeyExchangeActor.cs</small>


Returns the list of subscriptions that match the incoming <strong>envelope</strong> The filter gets all matches where message is instance of  filter type or its children and the routing key matches the subscription



```csharp
protected override RoutingKeySubscription[] GetSubscriptionsForMessage(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Incoming message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscription[]](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0)</dt><dd>List of subscriptions that match the incoming <strong>envelope</strong></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.isroutingkeymatch_system.string-system.string___102orov" />  RoutingKeyExchangeActor.IsRoutingKeyMatch(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeyExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor__1inw5x7)           
Sources: actor\exchanges\typed\RoutingKeyExchangeActor.cs</small>


Checks whether the message routing key matches the subscription routing key The default implementation is for the exact match, override this method for more complex matching (for example regexp)



```csharp
protected virtual bool IsRoutingKeyMatch(string subscriptionRoutingKey, string messageRoutingKey)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>subscriptionRoutingKey</strong></dt><dd>Subscription routing key</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>messageRoutingKey</strong></dt><dd>Message routing key</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True when the message routing key matches the subscription routing key, otherwise false</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.isunsubscribematch_net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage___1qyhqkr" />  RoutingKeyExchangeActor.IsUnSubscribeMatch(RoutingKeySubscription, RoutingKeyUnSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeyExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor__1inw5x7)           
Sources: actor\exchanges\typed\RoutingKeyExchangeActor.cs</small>


Checks whether the <strong>unSubscriptionMessage</strong> can unsubscribe the <strong>subscription</strong> (both related to the same actor) The match is when both <strong>subscription</strong> and <strong>unSubscriptionMessage</strong> use the same message type



```csharp
protected override bool IsUnSubscribeMatch(RoutingKeySubscription subscription, RoutingKeyUnSubscriptionMessage unSubscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0) <strong>subscription</strong></dt><dd>Existing subscription</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeyUnSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage__emjdu2) <strong>unSubscriptionMessage</strong></dt><dd>UnSubscription message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Returns true when the <strong>unSubscriptionMessage</strong> unsubscribes the <strong>subscription</strong> , otherwise false is returned</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage___rj17km" />  RoutingKeyExchangeActor.ReplaceOnSubscribe(IActorRef, RoutingKeySubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeyExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor__1inw5x7)           
Sources: actor\exchanges\typed\RoutingKeyExchangeActor.cs</small>


Removes existing subscriptions for <strong>actorRef</strong> with the same &quot;subscription type&quot; when a new subscription message arrives.



```csharp
protected override RoutingKeySubscription[] ReplaceOnSubscribe(IActorRef actorRef, RoutingKeySubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage__1h3lr73) <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscription[]](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0)</dt><dd>List of all existing subscriptions</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage___3ufphk" />  RoutingKeyExchangeActor.SubscriptionFactory(IActorRef, RoutingKeySubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeyExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor__1inw5x7)           
Sources: actor\exchanges\typed\RoutingKeyExchangeActor.cs</small>


Creates a new <em>net.adamec.lib.common.actor.actor.exchanges.typed.TypedRoutingKeySubscription</em> instance based on the <strong>subscriptionMessage</strong>



```csharp
protected override RoutingKeySubscription SubscriptionFactory(IActorRef actorRef, RoutingKeySubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage__1h3lr73) <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0)</dt><dd>Subscription instance</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0" />  RoutingKeySubscription Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\typed\RoutingKeySubscription.cs</small>


Subscription for exchanges that routes the messages based on their type and routing key



```csharp
public class RoutingKeySubscription : TypedSubscription
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.actor.actor.exchanges.@base.Subscription](#t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm) -&gt; [net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RoutingKey](#p-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription.routingkey__a5qax5) | public | Routing key filter (if null, matches all messages) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RoutingKeySubscription(Type, string, IActorRef)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription.-ctor_system.type-system.string-net.adamec.lib.common.actor.actor.iactorref___15anvd7) | public | CTOR | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription.routingkey__a5qax5" />  RoutingKeySubscription.RoutingKey Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeySubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0)           
Sources: actor\exchanges\typed\RoutingKeySubscription.cs</small>


Routing key filter (if null, matches all messages)



```csharp
public string RoutingKey { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription.-ctor_system.type-system.string-net.adamec.lib.common.actor.actor.iactorref___15anvd7" />  RoutingKeySubscription.RoutingKeySubscription(Type, string, IActorRef) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeySubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0)           
Sources: actor\exchanges\typed\RoutingKeySubscription.cs</small>


CTOR



```csharp
public RoutingKeySubscription(Type messageType, string routingKey, IActorRef actorRef)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>messageType</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>routingKey</strong></dt><dd>Routing key filter (if null, matches all messages)</dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribed actor</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage__1h3lr73" />  RoutingKeySubscriptionMessage Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\typed\RoutingKeySubscriptionMessage.cs</small>


Subscription message for [RoutingKeySubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0)



```csharp
public class RoutingKeySubscriptionMessage : TypedSubscriptionMessage
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.actor.actor.exchanges.@base.SubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage__1d4egm1) -&gt; [net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage__1hh0wlc)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RoutingKey](#p-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage.routingkey__qsyr8a) | public | Routing key filter (if null, matches all messages) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RoutingKeySubscriptionMessage(Type, string)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage.-ctor_system.type-system.string___bzfl4x) | public | CTOR | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage.routingkey__qsyr8a" />  RoutingKeySubscriptionMessage.RoutingKey Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeySubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage__1h3lr73)           
Sources: actor\exchanges\typed\RoutingKeySubscriptionMessage.cs</small>


Routing key filter (if null, matches all messages)



```csharp
public string RoutingKey { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage.-ctor_system.type-system.string___bzfl4x" />  RoutingKeySubscriptionMessage.RoutingKeySubscriptionMessage(Type, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeySubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage__1h3lr73)           
Sources: actor\exchanges\typed\RoutingKeySubscriptionMessage.cs</small>


CTOR



```csharp
public RoutingKeySubscriptionMessage(Type messageType, string routingKey)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>messageType</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>routingKey</strong></dt><dd>Routing key filter (if null, matches all messages)</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage__emjdu2" />  RoutingKeyUnSubscriptionMessage Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\typed\RoutingKeySubscriptionMessage.cs</small>


UnSubscription message for [RoutingKeySubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0)



```csharp
public class RoutingKeyUnSubscriptionMessage : TypedUnSubscriptionMessage
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.actor.actor.exchanges.@base.UnSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.base.unsubscriptionmessage__15gfzkw) -&gt; [net.adamec.lib.common.actor.actor.exchanges.typed.TypedUnSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage__9g51i3)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RoutingKey](#p-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage.routingkey__16ll9yd) | public | Routing key filter (if null, matches all messages) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RoutingKeyUnSubscriptionMessage(Type, string)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage.-ctor_system.type-system.string___1eem2s) | public | CTOR | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage.routingkey__16ll9yd" />  RoutingKeyUnSubscriptionMessage.RoutingKey Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeyUnSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage__emjdu2)           
Sources: actor\exchanges\typed\RoutingKeySubscriptionMessage.cs</small>


Routing key filter (if null, matches all messages)



```csharp
public string RoutingKey { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage.-ctor_system.type-system.string___1eem2s" />  RoutingKeyUnSubscriptionMessage.RoutingKeyUnSubscriptionMessage(Type, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeyUnSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage__emjdu2)           
Sources: actor\exchanges\typed\RoutingKeySubscriptionMessage.cs</small>


CTOR



```csharp
public RoutingKeyUnSubscriptionMessage(Type messageType, string routingKey)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>messageType</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>routingKey</strong></dt><dd>Routing key filter (if null, matches all messages)</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor__1rgmwat" />  TypedMultiExchangeActor Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\typed\TypedMultiExchangeActor.cs</small>


Exchange Actor with zero or more actors per message type Subscriptions are per actor and type. Subscription filter gets the all subscriptions where message is instance of  filter type or its children



```csharp
public class TypedMultiExchangeActor : ExchangeActor<net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription,net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscriptionMessage,net.adamec.lib.common.actor.actor.exchanges.typed.TypedUnSubscriptionMessage>
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.utils.BaseDisposable](#t-net.adamec.lib.common.utils.basedisposable__7s72ps) -&gt; [net.adamec.lib.common.actor.actor.Actor](#t-net.adamec.lib.common.actor.actor.actor__buuxwr) -&gt; [net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription,net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscriptionMessage,net.adamec.lib.common.actor.actor.exchanges.typed.TypedUnSubscriptionMessage&gt;](#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>, [net.adamec.lib.common.actor.actor.IActor](#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi)


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TypedMultiExchangeActor(IActorSystem, string)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___1l0lpb0) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetSubscriptionsForMessage(Envelope)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor.getsubscriptionsformessage_net.adamec.lib.common.actor.message.envelope___9uu8op) | protected | Returns the list of subscriptions that match the incoming <strong>envelope</strong> The filter gets all matches where message is instance of  filter type or its children | 
 | [IsUnSubscribeMatch(TypedSubscription, TypedUnSubscriptionMessage)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor.isunsubscribematch_net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage___kjj5nt) | protected | Checks whether the <strong>unSubscriptionMessage</strong> can unsubscribe the <strong>subscription</strong> (both related to the same actor) The match is when both <strong>subscription</strong> and <strong>unSubscriptionMessage</strong> use the same message type | 
 | [ReplaceOnSubscribe(IActorRef, TypedSubscriptionMessage)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage___1wvem41) | protected | Removes existing subscriptions for <strong>actorRef</strong> with the same &quot;subscription type&quot; when a new subscription message arrives. | 
 | [SubscriptionFactory(IActorRef, TypedSubscriptionMessage)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage___10dtbmj) | protected | Creates a new [TypedSubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) instance based on the <strong>subscriptionMessage</strong> | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___1l0lpb0" />  TypedMultiExchangeActor.TypedMultiExchangeActor(IActorSystem, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedMultiExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor__1rgmwat)           
Sources: actor\exchanges\typed\TypedMultiExchangeActor.cs</small>


CTOR



```csharp
public TypedMultiExchangeActor(IActorSystem actorSystem, string name)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs) <strong>actorSystem</strong></dt><dd>Actor system</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the exchange actor</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor.getsubscriptionsformessage_net.adamec.lib.common.actor.message.envelope___9uu8op" />  TypedMultiExchangeActor.GetSubscriptionsForMessage(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedMultiExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor__1rgmwat)           
Sources: actor\exchanges\typed\TypedMultiExchangeActor.cs</small>


Returns the list of subscriptions that match the incoming <strong>envelope</strong> The filter gets all matches where message is instance of  filter type or its children



```csharp
protected override TypedSubscription[] GetSubscriptionsForMessage(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Incoming message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription[]](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)</dt><dd>List of subscriptions that match the incoming <strong>envelope</strong></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor.isunsubscribematch_net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage___kjj5nt" />  TypedMultiExchangeActor.IsUnSubscribeMatch(TypedSubscription, TypedUnSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedMultiExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor__1rgmwat)           
Sources: actor\exchanges\typed\TypedMultiExchangeActor.cs</small>


Checks whether the <strong>unSubscriptionMessage</strong> can unsubscribe the <strong>subscription</strong> (both related to the same actor) The match is when both <strong>subscription</strong> and <strong>unSubscriptionMessage</strong> use the same message type



```csharp
protected override bool IsUnSubscribeMatch(TypedSubscription subscription, TypedUnSubscriptionMessage unSubscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) <strong>subscription</strong></dt><dd>Existing subscription</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedUnSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage__9g51i3) <strong>unSubscriptionMessage</strong></dt><dd>UnSubscription message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Returns true when the <strong>unSubscriptionMessage</strong> unsubscribes the <strong>subscription</strong> , otherwise false is returned</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage___1wvem41" />  TypedMultiExchangeActor.ReplaceOnSubscribe(IActorRef, TypedSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedMultiExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor__1rgmwat)           
Sources: actor\exchanges\typed\TypedMultiExchangeActor.cs</small>


Removes existing subscriptions for <strong>actorRef</strong> with the same &quot;subscription type&quot; when a new subscription message arrives.



```csharp
protected override TypedSubscription[] ReplaceOnSubscribe(IActorRef actorRef, TypedSubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage__1hh0wlc) <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription[]](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)</dt><dd>List of all existing subscriptions</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage___10dtbmj" />  TypedMultiExchangeActor.SubscriptionFactory(IActorRef, TypedSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedMultiExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor__1rgmwat)           
Sources: actor\exchanges\typed\TypedMultiExchangeActor.cs</small>


Creates a new [TypedSubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) instance based on the <strong>subscriptionMessage</strong>



```csharp
protected override TypedSubscription SubscriptionFactory(IActorRef actorRef, TypedSubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage__1hh0wlc) <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)</dt><dd>Subscription instance</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor__i752da" />  TypedSingleExchangeActor Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\typed\TypedSingleExchangeActor.cs</small>


Exchange Actor with zero or one actor per message type Subscriptions are per type. Subscription filter gets the exact type match and if not found, then first match where message is instance of  filter type or its children



```csharp
public class TypedSingleExchangeActor : ExchangeActor<net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription,net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscriptionMessage,net.adamec.lib.common.actor.actor.exchanges.typed.TypedUnSubscriptionMessage>
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.utils.BaseDisposable](#t-net.adamec.lib.common.utils.basedisposable__7s72ps) -&gt; [net.adamec.lib.common.actor.actor.Actor](#t-net.adamec.lib.common.actor.actor.actor__buuxwr) -&gt; [net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription,net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscriptionMessage,net.adamec.lib.common.actor.actor.exchanges.typed.TypedUnSubscriptionMessage&gt;](#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>, [net.adamec.lib.common.actor.actor.IActor](#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi)


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TypedSingleExchangeActor(IActorSystem, string)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___1nv1jk7) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetSubscriptionsForMessage(Envelope)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor.getsubscriptionsformessage_net.adamec.lib.common.actor.message.envelope___1pc989c) | protected | Returns the list of subscriptions that match the incoming <strong>envelope</strong> The filter gets the exact type match and if not found, then first match where message is instance of  filter type or its children Note: There can be only one subscription per message type | 
 | [IsUnSubscribeMatch(TypedSubscription, TypedUnSubscriptionMessage)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor.isunsubscribematch_net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage___zk123g) | protected | Checks whether the <strong>unSubscriptionMessage</strong> can unsubscribe the <strong>subscription</strong> (both related to the same actor) The match is when both <strong>subscription</strong> and <strong>unSubscriptionMessage</strong> use the same message type | 
 | [ReplaceOnSubscribe(IActorRef, TypedSubscriptionMessage)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage___azg7e0) | protected | Removes existing subscriptions with the same &quot;subscription type&quot; when a new subscription message arrives. | 
 | [SubscriptionFactory(IActorRef, TypedSubscriptionMessage)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage___1dxxz9k) | protected | Creates a new [TypedSubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) instance based on the <strong>subscriptionMessage</strong> | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___1nv1jk7" />  TypedSingleExchangeActor.TypedSingleExchangeActor(IActorSystem, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedSingleExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor__i752da)           
Sources: actor\exchanges\typed\TypedSingleExchangeActor.cs</small>


CTOR



```csharp
public TypedSingleExchangeActor(IActorSystem actorSystem, string name)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs) <strong>actorSystem</strong></dt><dd>Actor system</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the exchange actor</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor.getsubscriptionsformessage_net.adamec.lib.common.actor.message.envelope___1pc989c" />  TypedSingleExchangeActor.GetSubscriptionsForMessage(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedSingleExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor__i752da)           
Sources: actor\exchanges\typed\TypedSingleExchangeActor.cs</small>


Returns the list of subscriptions that match the incoming <strong>envelope</strong> The filter gets the exact type match and if not found, then first match where message is instance of  filter type or its children Note: There can be only one subscription per message type



```csharp
protected override TypedSubscription[] GetSubscriptionsForMessage(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Incoming message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription[]](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)</dt><dd>List of subscriptions that match the incoming <strong>envelope</strong></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor.isunsubscribematch_net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage___zk123g" />  TypedSingleExchangeActor.IsUnSubscribeMatch(TypedSubscription, TypedUnSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedSingleExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor__i752da)           
Sources: actor\exchanges\typed\TypedSingleExchangeActor.cs</small>


Checks whether the <strong>unSubscriptionMessage</strong> can unsubscribe the <strong>subscription</strong> (both related to the same actor) The match is when both <strong>subscription</strong> and <strong>unSubscriptionMessage</strong> use the same message type



```csharp
protected override bool IsUnSubscribeMatch(TypedSubscription subscription, TypedUnSubscriptionMessage unSubscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) <strong>subscription</strong></dt><dd>Existing subscription</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedUnSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage__9g51i3) <strong>unSubscriptionMessage</strong></dt><dd>UnSubscription message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Returns true when the <strong>unSubscriptionMessage</strong> unsubscribes the <strong>subscription</strong> , otherwise false is returned</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage___azg7e0" />  TypedSingleExchangeActor.ReplaceOnSubscribe(IActorRef, TypedSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedSingleExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor__i752da)           
Sources: actor\exchanges\typed\TypedSingleExchangeActor.cs</small>


Removes existing subscriptions with the same &quot;subscription type&quot; when a new subscription message arrives.



```csharp
protected override TypedSubscription[] ReplaceOnSubscribe(IActorRef actorRef, TypedSubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage__1hh0wlc) <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription[]](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)</dt><dd>List of all existing subscriptions</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage___1dxxz9k" />  TypedSingleExchangeActor.SubscriptionFactory(IActorRef, TypedSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedSingleExchangeActor](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor__i752da)           
Sources: actor\exchanges\typed\TypedSingleExchangeActor.cs</small>


Creates a new [TypedSubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) instance based on the <strong>subscriptionMessage</strong>



```csharp
protected override TypedSubscription SubscriptionFactory(IActorRef actorRef, TypedSubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage__1hh0wlc) <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)</dt><dd>Subscription instance</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b" />  TypedSubscription Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\typed\TypedSubscription.cs</small>


Subscription for exchanges that routes the messages based on their type



```csharp
public class TypedSubscription : Subscription
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.actor.actor.exchanges.@base.Subscription](#t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MessageType](#p-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription.messagetype__1os7ees) | public | <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TypedSubscription(Type, IActorRef)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription.-ctor_system.type-net.adamec.lib.common.actor.actor.iactorref___vgut5o) | public | CTOR | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription.messagetype__1os7ees" />  TypedSubscription.MessageType Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedSubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)           
Sources: actor\exchanges\typed\TypedSubscription.cs</small>


<a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message



```csharp
public Type MessageType { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription.-ctor_system.type-net.adamec.lib.common.actor.actor.iactorref___vgut5o" />  TypedSubscription.TypedSubscription(Type, IActorRef) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedSubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)           
Sources: actor\exchanges\typed\TypedSubscription.cs</small>


CTOR



```csharp
public TypedSubscription(Type messageType, IActorRef actorRef)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>messageType</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message</dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribed actor</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage__1hh0wlc" />  TypedSubscriptionMessage Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\typed\TypedSubscriptionMessage.cs</small>


Subscription message for [TypedSubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)



```csharp
public class TypedSubscriptionMessage : SubscriptionMessage
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.actor.actor.exchanges.@base.SubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage__1d4egm1)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MessageType](#p-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage.messagetype__kfnrfx) | public | <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TypedSubscriptionMessage(Type)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage.-ctor_system.type___6y7fn4) | public | CTOR | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage.messagetype__kfnrfx" />  TypedSubscriptionMessage.MessageType Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage__1hh0wlc)           
Sources: actor\exchanges\typed\TypedSubscriptionMessage.cs</small>


<a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message



```csharp
public Type MessageType { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage.-ctor_system.type___6y7fn4" />  TypedSubscriptionMessage.TypedSubscriptionMessage(Type) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage__1hh0wlc)           
Sources: actor\exchanges\typed\TypedSubscriptionMessage.cs</small>


CTOR



```csharp
public TypedSubscriptionMessage(Type messageType)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>messageType</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage__9g51i3" />  TypedUnSubscriptionMessage Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\typed\TypedSubscriptionMessage.cs</small>


UnSubscription message for [TypedSubscription](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)



```csharp
public class TypedUnSubscriptionMessage : UnSubscriptionMessage
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.actor.actor.exchanges.@base.UnSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.base.unsubscriptionmessage__15gfzkw)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MessageType](#p-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage.messagetype__1i0fwqk) | public | <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TypedUnSubscriptionMessage(Type)](#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage.-ctor_system.type___1lj7u7r) | public | CTOR | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage.messagetype__1i0fwqk" />  TypedUnSubscriptionMessage.MessageType Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedUnSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage__9g51i3)           
Sources: actor\exchanges\typed\TypedSubscriptionMessage.cs</small>


<a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message



```csharp
public Type MessageType { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage.-ctor_system.type___1lj7u7r" />  TypedUnSubscriptionMessage.TypedUnSubscriptionMessage(Type) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedUnSubscriptionMessage](#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage__9g51i3)           
Sources: actor\exchanges\typed\TypedSubscriptionMessage.cs</small>


CTOR



```csharp
public TypedUnSubscriptionMessage(Type messageType)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>messageType</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="n-net.adamec.lib.common.actor.actorsystem__1ihx1md" />  net.adamec.lib.common.actor.actorsystem Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3) | public | Implementation of actor system | 
 | [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe) | internal | Message dispatched used by [ActorSystem](#p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.actorsystem__1osgm3w) | 
 | [ActorSystemOptions](#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j) | public | User defined configuration of [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3) | 
 | [ScheduledMessageInfo](#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5) | internal | Scheduled message definition | 

 


###  Interfaces ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs) | public abstract | The Actor System published interface Provides access to options and system queues, supports the actor (de)registration, dispatcher management (start/stop) as well as message scheduling and synchronous (Request-Reply) messaging. | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3" />  ActorSystem Class ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Sources: actorsystem\ActorSystem.cs</small>


Implementation of actor system



```csharp
public class ActorSystem : BaseDisposable, IActorSystem
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.utils.BaseDisposable](#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>, [net.adamec.lib.common.actor.actorsystem.IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Logger](#f-net.adamec.lib.common.actor.actorsystem.actorsystem.logger__1fhxf7) | protected static |  | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorsByRef](#p-net.adamec.lib.common.actor.actorsystem.actorsystem.actorsbyref__b06x73) | private | Dictionary of actors by actor reference | 
 | [DeadLetters](#p-net.adamec.lib.common.actor.actorsystem.actorsystem.deadletters__1p4w7em) | public | Provides the access to dead letters queue | 
 | [Dispatcher](#p-net.adamec.lib.common.actor.actorsystem.actorsystem.dispatcher__16sohre) | private | Reference to dispatcher used by actor system | 
 | [ErrorMessageQueue](#p-net.adamec.lib.common.actor.actorsystem.actorsystem.errormessagequeue__kecg1b) | public | Provides the access to error messages queue | 
 | [Options](#p-net.adamec.lib.common.actor.actorsystem.actorsystem.options__1qogkkh) | public | Returns the reference to current [ActorSystemOptions](#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorSystem(ActorSystemOptions)](#m-net.adamec.lib.common.actor.actorsystem.actorsystem.-ctor_net.adamec.lib.common.actor.actorsystem.actorsystemoptions___1wtfo99) | public | [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3) constructor | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Ask(IActorRef, object, Type, int, bool)](#m-net.adamec.lib.common.actor.actorsystem.actorsystem.ask_net.adamec.lib.common.actor.actor.iactorref-system.object-system.type-system.int32-system.boolean___sxd0yo) | public | Sends a request <strong>message</strong> to <strong>recipient</strong> and waits for the response of required <strong>responseType</strong> . | 
 | [Ask&lt;T&gt;(IActorRef, object, int, bool)](#m-net.adamec.lib.common.actor.actorsystem.actorsystem.ask--1_net.adamec.lib.common.actor.actor.iactorref-system.object-system.int32-system.boolean___2dxd0s) | public | Sends a request <strong>message</strong> to <strong>recipient</strong> and waits for the response of type  . | 
 | [CancelScheduledMessage(string)](#m-net.adamec.lib.common.actor.actorsystem.actorsystem.cancelscheduledmessage_system.string___1w85qxn) | public | Cancels the scheduled message with given <strong>id</strong> - removes the message from list of the scheduled messages | 
 | [CancelScheduledMessages(IActorRef, Type)](#m-net.adamec.lib.common.actor.actorsystem.actorsystem.cancelscheduledmessages_net.adamec.lib.common.actor.actor.iactorref-system.type___sfq920) | public | Cancels all messages scheduled for <strong>recipient</strong> that are of given <strong>messageType</strong> - removes the messages from list of the scheduled messages | 
 | [DeRegisterActor(IActorRef)](#m-net.adamec.lib.common.actor.actorsystem.actorsystem.deregisteractor_net.adamec.lib.common.actor.actor.iactorref___1x86w27) | public | De-register actor identified by <strong>actorRef</strong> from the actor system If <strong>actorRef</strong> is not found within the actor system, WARN message is logged, but raises no error/exception | 
 | [DisposeManaged()](#m-net.adamec.lib.common.actor.actorsystem.actorsystem.disposemanaged__162jz4w) | protected | Stops and disposes the [Dispatcher](#p-net.adamec.lib.common.actor.actorsystem.actorsystem.dispatcher__16sohre) | 
 | [GetMailboxesWithMessages()](#m-net.adamec.lib.common.actor.actorsystem.actorsystem.getmailboxeswithmessages__1oiw8zq) | internal | Returns the list of the mailboxes (internal actor references) that have at least one message and the actor is not being already processed | 
 | [RegisterActor(IActor, string)](#m-net.adamec.lib.common.actor.actorsystem.actorsystem.registeractor_net.adamec.lib.common.actor.actor.iactor-system.string___o3h1j1) | public | Registers the <strong>actor</strong> to actor system. Name of the actor should be unique, but this is not checked. Each actor must register first to be able to receive the messages within the actor system. | 
 | [ScheduleMessage(IActorRef, IActorRef, DateTime, object)](#m-net.adamec.lib.common.actor.actorsystem.actorsystem.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.datetime-system.object___1mc0hrz) | public | Schedule one-time <strong>message</strong> to be sent to <strong>recipient</strong> at given date and time | 
 | [ScheduleMessage(IActorRef, IActorRef, TimeSpan, object)](#m-net.adamec.lib.common.actor.actorsystem.actorsystem.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.timespan-system.object___kqn59b) | public | Schedule periodic <strong>message</strong> to be sent to <strong>recipient</strong> each <strong>period</strong> . | 
 | [Start()](#m-net.adamec.lib.common.actor.actorsystem.actorsystem.start__zz3cpm) | public | Starts the message dispatcher (started by default within ActorSystem constructor) | 
 | [Stop()](#m-net.adamec.lib.common.actor.actorsystem.actorsystem.stop__v7scp2) | public | Stops the message dispatcher (can be restarted using [Start()](#m-net.adamec.lib.common.actor.actorsystem.actorsystem.start__zz3cpm) method) | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.actorsystem.actorsystem.logger__1fhxf7" />  ActorSystem.Logger Field ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>



```csharp
protected static ILogger Logger
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystem.actorsbyref__b06x73" />  ActorSystem.ActorsByRef Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Dictionary of actors by actor reference



```csharp
private ConcurrentDictionary<net.adamec.lib.common.actor.actor.IActorRef,net.adamec.lib.common.actor.actor.IActor> ActorsByRef { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent.concurrentdictionary-2" target="_blank" >System.Collections.Concurrent.ConcurrentDictionary&lt;net.adamec.lib.common.actor.actor.IActorRef,net.adamec.lib.common.actor.actor.IActor&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystem.deadletters__1p4w7em" />  ActorSystem.DeadLetters Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Provides the access to dead letters queue



```csharp
public IMessageQueue DeadLetters { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.queue.IMessageQueue](#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystem.dispatcher__16sohre" />  ActorSystem.Dispatcher Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Reference to dispatcher used by actor system



```csharp
private ActorSystemDispatcher Dispatcher { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystem.errormessagequeue__kecg1b" />  ActorSystem.ErrorMessageQueue Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Provides the access to error messages queue



```csharp
public IMessageQueue ErrorMessageQueue { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.queue.IMessageQueue](#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystem.options__1qogkkh" />  ActorSystem.Options Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Returns the reference to current [ActorSystemOptions](#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)



```csharp
public ActorSystemOptions Options { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.ActorSystemOptions](#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.-ctor_net.adamec.lib.common.actor.actorsystem.actorsystemoptions___1wtfo99" />  ActorSystem.ActorSystem(ActorSystemOptions) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


[ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3) constructor



```csharp
public ActorSystem(ActorSystemOptions options)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.ActorSystemOptions](#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j) <strong>options</strong></dt><dd>Actor system configuration options</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.ask_net.adamec.lib.common.actor.actor.iactorref-system.object-system.type-system.int32-system.boolean___sxd0yo" />  ActorSystem.Ask(IActorRef, object, Type, int, bool) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Sends a request <strong>message</strong> to <strong>recipient</strong> and waits for the response of required <strong>responseType</strong> .



```csharp
public object Ask(IActorRef recipient, object message, Type responseType, int timeoutMilliseconds, bool throwTimeoutException = false)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Reference to recipient actor</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Request message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>responseType</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message to wait for</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>timeoutMilliseconds</strong></dt><dd>Timeout for the response</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>throwTimeoutException</strong></dt><dd>If true, the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.timeoutexception" target="_blank" >System.TimeoutException</a> is raised, otherwise the default(T) response is returned</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd>The &quot;synchronous&quot; response</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.ask--1_net.adamec.lib.common.actor.actor.iactorref-system.object-system.int32-system.boolean___2dxd0s" />  ActorSystem.Ask&lt;T&gt;(IActorRef, object, int, bool) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Sends a request <strong>message</strong> to <strong>recipient</strong> and waits for the response of type  .



```csharp
public ActorSystem.T Ask<T>(IActorRef recipient, object message, int timeoutMilliseconds, bool throwTimeoutException = false)
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message to wait for</dd></dl>
<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Reference to recipient actor</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Request message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>timeoutMilliseconds</strong></dt><dd>Timeout for the response</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>throwTimeoutException</strong></dt><dd>If true, the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.timeoutexception" target="_blank" >System.TimeoutException</a> is raised, otherwise the default(T) response is returned</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.actor.actorsystem.ActorSystem.T</dt><dd>The &quot;synchronous&quot; response</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.cancelscheduledmessage_system.string___1w85qxn" />  ActorSystem.CancelScheduledMessage(string) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Cancels the scheduled message with given <strong>id</strong> - removes the message from list of the scheduled messages



```csharp
public bool CancelScheduledMessage(string id)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>id</strong></dt><dd>Unique ID of the scheduled message. When the id is not found, it&#39;s just ignored.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True if the message has been found and canceled, false when the message has not been found</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.cancelscheduledmessages_net.adamec.lib.common.actor.actor.iactorref-system.type___sfq920" />  ActorSystem.CancelScheduledMessages(IActorRef, Type) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Cancels all messages scheduled for <strong>recipient</strong> that are of given <strong>messageType</strong> - removes the messages from list of the scheduled messages



```csharp
public bool CancelScheduledMessages(IActorRef recipient, Type messageType)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>The recipient of the scheduled messages to be canceled.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>messageType</strong></dt><dd>The type of the scheduled messages to be canceled.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True if at least one message has been found and canceled, false when none has been found</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.deregisteractor_net.adamec.lib.common.actor.actor.iactorref___1x86w27" />  ActorSystem.DeRegisterActor(IActorRef) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


De-register actor identified by <strong>actorRef</strong> from the actor system If <strong>actorRef</strong> is not found within the actor system, WARN message is logged, but raises no error/exception



```csharp
public void DeRegisterActor(IActorRef actorRef)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to actor to be de-registered</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.disposemanaged__162jz4w" />  ActorSystem.DisposeManaged() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Stops and disposes the [Dispatcher](#p-net.adamec.lib.common.actor.actorsystem.actorsystem.dispatcher__16sohre)



```csharp
protected override void DisposeManaged()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.getmailboxeswithmessages__1oiw8zq" />  ActorSystem.GetMailboxesWithMessages() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Returns the list of the mailboxes (internal actor references) that have at least one message and the actor is not being already processed



```csharp
internal List<net.adamec.lib.common.actor.actor.ActorRefInternal> GetMailboxesWithMessages()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.actor.actor.ActorRefInternal&gt;</a></dt><dd>List of mailboxes(internal actor references) having the messages for processing</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.registeractor_net.adamec.lib.common.actor.actor.iactor-system.string___o3h1j1" />  ActorSystem.RegisterActor(IActor, string) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Registers the <strong>actor</strong> to actor system. Name of the actor should be unique, but this is not checked. Each actor must register first to be able to receive the messages within the actor system.



```csharp
public IActorRef RegisterActor(IActor actor, string name)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActor](#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi) <strong>actor</strong></dt><dd>Actor to be registered</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the actor. Name of the actor should be unique, but this is not checked. Name is mandatory and can&#39;t be empty</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd>Actor reference to the registered actor</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.datetime-system.object___1mc0hrz" />  ActorSystem.ScheduleMessage(IActorRef, IActorRef, DateTime, object) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Schedule one-time <strong>message</strong> to be sent to <strong>recipient</strong> at given date and time



```csharp
public string ScheduleMessage(IActorRef sender, IActorRef recipient, DateTime nextFire, object message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>Optional information about the sender, usually used by <strong>recipient</strong> to respond to the <strong>message</strong></dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Recipient of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.datetime" target="_blank" >DateTime</a> <strong>nextFire</strong></dt><dd>Date and time after which the message is enqueued to the <strong>recipient</strong> queue</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Message to be sent to the <strong>recipient</strong></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Unique ID of scheduled message</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.timespan-system.object___kqn59b" />  ActorSystem.ScheduleMessage(IActorRef, IActorRef, TimeSpan, object) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Schedule periodic <strong>message</strong> to be sent to <strong>recipient</strong> each <strong>period</strong> .



```csharp
public string ScheduleMessage(IActorRef sender, IActorRef recipient, TimeSpan period, object message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>Optional information about the sender, usually used by <strong>recipient</strong> to respond to the <strong>message</strong></dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Recipient of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.timespan" target="_blank" >System.TimeSpan</a> <strong>period</strong></dt><dd>Period after which the message is periodically enqueued to the <strong>recipient</strong> queue</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Message to be periodically sent to the <strong>recipient</strong></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Unique ID of scheduled message</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.start__zz3cpm" />  ActorSystem.Start() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Starts the message dispatcher (started by default within ActorSystem constructor)



```csharp
public void Start()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.stop__v7scp2" />  ActorSystem.Stop() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Stops the message dispatcher (can be restarted using [Start()](#m-net.adamec.lib.common.actor.actorsystem.actorsystem.start__zz3cpm) method)



```csharp
public void Stop()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe" />  ActorSystemDispatcher Class ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Message dispatched used by [ActorSystem](#p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.actorsystem__1osgm3w)



```csharp
internal class ActorSystemDispatcher : BaseDisposable
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.utils.BaseDisposable](#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [isActive](#f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.isactive__1g6w74o) | private |  | 
 | [Logger](#f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.logger__1opp49m) | protected static |  | 
 | [MessageLogger](#f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.messagelogger__9fz30j) | protected static | Message logger | 
 | [scheduledMessagesLock](#f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.scheduledmessageslock__19elh26) | private |  | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorSystem](#p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.actorsystem__1osgm3w) | private |  | 
 | [ExecutorThread](#p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.executorthread__1a9snen) | private | Dispatcher executor thread | 
 | [IsActive](#p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.isactive__9h4ytm) | public | Flag whether the dispatcher is active (dispatching messages) | 
 | [Options](#p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.options__glvhoa) | protected | Actor System options | 
 | [ScheduledMessages](#p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.scheduledmessages__61sfpr) | private |  | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorSystemDispatcher(ActorSystem)](#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.-ctor_net.adamec.lib.common.actor.actorsystem.actorsystem___bl3uhi) | public | Initialize dispatcher | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CancelScheduledMessage(string)](#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.cancelscheduledmessage_system.string___1r5af14) | internal | Cancels the scheduled message with given <strong>id</strong> - removes the message from list of the scheduled messages | 
 | [CancelScheduledMessages(IActorRef, Type)](#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.cancelscheduledmessages_net.adamec.lib.common.actor.actor.iactorref-system.type___6bdh5j) | internal | Cancels all messages scheduled for <strong>recipient</strong> that are of given <strong>messageType</strong> - removes the messages from list of the scheduled messages | 
 | [DisposeManaged()](#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.disposemanaged__121xst9) | protected | Stops the dispatched when disposing | 
 | [Execute(object)](#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.execute_system.object___q5nu8z) | private | Main dispatcher loop (runs within the [ExecutorThread](#p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.executorthread__1a9snen) ) The loop is active while [isActive](#f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.isactive__1g6w74o) is set to true, so setting [isActive](#f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.isactive__1g6w74o) to false forces the loop to exit Each run of the loop enqueue the due scheduled messages (if any) and process mailboxes (actors) with any pending messages. Actor (actor reference) is locked for processing and the task is scheduled in thread pool to process the actor&#39;s queue. The actor remains locked until the task is not finished, so it&#39;s not picked up by executor again during the processing | 
 | [GetScheduledMessagesDue()](#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.getscheduledmessagesdue__5eu7es) | private | Gets the list of scheduled messages that should be enqueued (are due) When the scheduled message is periodic, the next fire time is calculated and a new instance of scheduled message is added to to schedule | 
 | [ProcessActorQueue(object)](#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.processactorqueue_system.object___1ifalnd) | private | Main actor queue processor - scheduled by executor within the thread pool for each eligible actor (actor ref) Processes the batch of the messages for given actor. The messages are being processed sequentially in FIFO order within the loop with following constraints - there are still messages in actor&#39;s queue - actor can receive the messages - the batch size (number of messages for single actor processed in one cycle) has not been reached - dispatcher is not stopped The messages are sent to current actor receive target | 
 | [ScheduleMessage(IActorRef, IActorRef, DateTime, object)](#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.datetime-system.object___6k32uw) | internal | Schedule one-time <strong>message</strong> to be sent to <strong>recipient</strong> at given date and time Creates the [ScheduledMessageInfo](#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5) instance based on the parameters and let it add to the internal list of the scheduled messages | 
 | [ScheduleMessage(IActorRef, IActorRef, TimeSpan, object)](#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.timespan-system.object___vt99rw) | internal | Schedule periodic <strong>message</strong> to be sent to <strong>recipient</strong> each <strong>period</strong> . Creates the [ScheduledMessageInfo](#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5) instance based on the parameters and let it add to the internal list of the scheduled messages | 
 | [ScheduleMessage(ScheduledMessageInfo)](#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.schedulemessage_net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo___1xwfair) | private | Get&#39;s the given [ScheduledMessageInfo](#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5) and adds it to internal list of scheduled messages. | 
 | [Start()](#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.start__2g0p6j) | public | Starts the dispatcher Creates the executor thread and starts processing the messages | 
 | [Stop()](#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.stop__8jn5gr) | public | Stops the dispatcher Finish current processing and &quot;close&quot; the executor thread | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.isactive__1g6w74o" />  ActorSystemDispatcher.isActive Field ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>



```csharp
private volatile bool isActive
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.logger__1opp49m" />  ActorSystemDispatcher.Logger Field ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>



```csharp
protected static ILogger Logger
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.messagelogger__9fz30j" />  ActorSystemDispatcher.MessageLogger Field ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Message logger



```csharp
protected static ILogger MessageLogger
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.scheduledmessageslock__19elh26" />  ActorSystemDispatcher.scheduledMessagesLock Field ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>



```csharp
private readonly object scheduledMessagesLock
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.actorsystem__1osgm3w" />  ActorSystemDispatcher.ActorSystem Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>



```csharp
private ActorSystem ActorSystem { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.executorthread__1a9snen" />  ActorSystemDispatcher.ExecutorThread Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Dispatcher executor thread



```csharp
private Thread ExecutorThread { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.thread" target="_blank" >System.Threading.Thread</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.isactive__9h4ytm" />  ActorSystemDispatcher.IsActive Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Flag whether the dispatcher is active (dispatching messages)



```csharp
public bool IsActive { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.options__glvhoa" />  ActorSystemDispatcher.Options Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Actor System options



```csharp
protected ActorSystemOptions Options { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.ActorSystemOptions](#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.scheduledmessages__61sfpr" />  ActorSystemDispatcher.ScheduledMessages Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>



```csharp
private List<net.adamec.lib.common.actor.actorsystem.ScheduledMessageInfo> ScheduledMessages { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.actor.actorsystem.ScheduledMessageInfo&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.-ctor_net.adamec.lib.common.actor.actorsystem.actorsystem___bl3uhi" />  ActorSystemDispatcher.ActorSystemDispatcher(ActorSystem) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Initialize dispatcher



```csharp
public ActorSystemDispatcher(ActorSystem actorSystem)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3) <strong>actorSystem</strong></dt><dd>Actor System the dispatcher belongs to</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.cancelscheduledmessage_system.string___1r5af14" />  ActorSystemDispatcher.CancelScheduledMessage(string) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Cancels the scheduled message with given <strong>id</strong> - removes the message from list of the scheduled messages



```csharp
internal bool CancelScheduledMessage(string id)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>id</strong></dt><dd>Unique ID of the scheduled message. When the id is not found, it&#39;s just ignored.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True if the message has been found and canceled, false when the message has not been found</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.cancelscheduledmessages_net.adamec.lib.common.actor.actor.iactorref-system.type___6bdh5j" />  ActorSystemDispatcher.CancelScheduledMessages(IActorRef, Type) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Cancels all messages scheduled for <strong>recipient</strong> that are of given <strong>messageType</strong> - removes the messages from list of the scheduled messages



```csharp
internal bool CancelScheduledMessages(IActorRef recipient, Type messageType)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>The recipient of the scheduled messages to be canceled.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>messageType</strong></dt><dd>The type of the scheduled messages to be canceled.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True if at least one message has been found and canceled, false when none has been found</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.disposemanaged__121xst9" />  ActorSystemDispatcher.DisposeManaged() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Stops the dispatched when disposing



```csharp
protected override void DisposeManaged()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.execute_system.object___q5nu8z" />  ActorSystemDispatcher.Execute(object) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Main dispatcher loop (runs within the [ExecutorThread](#p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.executorthread__1a9snen) ) The loop is active while [isActive](#f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.isactive__1g6w74o) is set to true, so setting [isActive](#f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.isactive__1g6w74o) to false forces the loop to exit Each run of the loop enqueue the due scheduled messages (if any) and process mailboxes (actors) with any pending messages. Actor (actor reference) is locked for processing and the task is scheduled in thread pool to process the actor&#39;s queue. The actor remains locked until the task is not finished, so it&#39;s not picked up by executor again during the processing



```csharp
private void Execute(object actorSystemObj)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>actorSystemObj</strong></dt><dd>Actor System</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.getscheduledmessagesdue__5eu7es" />  ActorSystemDispatcher.GetScheduledMessagesDue() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Gets the list of scheduled messages that should be enqueued (are due) When the scheduled message is periodic, the next fire time is calculated and a new instance of scheduled message is added to to schedule



```csharp
private IEnumerable<net.adamec.lib.common.actor.actorsystem.ScheduledMessageInfo> GetScheduledMessagesDue()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;net.adamec.lib.common.actor.actorsystem.ScheduledMessageInfo&gt;</a></dt><dd>The list of scheduled messages that to be enqueued</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.processactorqueue_system.object___1ifalnd" />  ActorSystemDispatcher.ProcessActorQueue(object) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Main actor queue processor - scheduled by executor within the thread pool for each eligible actor (actor ref) Processes the batch of the messages for given actor. The messages are being processed sequentially in FIFO order within the loop with following constraints - there are still messages in actor&#39;s queue - actor can receive the messages - the batch size (number of messages for single actor processed in one cycle) has not been reached - dispatcher is not stopped The messages are sent to current actor receive target



```csharp
private void ProcessActorQueue(object actorRef)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>actorRef</strong></dt><dd>Actor to process</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.datetime-system.object___6k32uw" />  ActorSystemDispatcher.ScheduleMessage(IActorRef, IActorRef, DateTime, object) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Schedule one-time <strong>message</strong> to be sent to <strong>recipient</strong> at given date and time Creates the [ScheduledMessageInfo](#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5) instance based on the parameters and let it add to the internal list of the scheduled messages



```csharp
internal string ScheduleMessage(IActorRef sender, IActorRef recipient, DateTime nextFire, object message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>Optional information about the sender, usually used by <strong>recipient</strong> to respond to the <strong>message</strong></dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Recipient of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.datetime" target="_blank" >DateTime</a> <strong>nextFire</strong></dt><dd>Date and time after which the message is enqueued to the <strong>recipient</strong> queue</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Message to be sent to the <strong>recipient</strong></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Unique ID of scheduled message</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.timespan-system.object___vt99rw" />  ActorSystemDispatcher.ScheduleMessage(IActorRef, IActorRef, TimeSpan, object) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Schedule periodic <strong>message</strong> to be sent to <strong>recipient</strong> each <strong>period</strong> . Creates the [ScheduledMessageInfo](#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5) instance based on the parameters and let it add to the internal list of the scheduled messages



```csharp
internal string ScheduleMessage(IActorRef sender, IActorRef recipient, TimeSpan period, object message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>Optional information about the sender, usually used by <strong>recipient</strong> to respond to the <strong>message</strong></dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Recipient of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.timespan" target="_blank" >System.TimeSpan</a> <strong>period</strong></dt><dd>Period after which the message is enqueued to the <strong>recipient</strong> queue</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Message to be periodically sent to the <strong>recipient</strong></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Unique ID of scheduled message</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.schedulemessage_net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo___1xwfair" />  ActorSystemDispatcher.ScheduleMessage(ScheduledMessageInfo) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Get&#39;s the given [ScheduledMessageInfo](#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5) and adds it to internal list of scheduled messages.



```csharp
private void ScheduleMessage(ScheduledMessageInfo msg)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.ScheduledMessageInfo](#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5) <strong>msg</strong></dt><dd>Scheduled message description to be added to the internal list of scheduled messages.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.start__2g0p6j" />  ActorSystemDispatcher.Start() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Starts the dispatcher Creates the executor thread and starts processing the messages



```csharp
public void Start()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.stop__8jn5gr" />  ActorSystemDispatcher.Stop() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Stops the dispatcher Finish current processing and &quot;close&quot; the executor thread



```csharp
public void Stop()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j" />  ActorSystemOptions Class ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Sources: actorsystem\ActorSystemOptions.cs</small>


User defined configuration of [ActorSystem](#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)



```csharp
public class ActorSystemOptions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Default](#p-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.default__12pheto) | public static | Returns the default [ActorSystemOptions](#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j) | 
 | [LogDispatchMessages](#p-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.logdispatchmessages__b8w2y1) | public | If enabled, logs each message before dispatched to actor with DEBUG level (default false) | 
 | [LogEnqueuedMessages](#p-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.logenqueuedmessages__1on1j1f) | public | If enabled, logs each enqueued message with DEBUG level (default false) | 
 | [LogNotHandledMessages](#p-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.lognothandledmessages__982jd6) | public | If enabled, logs each not handled message with WARN level (default false) | 
 | [MaxDispatchMessagesInBatch](#p-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.maxdispatchmessagesinbatch__47yvmi) | public | Defines the maximum number of messages send for processing to single actor during one cycle of ActorDispatcher executor  (default 10) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorSystemOptions()](#m-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.-cctor__coeb0w) | private static | Static CTOR - initialize default options instance | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.default__12pheto" />  ActorSystemOptions.Default Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemOptions](#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)           
Sources: actorsystem\ActorSystemOptions.cs</small>


Returns the default [ActorSystemOptions](#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)



```csharp
public static ActorSystemOptions Default { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.ActorSystemOptions](#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.logdispatchmessages__b8w2y1" />  ActorSystemOptions.LogDispatchMessages Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemOptions](#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)           
Sources: actorsystem\ActorSystemOptions.cs</small>


If enabled, logs each message before dispatched to actor with DEBUG level (default false)



```csharp
public bool LogDispatchMessages { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.logenqueuedmessages__1on1j1f" />  ActorSystemOptions.LogEnqueuedMessages Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemOptions](#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)           
Sources: actorsystem\ActorSystemOptions.cs</small>


If enabled, logs each enqueued message with DEBUG level (default false)



```csharp
public bool LogEnqueuedMessages { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.lognothandledmessages__982jd6" />  ActorSystemOptions.LogNotHandledMessages Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemOptions](#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)           
Sources: actorsystem\ActorSystemOptions.cs</small>


If enabled, logs each not handled message with WARN level (default false)



```csharp
public bool LogNotHandledMessages { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.maxdispatchmessagesinbatch__47yvmi" />  ActorSystemOptions.MaxDispatchMessagesInBatch Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemOptions](#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)           
Sources: actorsystem\ActorSystemOptions.cs</small>


Defines the maximum number of messages send for processing to single actor during one cycle of ActorDispatcher executor  (default 10)



```csharp
public int MaxDispatchMessagesInBatch { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.-cctor__coeb0w" />  ActorSystemOptions.ActorSystemOptions() Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemOptions](#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)           
Sources: actorsystem\ActorSystemOptions.cs</small>


Static CTOR - initialize default options instance



```csharp
private static ActorSystemOptions()
```

Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5" />  ScheduledMessageInfo Class ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Sources: actorsystem\ScheduledMessageInfo.cs</small>


Scheduled message definition



```csharp
internal class ScheduledMessageInfo
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Id](#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.id__d1ho0y) | internal | Unique ID of scheduled message | 
 | [Message](#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.message__8wrme2) | internal | Message to be (periodically) sent to the [Recipient](#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.recipient__9cyy92) | 
 | [NextFire](#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.nextfire__16ekkf2) | internal | Date and Time after which the message is enqueued to the [Recipient](#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.recipient__9cyy92) queue | 
 | [Period](#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.period__v8c71e) | internal | Period after which the message is periodically enqueued to the [Recipient](#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.recipient__9cyy92) queue. Null for non-periodic messages | 
 | [Recipient](#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.recipient__9cyy92) | internal | Recipient of the message | 
 | [Sender](#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.sender__1m7ejeu) | internal | Optional information about the sender, usually used by [Recipient](#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.recipient__9cyy92) to respond to the [Message](#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.message__8wrme2) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ScheduledMessageInfo(IActorRef, IActorRef, DateTime, object)](#m-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.-ctor_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.datetime-system.object___d10rbc) | internal | CTOR for one-time scheduled message info | 
 | [ScheduledMessageInfo(IActorRef, IActorRef, TimeSpan, object)](#m-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.-ctor_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.timespan-system.object___w2q5fc) | internal | CTOR for periodic scheduled message info | 
 | [ScheduledMessageInfo(ScheduledMessageInfo)](#m-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.-ctor_net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo___1cbqekh) | internal | CTOR for the new instance of scheduled message definition for existing periodic scheduled message Used when creating the definition of each new run of the periodic schedule. Copies the information from current definition and preservers the ID | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.id__d1ho0y" />  ScheduledMessageInfo.Id Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ScheduledMessageInfo](#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5)           
Sources: actorsystem\ScheduledMessageInfo.cs</small>


Unique ID of scheduled message



```csharp
internal string Id { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.message__8wrme2" />  ScheduledMessageInfo.Message Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ScheduledMessageInfo](#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5)           
Sources: actorsystem\ScheduledMessageInfo.cs</small>


Message to be (periodically) sent to the [Recipient](#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.recipient__9cyy92)



```csharp
internal object Message { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.nextfire__16ekkf2" />  ScheduledMessageInfo.NextFire Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ScheduledMessageInfo](#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5)           
Sources: actorsystem\ScheduledMessageInfo.cs</small>


Date and Time after which the message is enqueued to the [Recipient](#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.recipient__9cyy92) queue



```csharp
internal DateTime NextFire { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.datetime" target="_blank" >DateTime</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.period__v8c71e" />  ScheduledMessageInfo.Period Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ScheduledMessageInfo](#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5)           
Sources: actorsystem\ScheduledMessageInfo.cs</small>


Period after which the message is periodically enqueued to the [Recipient](#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.recipient__9cyy92) queue. Null for non-periodic messages



```csharp
internal System.TimeSpan? Period { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1" target="_blank" >System.TimeSpan?</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.recipient__9cyy92" />  ScheduledMessageInfo.Recipient Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ScheduledMessageInfo](#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5)           
Sources: actorsystem\ScheduledMessageInfo.cs</small>


Recipient of the message



```csharp
internal IActorRef Recipient { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.sender__1m7ejeu" />  ScheduledMessageInfo.Sender Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ScheduledMessageInfo](#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5)           
Sources: actorsystem\ScheduledMessageInfo.cs</small>


Optional information about the sender, usually used by [Recipient](#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.recipient__9cyy92) to respond to the [Message](#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.message__8wrme2)



```csharp
internal IActorRef Sender { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.-ctor_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.datetime-system.object___d10rbc" />  ScheduledMessageInfo.ScheduledMessageInfo(IActorRef, IActorRef, DateTime, object) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ScheduledMessageInfo](#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5)           
Sources: actorsystem\ScheduledMessageInfo.cs</small>


CTOR for one-time scheduled message info



```csharp
internal ScheduledMessageInfo(IActorRef sender, IActorRef recipient, DateTime nextFire, object message)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>Optional information about the sender, usually used by <strong>recipient</strong> to respond to the <strong>message</strong></dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Recipient of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.datetime" target="_blank" >DateTime</a> <strong>nextFire</strong></dt><dd>Date and time after which the message is enqueued to the <strong>recipient</strong> queue</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Message to be sent to the <strong>recipient</strong></dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.-ctor_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.timespan-system.object___w2q5fc" />  ScheduledMessageInfo.ScheduledMessageInfo(IActorRef, IActorRef, TimeSpan, object) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ScheduledMessageInfo](#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5)           
Sources: actorsystem\ScheduledMessageInfo.cs</small>


CTOR for periodic scheduled message info



```csharp
internal ScheduledMessageInfo(IActorRef sender, IActorRef recipient, TimeSpan period, object message)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>Optional information about the sender, usually used by <strong>recipient</strong> to respond to the <strong>message</strong></dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Recipient of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.timespan" target="_blank" >System.TimeSpan</a> <strong>period</strong></dt><dd>Period after which the message is enqueued to the <strong>recipient</strong> queue</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Message to be periodically sent to the <strong>recipient</strong></dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.-ctor_net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo___1cbqekh" />  ScheduledMessageInfo.ScheduledMessageInfo(ScheduledMessageInfo) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ScheduledMessageInfo](#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5)           
Sources: actorsystem\ScheduledMessageInfo.cs</small>


CTOR for the new instance of scheduled message definition for existing periodic scheduled message Used when creating the definition of each new run of the periodic schedule. Copies the information from current definition and preservers the ID



```csharp
internal ScheduledMessageInfo(ScheduledMessageInfo existingPeriodicScheduledMessageInfo)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.ScheduledMessageInfo](#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5) <strong>existingPeriodicScheduledMessageInfo</strong></dt><dd></dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs" />  IActorSystem Interface ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Sources: actorsystem\IActorSystem.cs</small>


The Actor System published interface Provides access to options and system queues, supports the actor (de)registration, dispatcher management (start/stop) as well as message scheduling and synchronous (Request-Reply) messaging.



```csharp
public interface IActorSystem
```

###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DeadLetters](#p-net.adamec.lib.common.actor.actorsystem.iactorsystem.deadletters__82oxzl) | public abstract | Provides the access to dead letters queue | 
 | [ErrorMessageQueue](#p-net.adamec.lib.common.actor.actorsystem.iactorsystem.errormessagequeue__v9i6fy) | public abstract | Provides the access to error messages queue | 
 | [Options](#p-net.adamec.lib.common.actor.actorsystem.iactorsystem.options__logleg) | public abstract | Returns the reference to current [ActorSystemOptions](#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Ask(IActorRef, object, Type, int, bool)](#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.ask_net.adamec.lib.common.actor.actor.iactorref-system.object-system.type-system.int32-system.boolean___14ecl67) | public abstract | Sends a request <strong>message</strong> to <strong>recipient</strong> and waits for the response of required <strong>responseType</strong> . | 
 | [Ask&lt;T&gt;(IActorRef, object, int, bool)](#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.ask--1_net.adamec.lib.common.actor.actor.iactorref-system.object-system.int32-system.boolean___1d7ni9h) | public abstract | Sends a request <strong>message</strong> to <strong>recipient</strong> and waits for the response of type  . | 
 | [CancelScheduledMessage(string)](#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.cancelscheduledmessage_system.string___bluqps) | public abstract | Cancels the scheduled message with given <strong>id</strong> - removes the message from list of the scheduled messages | 
 | [CancelScheduledMessages(IActorRef, Type)](#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.cancelscheduledmessages_net.adamec.lib.common.actor.actor.iactorref-system.type___c89uf5) | public abstract | Cancels all messages scheduled for <strong>recipient</strong> that are of given <strong>messageType</strong> - removes the messages from list of the scheduled messages | 
 | [DeRegisterActor(IActorRef)](#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.deregisteractor_net.adamec.lib.common.actor.actor.iactorref___102bphm) | public abstract | De-register actor identified by <strong>actorRef</strong> from the actor system If <strong>actorRef</strong> is not found within the actor system, WARN message is logged, but raises no error/exception | 
 | [RegisterActor(IActor, string)](#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.registeractor_net.adamec.lib.common.actor.actor.iactor-system.string___c4sh8g) | public abstract | Registers the <strong>actor</strong> to actor system. Name of the actor should be unique, but this is not checked. Each actor must register first to be able to receive the messages within the actor system. | 
 | [ScheduleMessage(IActorRef, IActorRef, DateTime, object)](#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.datetime-system.object___1o3fnac) | public abstract | Schedule one-time <strong>message</strong> to be sent to <strong>recipient</strong> at given date and time | 
 | [ScheduleMessage(IActorRef, IActorRef, TimeSpan, object)](#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.timespan-system.object___og1m84) | public abstract | Schedule periodic <strong>message</strong> to be sent to <strong>recipient</strong> each <strong>period</strong> . | 
 | [Start()](#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.start__clajz5) | public abstract | Starts the message dispatcher (started by default within ActorSystem constructor) | 
 | [Stop()](#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.stop__dly8m5) | public abstract | Stops the message dispatcher (can be restarted using [Start()](#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.start__clajz5) method) | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.iactorsystem.deadletters__82oxzl" />  IActorSystem.DeadLetters Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Provides the access to dead letters queue



```csharp
public abstract IMessageQueue DeadLetters { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.queue.IMessageQueue](#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.iactorsystem.errormessagequeue__v9i6fy" />  IActorSystem.ErrorMessageQueue Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Provides the access to error messages queue



```csharp
public abstract IMessageQueue ErrorMessageQueue { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.queue.IMessageQueue](#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.iactorsystem.options__logleg" />  IActorSystem.Options Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Returns the reference to current [ActorSystemOptions](#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)



```csharp
public abstract ActorSystemOptions Options { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.ActorSystemOptions](#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.iactorsystem.ask_net.adamec.lib.common.actor.actor.iactorref-system.object-system.type-system.int32-system.boolean___14ecl67" />  IActorSystem.Ask(IActorRef, object, Type, int, bool) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Sends a request <strong>message</strong> to <strong>recipient</strong> and waits for the response of required <strong>responseType</strong> .



```csharp
public abstract object Ask(IActorRef recipient, object message, Type responseType, int timeoutMilliseconds, bool throwTimeoutException = false)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Reference to recipient actor</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Request message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>responseType</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message to wait for</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>timeoutMilliseconds</strong></dt><dd>Timeout for the response</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>throwTimeoutException</strong></dt><dd>If true, the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.timeoutexception" target="_blank" >System.TimeoutException</a> is raised, otherwise the default(T) response is returned</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd>The &quot;synchronous&quot; response</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.iactorsystem.ask--1_net.adamec.lib.common.actor.actor.iactorref-system.object-system.int32-system.boolean___1d7ni9h" />  IActorSystem.Ask&lt;T&gt;(IActorRef, object, int, bool) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Sends a request <strong>message</strong> to <strong>recipient</strong> and waits for the response of type  .



```csharp
public abstract IActorSystem.T Ask<T>(IActorRef recipient, object message, int timeoutMilliseconds, bool throwTimeoutException = false)
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message to wait for</dd></dl>
<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Reference to recipient actor</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Request message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>timeoutMilliseconds</strong></dt><dd>Timeout for the response</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>throwTimeoutException</strong></dt><dd>If true, the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.timeoutexception" target="_blank" >System.TimeoutException</a> is raised, otherwise the default(T) response is returned</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.actor.actorsystem.IActorSystem.T</dt><dd>The &quot;synchronous&quot; response</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.iactorsystem.cancelscheduledmessage_system.string___bluqps" />  IActorSystem.CancelScheduledMessage(string) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Cancels the scheduled message with given <strong>id</strong> - removes the message from list of the scheduled messages



```csharp
public abstract bool CancelScheduledMessage(string id)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>id</strong></dt><dd>Unique ID of the scheduled message. When the id is not found, it&#39;s just ignored.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True if the message has been found and canceled, false when the message has not been found</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.iactorsystem.cancelscheduledmessages_net.adamec.lib.common.actor.actor.iactorref-system.type___c89uf5" />  IActorSystem.CancelScheduledMessages(IActorRef, Type) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Cancels all messages scheduled for <strong>recipient</strong> that are of given <strong>messageType</strong> - removes the messages from list of the scheduled messages



```csharp
public abstract bool CancelScheduledMessages(IActorRef recipient, Type messageType)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>The recipient of the scheduled messages to be canceled.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>messageType</strong></dt><dd>The type of the scheduled messages to be canceled.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True if at least one message has been found and canceled, false when none has been found</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.iactorsystem.deregisteractor_net.adamec.lib.common.actor.actor.iactorref___102bphm" />  IActorSystem.DeRegisterActor(IActorRef) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


De-register actor identified by <strong>actorRef</strong> from the actor system If <strong>actorRef</strong> is not found within the actor system, WARN message is logged, but raises no error/exception



```csharp
public abstract void DeRegisterActor(IActorRef actorRef)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to actor to be de-registered</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.iactorsystem.registeractor_net.adamec.lib.common.actor.actor.iactor-system.string___c4sh8g" />  IActorSystem.RegisterActor(IActor, string) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Registers the <strong>actor</strong> to actor system. Name of the actor should be unique, but this is not checked. Each actor must register first to be able to receive the messages within the actor system.



```csharp
public abstract IActorRef RegisterActor(IActor actor, string name)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActor](#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi) <strong>actor</strong></dt><dd>Actor to be registered</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the actor. Name of the actor should be unique, but this is not checked. Name is mandatory and can&#39;t be empty</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd>Actor reference to the registered actor</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.iactorsystem.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.datetime-system.object___1o3fnac" />  IActorSystem.ScheduleMessage(IActorRef, IActorRef, DateTime, object) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Schedule one-time <strong>message</strong> to be sent to <strong>recipient</strong> at given date and time



```csharp
public abstract string ScheduleMessage(IActorRef sender, IActorRef recipient, DateTime nextFire, object message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>Optional information about the sender, usually used by <strong>recipient</strong> to respond to the <strong>message</strong></dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Recipient of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.datetime" target="_blank" >DateTime</a> <strong>nextFire</strong></dt><dd>Date and time after which the message is enqueued to the <strong>recipient</strong> queue</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Message to be sent to the <strong>recipient</strong></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Unique ID of scheduled message</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.iactorsystem.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.timespan-system.object___og1m84" />  IActorSystem.ScheduleMessage(IActorRef, IActorRef, TimeSpan, object) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Schedule periodic <strong>message</strong> to be sent to <strong>recipient</strong> each <strong>period</strong> .



```csharp
public abstract string ScheduleMessage(IActorRef sender, IActorRef recipient, TimeSpan period, object message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>Optional information about the sender, usually used by <strong>recipient</strong> to respond to the <strong>message</strong></dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Recipient of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.timespan" target="_blank" >System.TimeSpan</a> <strong>period</strong></dt><dd>Period after which the message is periodically enqueued to the <strong>recipient</strong> queue</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Message to be periodically sent to the <strong>recipient</strong></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Unique ID of scheduled message</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.iactorsystem.start__clajz5" />  IActorSystem.Start() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Starts the message dispatcher (started by default within ActorSystem constructor)



```csharp
public abstract void Start()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.iactorsystem.stop__dly8m5" />  IActorSystem.Stop() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Stops the message dispatcher (can be restarted using [Start()](#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.start__clajz5) method)



```csharp
public abstract void Stop()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="n-net.adamec.lib.common.actor.message__m00bpk" />  net.adamec.lib.common.actor.message Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) | public | Message envelope | 
 | [ErrorMessage](#t-net.adamec.lib.common.actor.message.errormessage__1gj1wb) | public | Specialized [Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) for messages in [ErrorMessageQueue](#p-net.adamec.lib.common.actor.actorsystem.iactorsystem.errormessagequeue__v9i6fy) | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.message.envelope__5oxc3s" />  Envelope Class ##
<small>Namespace: [net.adamec.lib.common.actor.message](#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Sources: message\Envelope.cs</small>


Message envelope



```csharp
public class Envelope
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CorrelationId](#p-net.adamec.lib.common.actor.message.envelope.correlationid__1b0zym1) | public | Correlation ID used to identify the message (envelope) | 
 | [CreatedOn](#p-net.adamec.lib.common.actor.message.envelope.createdon__1kpt9ip) | public | Timestamp when the envelope has been created | 
 | [Message](#p-net.adamec.lib.common.actor.message.envelope.message__j08krj) | public | Message | 
 | [Recipient](#p-net.adamec.lib.common.actor.message.envelope.recipient__1fcsz7b) | public | Message recipient | 
 | [RoutingKey](#p-net.adamec.lib.common.actor.message.envelope.routingkey__1t0mr4v) | public | Optional routing key that can be used by actors (as &quot;a parameter outside the message&quot;) | 
 | [Sender](#p-net.adamec.lib.common.actor.message.envelope.sender__154pdc7) | public | Message sender | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Envelope(Envelope)](#m-net.adamec.lib.common.actor.message.envelope.-ctor_net.adamec.lib.common.actor.message.envelope___1a00gop) | protected | CTOR - creates the exact copy of <strong>original</strong> message including the [CorrelationId](#p-net.adamec.lib.common.actor.message.envelope.correlationid__1b0zym1) and [CreatedOn](#p-net.adamec.lib.common.actor.message.envelope.createdon__1kpt9ip) timestamp | 
 | [Envelope(IActorRef, IActorRef, object, string)](#m-net.adamec.lib.common.actor.message.envelope.-ctor_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.object-system.string___k4a7n5) | internal | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ForwardTo(IActorRef)](#m-net.adamec.lib.common.actor.message.envelope.forwardto_net.adamec.lib.common.actor.actor.iactorref___qf18qp) | public | Forwards the message to another recipient. Keeps the original message, sender and routing key. | 
 | [ForwardTo(IActorRef, string)](#m-net.adamec.lib.common.actor.message.envelope.forwardto_net.adamec.lib.common.actor.actor.iactorref-system.string___1pf93xv) | public | Forwards the message to another recipient. Keeps the original message and sender, but cleans/set the [RoutingKey](#p-net.adamec.lib.common.actor.message.envelope.routingkey__1t0mr4v) based on <strong>routingKey</strong> parameter. | 
 | [ToString()](#m-net.adamec.lib.common.actor.message.envelope.tostring__3dg837) | public |  | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.message.envelope.correlationid__1b0zym1" />  Envelope.CorrelationId Property ##
<small>Namespace: [net.adamec.lib.common.actor.message](#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>


Correlation ID used to identify the message (envelope)



```csharp
public string CorrelationId { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.message.envelope.createdon__1kpt9ip" />  Envelope.CreatedOn Property ##
<small>Namespace: [net.adamec.lib.common.actor.message](#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>


Timestamp when the envelope has been created



```csharp
public DateTime CreatedOn { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.datetime" target="_blank" >DateTime</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.message.envelope.message__j08krj" />  Envelope.Message Property ##
<small>Namespace: [net.adamec.lib.common.actor.message](#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>


Message



```csharp
public object Message { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.message.envelope.recipient__1fcsz7b" />  Envelope.Recipient Property ##
<small>Namespace: [net.adamec.lib.common.actor.message](#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>


Message recipient



```csharp
public IActorRef Recipient { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.message.envelope.routingkey__1t0mr4v" />  Envelope.RoutingKey Property ##
<small>Namespace: [net.adamec.lib.common.actor.message](#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>


Optional routing key that can be used by actors (as &quot;a parameter outside the message&quot;)



```csharp
public string RoutingKey { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.message.envelope.sender__154pdc7" />  Envelope.Sender Property ##
<small>Namespace: [net.adamec.lib.common.actor.message](#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>


Message sender



```csharp
public IActorRef Sender { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.message.envelope.-ctor_net.adamec.lib.common.actor.message.envelope___1a00gop" />  Envelope.Envelope(Envelope) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.message](#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>


CTOR - creates the exact copy of <strong>original</strong> message including the [CorrelationId](#p-net.adamec.lib.common.actor.message.envelope.correlationid__1b0zym1) and [CreatedOn](#p-net.adamec.lib.common.actor.message.envelope.createdon__1kpt9ip) timestamp



```csharp
protected Envelope(Envelope original)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>original</strong></dt><dd></dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.message.envelope.-ctor_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.object-system.string___k4a7n5" />  Envelope.Envelope(IActorRef, IActorRef, object, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.message](#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>


CTOR



```csharp
internal Envelope(IActorRef sender, IActorRef recipient, object message, string routingKey = null)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>Message sender</dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Message recipient</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Message (payload)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>routingKey</strong></dt><dd>Optional routing key that can be used by actors (as &quot;a parameter outside the message&quot;)</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.message.envelope.forwardto_net.adamec.lib.common.actor.actor.iactorref___qf18qp" />  Envelope.ForwardTo(IActorRef) Method ##
<small>Namespace: [net.adamec.lib.common.actor.message](#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>


Forwards the message to another recipient. Keeps the original message, sender and routing key.



```csharp
public virtual void ForwardTo(IActorRef recipient)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Target recipient</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.message.envelope.forwardto_net.adamec.lib.common.actor.actor.iactorref-system.string___1pf93xv" />  Envelope.ForwardTo(IActorRef, string) Method ##
<small>Namespace: [net.adamec.lib.common.actor.message](#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>


Forwards the message to another recipient. Keeps the original message and sender, but cleans/set the [RoutingKey](#p-net.adamec.lib.common.actor.message.envelope.routingkey__1t0mr4v) based on <strong>routingKey</strong> parameter.



```csharp
public virtual void ForwardTo(IActorRef recipient, string routingKey)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Target recipient</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>routingKey</strong></dt><dd>New [RoutingKey](#p-net.adamec.lib.common.actor.message.envelope.routingkey__1t0mr4v) , if not provided, the routing key will be cleaned up (set to null)!</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.message.envelope.tostring__3dg837" />  Envelope.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.actor.message](#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.message.errormessage__1gj1wb" />  ErrorMessage Class ##
<small>Namespace: [net.adamec.lib.common.actor.message](#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Sources: message\ErrorMessage.cs</small>


Specialized [Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) for messages in [ErrorMessageQueue](#p-net.adamec.lib.common.actor.actorsystem.iactorsystem.errormessagequeue__v9i6fy)



```csharp
public class ErrorMessage : Envelope
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.actor.message.Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Error](#p-net.adamec.lib.common.actor.message.errormessage.error__1649m0l) | public | Error message | 
 | [ErrorOn](#p-net.adamec.lib.common.actor.message.errormessage.erroron__b1f28) | public | Timestamp when the error envelope has been created | 
 | [Exception](#p-net.adamec.lib.common.actor.message.errormessage.exception__crgqc2) | public | Exception thrown | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ErrorMessage(Envelope, string, Exception)](#m-net.adamec.lib.common.actor.message.errormessage.-ctor_net.adamec.lib.common.actor.message.envelope-system.string-system.exception___7xh1dy) | public | CTOR - creates the error message envelope based on given message <strong>envelope</strong> | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](#m-net.adamec.lib.common.actor.message.errormessage.tostring__1v7vk6u) | public |  | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.message.errormessage.error__1649m0l" />  ErrorMessage.Error Property ##
<small>Namespace: [net.adamec.lib.common.actor.message](#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [ErrorMessage](#t-net.adamec.lib.common.actor.message.errormessage__1gj1wb)           
Sources: message\ErrorMessage.cs</small>


Error message



```csharp
public string Error { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.message.errormessage.erroron__b1f28" />  ErrorMessage.ErrorOn Property ##
<small>Namespace: [net.adamec.lib.common.actor.message](#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [ErrorMessage](#t-net.adamec.lib.common.actor.message.errormessage__1gj1wb)           
Sources: message\ErrorMessage.cs</small>


Timestamp when the error envelope has been created



```csharp
public DateTime ErrorOn { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.datetime" target="_blank" >DateTime</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.message.errormessage.exception__crgqc2" />  ErrorMessage.Exception Property ##
<small>Namespace: [net.adamec.lib.common.actor.message](#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [ErrorMessage](#t-net.adamec.lib.common.actor.message.errormessage__1gj1wb)           
Sources: message\ErrorMessage.cs</small>


Exception thrown



```csharp
public Exception Exception { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.message.errormessage.-ctor_net.adamec.lib.common.actor.message.envelope-system.string-system.exception___7xh1dy" />  ErrorMessage.ErrorMessage(Envelope, string, Exception) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.message](#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [ErrorMessage](#t-net.adamec.lib.common.actor.message.errormessage__1gj1wb)           
Sources: message\ErrorMessage.cs</small>


CTOR - creates the error message envelope based on given message <strong>envelope</strong>



```csharp
public ErrorMessage(Envelope envelope, string error, Exception exception)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Envelope of message causing the error</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>error</strong></dt><dd>Error message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception thrown</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.message.errormessage.tostring__1v7vk6u" />  ErrorMessage.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.actor.message](#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [ErrorMessage](#t-net.adamec.lib.common.actor.message.errormessage__1gj1wb)           
Sources: message\ErrorMessage.cs</small>



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="n-net.adamec.lib.common.actor.queue__1lh8qrc" />  net.adamec.lib.common.actor.queue Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [InternalQueue](#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8) | internal | An unbounded mailbox managed message queue used by [ManagedMessageQueue](#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09) as the main message queue Allows access to stored messages for monitoring using [Copy()](#m-net.adamec.lib.common.actor.queue.internalqueue.copy__1co1b8y) . Note: the messages in the array must not be modified!!! | 
 | [ManagedMessageQueue](#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09) | public | Message queue for <em>net.adamec.home.control.common.actor.manager.mailbox.ManagedUnboundedDequeBasedMailbox</em> allowing the monitoring (access to) messages stores in the queue The main queue is implemented using <em>net.adamec.home.control.common.actor.manager.mailbox.ManagedMessageQueue</em> and also uses a <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1" target="_blank" >System.Collections.Generic.Stack`1</a> internally to store each individual <em>net.adamec.home.control.common.actor.manager.mailbox.ManagedMessageQueue.EnqueueFirst(Akka.Actor.Envelope)</em> messages - supports stashing | 

 


###  Interfaces ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IMessageQueue](#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl) | public abstract |  | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8" />  InternalQueue Class ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Sources: queue\InternalQueue.cs</small>


An unbounded mailbox managed message queue used by [ManagedMessageQueue](#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09) as the main message queue Allows access to stored messages for monitoring using [Copy()](#m-net.adamec.lib.common.actor.queue.internalqueue.copy__1co1b8y) . Note: the messages in the array must not be modified!!!



```csharp
internal class InternalQueue : IMessageQueue
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: [net.adamec.lib.common.actor.queue.IMessageQueue](#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [queue](#f-net.adamec.lib.common.actor.queue.internalqueue.queue__11mr03p) | private | Internal queue | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Count](#p-net.adamec.lib.common.actor.queue.internalqueue.count__1dorya5) | public | Number of messages in the queue | 
 | [HasMessages](#p-net.adamec.lib.common.actor.queue.internalqueue.hasmessages__1im69ka) | public | Flag whether the queue contains any messages | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CleanUp(IMessageQueue)](#m-net.adamec.lib.common.actor.queue.internalqueue.cleanup_net.adamec.lib.common.actor.queue.imessagequeue___1hi25kd) | public | Cleans the queue, the messages are sent to <strong>deadletters</strong> queue | 
 | [Copy()](#m-net.adamec.lib.common.actor.queue.internalqueue.copy__1co1b8y) | public | Gets the messages stored in the queue. The messages in the array must not be modified!!! | 
 | [Enqueue(Envelope)](#m-net.adamec.lib.common.actor.queue.internalqueue.enqueue_net.adamec.lib.common.actor.message.envelope___ve2fas) | public | Enqueue a new message envelope | 
 | [TryDequeue(Envelope)](#m-net.adamec.lib.common.actor.queue.internalqueue.trydequeue_net.adamec.lib.common.actor.message.envelope-___19jzc8l) | public | Tries to dequeue a message from the queue | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.queue.internalqueue.queue__11mr03p" />  InternalQueue.queue Field ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [InternalQueue](#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8)           
Sources: queue\InternalQueue.cs</small>


Internal queue



```csharp
private readonly ConcurrentQueue<net.adamec.lib.common.actor.message.Envelope> queue
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent.concurrentqueue-1" target="_blank" >System.Collections.Concurrent.ConcurrentQueue&lt;net.adamec.lib.common.actor.message.Envelope&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.queue.internalqueue.count__1dorya5" />  InternalQueue.Count Property ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [InternalQueue](#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8)           
Sources: queue\InternalQueue.cs</small>


Number of messages in the queue



```csharp
public int Count { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.queue.internalqueue.hasmessages__1im69ka" />  InternalQueue.HasMessages Property ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [InternalQueue](#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8)           
Sources: queue\InternalQueue.cs</small>


Flag whether the queue contains any messages



```csharp
public bool HasMessages { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.internalqueue.cleanup_net.adamec.lib.common.actor.queue.imessagequeue___1hi25kd" />  InternalQueue.CleanUp(IMessageQueue) Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [InternalQueue](#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8)           
Sources: queue\InternalQueue.cs</small>


Cleans the queue, the messages are sent to <strong>deadletters</strong> queue



```csharp
[ExcludeFromCodeCoverage]
public void CleanUp(IMessageQueue deadletters)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.queue.IMessageQueue](#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl) <strong>deadletters</strong></dt><dd>DeadLetters queue</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.internalqueue.copy__1co1b8y" />  InternalQueue.Copy() Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [InternalQueue](#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8)           
Sources: queue\InternalQueue.cs</small>


Gets the messages stored in the queue. The messages in the array must not be modified!!!



```csharp
[ExcludeFromCodeCoverage]
public Envelope[] Copy()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope[]](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)</dt><dd>Messages stored in the queue. The messages in the array must not be modified!!!</dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.internalqueue.enqueue_net.adamec.lib.common.actor.message.envelope___ve2fas" />  InternalQueue.Enqueue(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [InternalQueue](#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8)           
Sources: queue\InternalQueue.cs</small>


Enqueue a new message envelope



```csharp
public void Enqueue(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Message envelope</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.internalqueue.trydequeue_net.adamec.lib.common.actor.message.envelope-___19jzc8l" />  InternalQueue.TryDequeue(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [InternalQueue](#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8)           
Sources: queue\InternalQueue.cs</small>


Tries to dequeue a message from the queue



```csharp
public bool TryDequeue(out Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Message envelope dequeued</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True if any message is returned in <strong>envelope</strong></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09" />  ManagedMessageQueue Class ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Sources: queue\ManagedMessageQueue.cs</small>


Message queue for <em>net.adamec.home.control.common.actor.manager.mailbox.ManagedUnboundedDequeBasedMailbox</em> allowing the monitoring (access to) messages stores in the queue The main queue is implemented using <em>net.adamec.home.control.common.actor.manager.mailbox.ManagedMessageQueue</em> and also uses a <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1" target="_blank" >System.Collections.Generic.Stack`1</a> internally to store each individual <em>net.adamec.home.control.common.actor.manager.mailbox.ManagedMessageQueue.EnqueueFirst(Akka.Actor.Envelope)</em> messages - supports stashing



```csharp
public class ManagedMessageQueue : IMessageQueue
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: [net.adamec.lib.common.actor.queue.IMessageQueue](#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MessageQueue](#f-net.adamec.lib.common.actor.queue.managedmessagequeue.messagequeue__f6vqnz) | protected | The underlying [InternalQueue](#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8) . | 
 | [prependBuffer](#f-net.adamec.lib.common.actor.queue.managedmessagequeue.prependbuffer__8wamat) | private |  | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Count](#p-net.adamec.lib.common.actor.queue.managedmessagequeue.count__h0822) | public | Returns the number of messages in both the internal message queue and the prepend buffer. | 
 | [HasMessages](#p-net.adamec.lib.common.actor.queue.managedmessagequeue.hasmessages__17b0d3x) | public | Returns true if there are any messages inside the queue. | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ManagedMessageQueue()](#m-net.adamec.lib.common.actor.queue.managedmessagequeue.-ctor__1c6oeh3) | public | Creates [ManagedMessageQueue](#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CleanUp(IMessageQueue)](#m-net.adamec.lib.common.actor.queue.managedmessagequeue.cleanup_net.adamec.lib.common.actor.queue.imessagequeue___1e5rsai) | public | Cleans the queue, the messages are sent to <strong>deadletters</strong> queue | 
 | [Copy()](#m-net.adamec.lib.common.actor.queue.managedmessagequeue.copy__xeyi8r) | public | Gets the all queued messages stored in the prepend buffer and main queue. The messages in the array must not be modified!!! | 
 | [Enqueue(Envelope)](#m-net.adamec.lib.common.actor.queue.managedmessagequeue.enqueue_net.adamec.lib.common.actor.message.envelope___fs8mtl) | public | Enqueue a new message envelope | 
 | [EnqueueFirst(Envelope)](#m-net.adamec.lib.common.actor.queue.managedmessagequeue.enqueuefirst_net.adamec.lib.common.actor.message.envelope___3gbbrz) | public | Add a message to the front of the queue via the prepend buffer. | 
 | [TryDequeue(Envelope)](#m-net.adamec.lib.common.actor.queue.managedmessagequeue.trydequeue_net.adamec.lib.common.actor.message.envelope-___1k976aa) | public | Attempt to dequeue a message from the front of the prepend buffer.  If the prepend buffer is empty, dequeue a message from the main message queue | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.queue.managedmessagequeue.messagequeue__f6vqnz" />  ManagedMessageQueue.MessageQueue Field ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [ManagedMessageQueue](#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)           
Sources: queue\ManagedMessageQueue.cs</small>


The underlying [InternalQueue](#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8) .



```csharp
protected readonly IMessageQueue MessageQueue
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.actor.queue.IMessageQueue](#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.queue.managedmessagequeue.prependbuffer__8wamat" />  ManagedMessageQueue.prependBuffer Field ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [ManagedMessageQueue](#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)           
Sources: queue\ManagedMessageQueue.cs</small>



```csharp
private readonly Stack<net.adamec.lib.common.actor.message.Envelope> prependBuffer
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1" target="_blank" >Stack&lt;net.adamec.lib.common.actor.message.Envelope&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.queue.managedmessagequeue.count__h0822" />  ManagedMessageQueue.Count Property ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [ManagedMessageQueue](#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)           
Sources: queue\ManagedMessageQueue.cs</small>


Returns the number of messages in both the internal message queue and the prepend buffer.



```csharp
public int Count { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.queue.managedmessagequeue.hasmessages__17b0d3x" />  ManagedMessageQueue.HasMessages Property ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [ManagedMessageQueue](#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)           
Sources: queue\ManagedMessageQueue.cs</small>


Returns true if there are any messages inside the queue.



```csharp
public bool HasMessages { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.managedmessagequeue.-ctor__1c6oeh3" />  ManagedMessageQueue.ManagedMessageQueue() Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [ManagedMessageQueue](#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)           
Sources: queue\ManagedMessageQueue.cs</small>


Creates [ManagedMessageQueue](#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)



```csharp
public ManagedMessageQueue()
```

Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.managedmessagequeue.cleanup_net.adamec.lib.common.actor.queue.imessagequeue___1e5rsai" />  ManagedMessageQueue.CleanUp(IMessageQueue) Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [ManagedMessageQueue](#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)           
Sources: queue\ManagedMessageQueue.cs</small>


Cleans the queue, the messages are sent to <strong>deadletters</strong> queue



```csharp
public void CleanUp(IMessageQueue deadletters)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.queue.IMessageQueue](#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl) <strong>deadletters</strong></dt><dd>DeadLetters queue</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.managedmessagequeue.copy__xeyi8r" />  ManagedMessageQueue.Copy() Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [ManagedMessageQueue](#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)           
Sources: queue\ManagedMessageQueue.cs</small>


Gets the all queued messages stored in the prepend buffer and main queue. The messages in the array must not be modified!!!



```csharp
[ExcludeFromCodeCoverage]
public Envelope[] Copy()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope[]](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)</dt><dd>All queued messages stored in the prepend buffer and main queue. The messages in the array must not be modified!!!</dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.managedmessagequeue.enqueue_net.adamec.lib.common.actor.message.envelope___fs8mtl" />  ManagedMessageQueue.Enqueue(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [ManagedMessageQueue](#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)           
Sources: queue\ManagedMessageQueue.cs</small>


Enqueue a new message envelope



```csharp
public void Enqueue(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Message envelope</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.managedmessagequeue.enqueuefirst_net.adamec.lib.common.actor.message.envelope___3gbbrz" />  ManagedMessageQueue.EnqueueFirst(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [ManagedMessageQueue](#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)           
Sources: queue\ManagedMessageQueue.cs</small>


Add a message to the front of the queue via the prepend buffer.



```csharp
public void EnqueueFirst(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>The message we wish to append to the front of the queue.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.managedmessagequeue.trydequeue_net.adamec.lib.common.actor.message.envelope-___1k976aa" />  ManagedMessageQueue.TryDequeue(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [ManagedMessageQueue](#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)           
Sources: queue\ManagedMessageQueue.cs</small>


Attempt to dequeue a message from the front of the prepend buffer.  If the prepend buffer is empty, dequeue a message from the main message queue



```csharp
public bool TryDequeue(out Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>The message to return, if any</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>`true` if a message was available, `false` otherwise.</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl" />  IMessageQueue Interface ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Sources: queue\IMessageQueue.cs</small>



```csharp
public interface IMessageQueue
```

###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Count](#p-net.adamec.lib.common.actor.queue.imessagequeue.count__g0891s) | public abstract | Returns the count of messages currently in the message queue | 
 | [HasMessages](#p-net.adamec.lib.common.actor.queue.imessagequeue.hasmessages__1iz3wad) | public abstract | Tests if the message queue contains any messages | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CleanUp(IMessageQueue)](#m-net.adamec.lib.common.actor.queue.imessagequeue.cleanup_net.adamec.lib.common.actor.queue.imessagequeue___2qe93s) | public abstract | Called when the [IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) this queue belongs to is de-registered. All remaining messages are transferred  into the dead-letter queue | 
 | [Enqueue(Envelope)](#m-net.adamec.lib.common.actor.queue.imessagequeue.enqueue_net.adamec.lib.common.actor.message.envelope___13cgq6h) | public abstract | Enqueue an mailbox envelope onto the message queue | 
 | [TryDequeue(Envelope)](#m-net.adamec.lib.common.actor.queue.imessagequeue.trydequeue_net.adamec.lib.common.actor.message.envelope-___1jw22qo) | public abstract | Tries to pull an envelope of the message queue | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.queue.imessagequeue.count__g0891s" />  IMessageQueue.Count Property ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [IMessageQueue](#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)           
Sources: queue\IMessageQueue.cs</small>


Returns the count of messages currently in the message queue



```csharp
public abstract int Count { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.queue.imessagequeue.hasmessages__1iz3wad" />  IMessageQueue.HasMessages Property ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [IMessageQueue](#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)           
Sources: queue\IMessageQueue.cs</small>


Tests if the message queue contains any messages



```csharp
public abstract bool HasMessages { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.imessagequeue.cleanup_net.adamec.lib.common.actor.queue.imessagequeue___2qe93s" />  IMessageQueue.CleanUp(IMessageQueue) Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [IMessageQueue](#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)           
Sources: queue\IMessageQueue.cs</small>


Called when the [IActorRef](#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) this queue belongs to is de-registered. All remaining messages are transferred  into the dead-letter queue



```csharp
public abstract void CleanUp(IMessageQueue deadletters)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.queue.IMessageQueue](#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl) <strong>deadletters</strong></dt><dd>The dead letters message queue.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.imessagequeue.enqueue_net.adamec.lib.common.actor.message.envelope___13cgq6h" />  IMessageQueue.Enqueue(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [IMessageQueue](#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)           
Sources: queue\IMessageQueue.cs</small>


Enqueue an mailbox envelope onto the message queue



```csharp
public abstract void Enqueue(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>The envelope to enqueue</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.imessagequeue.trydequeue_net.adamec.lib.common.actor.message.envelope-___1jw22qo" />  IMessageQueue.TryDequeue(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [IMessageQueue](#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)           
Sources: queue\IMessageQueue.cs</small>


Tries to pull an envelope of the message queue



```csharp
public abstract bool TryDequeue(out Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>The envelope that was dequeued</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>`true` if there&#39;s a message in the queue. `false` otherwise.</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="n-net.adamec.lib.common.extensions__1vwuhoq" />  net.adamec.lib.common.extensions Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TypeExtensions](#t-net.adamec.lib.common.extensions.typeextensions__63ezc8) | internal static | <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> extensions | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.extensions.typeextensions__63ezc8" />  TypeExtensions Class ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common.actor           
Sources: Files\cs\any\App_Packages\RadCommons.extensions.TypeExtensions.DefaultValue\TypeExtensionsDefaultValue.cs           
Source-only packages: [RadCommons.extensions.TypeExtensions.DefaultValue](#src-only-package--RadCommons.extensions.TypeExtensions.DefaultValue)</small>


<a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> extensions



```csharp
internal static class TypeExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetDefaultValue(Type)](#m-net.adamec.lib.common.extensions.typeextensions.getdefaultvalue_system.type___vn2w69) | public static | Gets the default value of given <strong>type</strong> | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.extensions.typeextensions.getdefaultvalue_system.type___vn2w69" />  TypeExtensions.GetDefaultValue(Type) Method ##
<small>Namespace: [net.adamec.lib.common.extensions](#n-net.adamec.lib.common.extensions__1vwuhoq)           
Assembly: net.adamec.lib.common.actor           
Type: [TypeExtensions](#t-net.adamec.lib.common.extensions.typeextensions__63ezc8)           
Sources: Files\cs\any\App_Packages\RadCommons.extensions.TypeExtensions.DefaultValue\TypeExtensionsDefaultValue.cs           
Source-only packages: [RadCommons.extensions.TypeExtensions.DefaultValue](#src-only-package--RadCommons.extensions.TypeExtensions.DefaultValue)</small>


Gets the default value of given <strong>type</strong>



```csharp
public static object GetDefaultValue(this Type type)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>type</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd>Default value of given <strong>type</strong> . Null for non-value types, new instance for value types.</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="n-net.adamec.lib.common.logging__1g9pm29" />  net.adamec.lib.common.logging Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CommonLogging](#t-net.adamec.lib.common.logging.commonlogging__1dar5wb) | public static | [ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) factory | 
 | [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv) | internal static | [ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) extensions | 

 


###  Interfaces ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) | public abstract | Logger interface - wrapper around the <em>NLog.ILogger</em> | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.logging.commonlogging__1dar5wb" />  CommonLogging Class ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Sources: Packages\RadCommons.logging.CommonLogging\CommonLogging.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


[ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) factory



```csharp
public static class CommonLogging
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CreateLogger(string)](#m-net.adamec.lib.common.logging.commonlogging.createlogger_system.string___wn77if) | public static | Creates the logger with given <strong>categoryName</strong> | 
 | [CreateLogger(Type)](#m-net.adamec.lib.common.logging.commonlogging.createlogger_system.type___uhum9e) | public static | Creates the logger for given type. The name of the logger will be <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type.fullname#System_Type_FullName" target="_blank" >System.Type.FullName</a> | 
 | [CreateLogger&lt;T&gt;()](#m-net.adamec.lib.common.logging.commonlogging.createlogger--1__lp2vax) | public static | Creates the logger for given type. The name of the logger will be <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type.fullname#System_Type_FullName" target="_blank" >System.Type.FullName</a> | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.commonlogging.createlogger_system.string___wn77if" />  CommonLogging.CreateLogger(string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [CommonLogging](#t-net.adamec.lib.common.logging.commonlogging__1dar5wb)           
Sources: Packages\RadCommons.logging.CommonLogging\CommonLogging.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Creates the logger with given <strong>categoryName</strong>



```csharp
public static ILogger CreateLogger(string categoryName)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>categoryName</strong></dt><dd>Name of the logger</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm)</dt><dd>Logger instance</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.commonlogging.createlogger_system.type___uhum9e" />  CommonLogging.CreateLogger(Type) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [CommonLogging](#t-net.adamec.lib.common.logging.commonlogging__1dar5wb)           
Sources: Packages\RadCommons.logging.CommonLogging\CommonLogging.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Creates the logger for given type. The name of the logger will be <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type.fullname#System_Type_FullName" target="_blank" >System.Type.FullName</a>



```csharp
public static ILogger CreateLogger(Type type)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>type</strong></dt><dd>Type to create the logger for</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm)</dt><dd>Logger instance</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.commonlogging.createlogger--1__lp2vax" />  CommonLogging.CreateLogger&lt;T&gt;() Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [CommonLogging](#t-net.adamec.lib.common.logging.commonlogging__1dar5wb)           
Sources: Packages\RadCommons.logging.CommonLogging\CommonLogging.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Creates the logger for given type. The name of the logger will be <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type.fullname#System_Type_FullName" target="_blank" >System.Type.FullName</a>



```csharp
public static ILogger CreateLogger<T>()
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd>Type to create the logger for</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm)</dt><dd>Logger instance</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.logging.loggerextensions__wainxv" />  LoggerExtensions Class ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


[ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) extensions



```csharp
internal static class LoggerExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Debug(ILogger, Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.logging.loggerextensions.debug_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.string___j9my8t) | public static | Writes the diagnostic message at the `Debug` level. | 
 | [Debug(ILogger, string, string)](#m-net.adamec.lib.common.logging.loggerextensions.debug_net.adamec.lib.common.logging.ilogger-system.string-system.string___1ivhtea) | public static | Writes the diagnostic message at the `Debug` level. | 
 | [Error(ILogger, Dictionary&lt;string,object&gt;, Exception, string)](#m-net.adamec.lib.common.logging.loggerextensions.error_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___m1gnmw) | public static | Writes the diagnostic message at the `Error` level. | 
 | [Error(ILogger, Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.logging.loggerextensions.error_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.string___cx87zg) | public static | Writes the diagnostic message at the `Error` level. | 
 | [Error(ILogger, string, Exception, string)](#m-net.adamec.lib.common.logging.loggerextensions.error_net.adamec.lib.common.logging.ilogger-system.string-system.exception-system.string___yb2lv7) | public static | Writes the diagnostic message at the `Error` level. | 
 | [Error(ILogger, string, string)](#m-net.adamec.lib.common.logging.loggerextensions.error_net.adamec.lib.common.logging.ilogger-system.string-system.string___1rt5ddv) | public static | Writes the diagnostic message at the `Error` level. | 
 | [Error&lt;TException&gt;(ILogger, string, Exception)](#m-net.adamec.lib.common.logging.loggerextensions.error--1_net.adamec.lib.common.logging.ilogger-system.string-system.exception___1i16h8s) | public static | Writes the diagnostic message at the `Error` level. Creates and returns the exception of given type | 
 | [Error&lt;TException&gt;(ILogger, string, string, Exception)](#m-net.adamec.lib.common.logging.loggerextensions.error--1_net.adamec.lib.common.logging.ilogger-system.string-system.string-system.exception___1473s) | public static | Writes the diagnostic message at the `Error` level. Creates and returns the exception of given type | 
 | [Fatal(ILogger, Dictionary&lt;string,object&gt;, Exception, string)](#m-net.adamec.lib.common.logging.loggerextensions.fatal_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___1u2znd0) | public static | Writes the diagnostic message at the `Fatal` level. | 
 | [Fatal(ILogger, Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.logging.loggerextensions.fatal_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.string___1ron6v0) | public static | Writes the diagnostic message at the `Fatal` level. | 
 | [Fatal(ILogger, string, Exception, string)](#m-net.adamec.lib.common.logging.loggerextensions.fatal_net.adamec.lib.common.logging.ilogger-system.string-system.exception-system.string___zech9x) | public static | Writes the diagnostic message at the `Fatal` level. | 
 | [Fatal(ILogger, string, string)](#m-net.adamec.lib.common.logging.loggerextensions.fatal_net.adamec.lib.common.logging.ilogger-system.string-system.string___7ptull) | public static | Writes the diagnostic message at the `Fatal` level. | 
 | [Fatal&lt;TException&gt;(ILogger, string, Exception)](#m-net.adamec.lib.common.logging.loggerextensions.fatal--1_net.adamec.lib.common.logging.ilogger-system.string-system.exception___1i44id8) | public static | Writes the diagnostic message at the `Fatal` level. Creates and returns the exception of given type | 
 | [Fatal&lt;TException&gt;(ILogger, string, string, Exception)](#m-net.adamec.lib.common.logging.loggerextensions.fatal--1_net.adamec.lib.common.logging.ilogger-system.string-system.string-system.exception___1lozfm8) | public static | Writes the diagnostic message at the `Fatal` level. Creates and returns the exception of given type | 
 | [Info(ILogger, Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.logging.loggerextensions.info_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.string___q80pva) | public static | Writes the diagnostic message at the `Info` level. | 
 | [Info(ILogger, string, string)](#m-net.adamec.lib.common.logging.loggerextensions.info_net.adamec.lib.common.logging.ilogger-system.string-system.string___1ufgud1) | public static | Writes the diagnostic message at the `Info` level. | 
 | [LogIt(ILogger, LogLevel, Dictionary&lt;string,object&gt;, string, Exception)](#m-net.adamec.lib.common.logging.loggerextensions.logit_net.adamec.lib.common.logging.ilogger-nlog.loglevel-system.collections.generic.dictionary_system.string-system.object_-system.string-system.exception___1pbym9v) | private static | Writes the item (message with optional event properties and exception)  into the log | 
 | [LogIt(ILogger, LogLevel, string, string, Exception)](#m-net.adamec.lib.common.logging.loggerextensions.logit_net.adamec.lib.common.logging.ilogger-nlog.loglevel-system.string-system.string-system.exception___rb1ido) | private static | Writes the item (message with optional exception)  into the log | 
 | [Warn(ILogger, Dictionary&lt;string,object&gt;, Exception, string)](#m-net.adamec.lib.common.logging.loggerextensions.warn_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___sahasq) | public static | Writes the diagnostic message at the `Warn` level. | 
 | [Warn(ILogger, Dictionary&lt;string,object&gt;, string)](#m-net.adamec.lib.common.logging.loggerextensions.warn_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.string___oq47e2) | public static | Writes the diagnostic message at the `Warn` level. | 
 | [Warn(ILogger, string, Exception, string)](#m-net.adamec.lib.common.logging.loggerextensions.warn_net.adamec.lib.common.logging.ilogger-system.string-system.exception-system.string___4coctd) | public static | Writes the diagnostic message at the `Warn` level. | 
 | [Warn(ILogger, string, string)](#m-net.adamec.lib.common.logging.loggerextensions.warn_net.adamec.lib.common.logging.ilogger-system.string-system.string___1mophq5) | public static | Writes the diagnostic message at the `Warn` level. | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.debug_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.string___j9my8t" />  LoggerExtensions.Debug(ILogger, Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Debug` level.



```csharp
public static void Debug(this ILogger logger, Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.debug_net.adamec.lib.common.logging.ilogger-system.string-system.string___1ivhtea" />  LoggerExtensions.Debug(ILogger, string, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Debug` level.



```csharp
public static void Debug(this ILogger logger, string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.error_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___m1gnmw" />  LoggerExtensions.Error(ILogger, Dictionary&lt;string,object&gt;, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level.



```csharp
public static void Error(this ILogger logger, Dictionary<string,object> eventProperties, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.error_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.string___cx87zg" />  LoggerExtensions.Error(ILogger, Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level.



```csharp
public static void Error(this ILogger logger, Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.error_net.adamec.lib.common.logging.ilogger-system.string-system.exception-system.string___yb2lv7" />  LoggerExtensions.Error(ILogger, string, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level.



```csharp
public static void Error(this ILogger logger, string correlationId, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.error_net.adamec.lib.common.logging.ilogger-system.string-system.string___1rt5ddv" />  LoggerExtensions.Error(ILogger, string, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level.



```csharp
public static void Error(this ILogger logger, string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.error--1_net.adamec.lib.common.logging.ilogger-system.string-system.exception___1i16h8s" />  LoggerExtensions.Error&lt;TException&gt;(ILogger, string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level. Creates and returns the exception of given type



```csharp
public static LoggerExtensions.TException Error<TException>(this ILogger logger, string message, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.logging.LoggerExtensions.TException</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.error--1_net.adamec.lib.common.logging.ilogger-system.string-system.string-system.exception___1473s" />  LoggerExtensions.Error&lt;TException&gt;(ILogger, string, string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Error` level. Creates and returns the exception of given type



```csharp
public static LoggerExtensions.TException Error<TException>(this ILogger logger, string correlationId, string message, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.logging.LoggerExtensions.TException</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.fatal_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___1u2znd0" />  LoggerExtensions.Fatal(ILogger, Dictionary&lt;string,object&gt;, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level.



```csharp
public static void Fatal(this ILogger logger, Dictionary<string,object> eventProperties, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.fatal_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.string___1ron6v0" />  LoggerExtensions.Fatal(ILogger, Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level.



```csharp
public static void Fatal(this ILogger logger, Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.fatal_net.adamec.lib.common.logging.ilogger-system.string-system.exception-system.string___zech9x" />  LoggerExtensions.Fatal(ILogger, string, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level.



```csharp
public static void Fatal(this ILogger logger, string correlationId, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.fatal_net.adamec.lib.common.logging.ilogger-system.string-system.string___7ptull" />  LoggerExtensions.Fatal(ILogger, string, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level.



```csharp
public static void Fatal(this ILogger logger, string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.fatal--1_net.adamec.lib.common.logging.ilogger-system.string-system.exception___1i44id8" />  LoggerExtensions.Fatal&lt;TException&gt;(ILogger, string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level. Creates and returns the exception of given type



```csharp
public static LoggerExtensions.TException Fatal<TException>(this ILogger logger, string message, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.logging.LoggerExtensions.TException</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.fatal--1_net.adamec.lib.common.logging.ilogger-system.string-system.string-system.exception___1lozfm8" />  LoggerExtensions.Fatal&lt;TException&gt;(ILogger, string, string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Fatal` level. Creates and returns the exception of given type



```csharp
public static LoggerExtensions.TException Fatal<TException>(this ILogger logger, string correlationId, string message, Exception innerException = null) where TException: Exception
```

<strong>Type parameters</strong><dl><dt><strong>TException</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>innerException</strong></dt><dd>Exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.logging.LoggerExtensions.TException</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.info_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.string___q80pva" />  LoggerExtensions.Info(ILogger, Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Info` level.



```csharp
public static void Info(this ILogger logger, Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.info_net.adamec.lib.common.logging.ilogger-system.string-system.string___1ufgud1" />  LoggerExtensions.Info(ILogger, string, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Info` level.



```csharp
public static void Info(this ILogger logger, string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.logit_net.adamec.lib.common.logging.ilogger-nlog.loglevel-system.collections.generic.dictionary_system.string-system.object_-system.string-system.exception___1pbym9v" />  LoggerExtensions.LogIt(ILogger, LogLevel, Dictionary&lt;string,object&gt;, string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the item (message with optional event properties and exception)  into the log



```csharp
private static void LogIt(ILogger logger, LogLevel level, Dictionary<string,object> eventProperties, [Localizable(false)] string message, Exception exception = null)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt>NLog.LogLevel <strong>level</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties (null when no properties are provided)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Optional exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.logit_net.adamec.lib.common.logging.ilogger-nlog.loglevel-system.string-system.string-system.exception___rb1ido" />  LoggerExtensions.LogIt(ILogger, LogLevel, string, string, Exception) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the item (message with optional exception)  into the log



```csharp
private static void LogIt(ILogger logger, LogLevel level, string correlationId, [Localizable(false)] string message, Exception exception = null)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt>NLog.LogLevel <strong>level</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Optional exception to be logged</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.warn_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___sahasq" />  LoggerExtensions.Warn(ILogger, Dictionary&lt;string,object&gt;, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Warn` level.



```csharp
public static void Warn(this ILogger logger, Dictionary<string,object> eventProperties, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.warn_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.string___oq47e2" />  LoggerExtensions.Warn(ILogger, Dictionary&lt;string,object&gt;, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Warn` level.



```csharp
public static void Warn(this ILogger logger, Dictionary<string,object> eventProperties, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a> <strong>eventProperties</strong></dt><dd>Event properties</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.warn_net.adamec.lib.common.logging.ilogger-system.string-system.exception-system.string___4coctd" />  LoggerExtensions.Warn(ILogger, string, Exception, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Warn` level.



```csharp
public static void Warn(this ILogger logger, string correlationId, Exception exception, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception to be logged</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.logging.loggerextensions.warn_net.adamec.lib.common.logging.ilogger-system.string-system.string___1mophq5" />  LoggerExtensions.Warn(ILogger, string, string) Method ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Type: [LoggerExtensions](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)           
Sources: Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Writes the diagnostic message at the `Warn` level.



```csharp
public static void Warn(this ILogger logger, string correlationId, [Localizable(false)] string message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) <strong>logger</strong></dt><dd>Logger</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>correlationId</strong></dt><dd>Correlation ID</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>message</strong></dt><dd>Log message.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.logging.ilogger__y2ollm" />  ILogger Interface ##
<small>Namespace: [net.adamec.lib.common.logging](#n-net.adamec.lib.common.logging__1g9pm29)           
Assembly: net.adamec.lib.common.actor           
Sources: Packages\RadCommons.logging.CommonLogging\ILogger.cs           
Source-only packages: [RadCommons.logging.CommonLogging](#src-only-package--RadCommons.logging.CommonLogging)</small>


Logger interface - wrapper around the <em>NLog.ILogger</em>



```csharp
public interface ILogger : ILogger
```

Implements: NLog.ILogger, NLog.ILoggerBase, NLog.ISuppress


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="n-net.adamec.lib.common.utils__7vdji9" />  net.adamec.lib.common.utils Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [BaseDisposable](#t-net.adamec.lib.common.utils.basedisposable__7s72ps) | public abstract | Helper class for implementation of <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> types | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.utils.basedisposable__7s72ps" />  BaseDisposable Class ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common.actor           
Sources: ackages\RadCommons.utils.BaseDisposable\BaseDisposable.cs           
Source-only packages: [RadCommons.utils.BaseDisposable](#src-only-package--RadCommons.utils.BaseDisposable)</small>


Helper class for implementation of <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> types



```csharp
public abstract class BaseDisposable : IDisposable
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Disposed](#p-net.adamec.lib.common.utils.basedisposable.disposed__nxq2fp) | public | Flag whether the object is fully disposed | 
 | [DisposedManaged](#p-net.adamec.lib.common.utils.basedisposable.disposedmanaged__1pm7df6) | public | Flag whether the managed resources are disposed | 
 | [DisposedNative](#p-net.adamec.lib.common.utils.basedisposable.disposednative__fqjn7i) | public | Flag whether the native resources are disposed | 

 


###  Destructor ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [~BaseDisposable()](#m-net.adamec.lib.common.utils.basedisposable.finalize__1l3n8dl) | protected |  | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Dispose()](#m-net.adamec.lib.common.utils.basedisposable.dispose__6qe9ri) | public | Dispose the object | 
 | [Dispose(bool)](#m-net.adamec.lib.common.utils.basedisposable.dispose_system.boolean___1vzs8w4) | protected | Internal implementation of dispose - free the managed and native resources using the respective methods | 
 | [DisposeManaged()](#m-net.adamec.lib.common.utils.basedisposable.disposemanaged__1ht3p85) | protected | Dispose any disposable managed fields or properties. | 
 | [DisposeNative()](#m-net.adamec.lib.common.utils.basedisposable.disposenative__uaa3i9) | protected | Dispose of COM objects, Handles, etc. Then set those objects to null. | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.basedisposable.disposed__nxq2fp" />  BaseDisposable.Disposed Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common.actor           
Type: [BaseDisposable](#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Sources: ackages\RadCommons.utils.BaseDisposable\BaseDisposable.cs           
Source-only packages: [RadCommons.utils.BaseDisposable](#src-only-package--RadCommons.utils.BaseDisposable)</small>


Flag whether the object is fully disposed



```csharp
public bool Disposed { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.basedisposable.disposedmanaged__1pm7df6" />  BaseDisposable.DisposedManaged Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common.actor           
Type: [BaseDisposable](#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Sources: ackages\RadCommons.utils.BaseDisposable\BaseDisposable.cs           
Source-only packages: [RadCommons.utils.BaseDisposable](#src-only-package--RadCommons.utils.BaseDisposable)</small>


Flag whether the managed resources are disposed



```csharp
public bool DisposedManaged { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.utils.basedisposable.disposednative__fqjn7i" />  BaseDisposable.DisposedNative Property ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common.actor           
Type: [BaseDisposable](#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Sources: ackages\RadCommons.utils.BaseDisposable\BaseDisposable.cs           
Source-only packages: [RadCommons.utils.BaseDisposable](#src-only-package--RadCommons.utils.BaseDisposable)</small>


Flag whether the native resources are disposed



```csharp
public bool DisposedNative { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.basedisposable.finalize__1l3n8dl" />  BaseDisposable.~BaseDisposable() Destructor ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common.actor           
Type: [BaseDisposable](#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Sources: ackages\RadCommons.utils.BaseDisposable\BaseDisposable.cs           
Source-only packages: [RadCommons.utils.BaseDisposable](#src-only-package--RadCommons.utils.BaseDisposable)</small>



```csharp
 ~BaseDisposable()
```

Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.basedisposable.dispose__6qe9ri" />  BaseDisposable.Dispose() Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common.actor           
Type: [BaseDisposable](#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Sources: ackages\RadCommons.utils.BaseDisposable\BaseDisposable.cs           
Source-only packages: [RadCommons.utils.BaseDisposable](#src-only-package--RadCommons.utils.BaseDisposable)</small>


Dispose the object



```csharp
public void Dispose()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.basedisposable.dispose_system.boolean___1vzs8w4" />  BaseDisposable.Dispose(bool) Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common.actor           
Type: [BaseDisposable](#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Sources: ackages\RadCommons.utils.BaseDisposable\BaseDisposable.cs           
Source-only packages: [RadCommons.utils.BaseDisposable](#src-only-package--RadCommons.utils.BaseDisposable)</small>


Internal implementation of dispose - free the managed and native resources using the respective methods



```csharp
protected virtual void Dispose(bool disposing)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>disposing</strong></dt><dd>Flag whether the object is disposing (called from [Dispose()](#m-net.adamec.lib.common.utils.basedisposable.dispose__6qe9ri) method). False if called from destructor</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.basedisposable.disposemanaged__1ht3p85" />  BaseDisposable.DisposeManaged() Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common.actor           
Type: [BaseDisposable](#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Sources: ackages\RadCommons.utils.BaseDisposable\BaseDisposable.cs           
Source-only packages: [RadCommons.utils.BaseDisposable](#src-only-package--RadCommons.utils.BaseDisposable)</small>


Dispose any disposable managed fields or properties.



```csharp
protected virtual void DisposeManaged()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.utils.basedisposable.disposenative__uaa3i9" />  BaseDisposable.DisposeNative() Method ##
<small>Namespace: [net.adamec.lib.common.utils](#n-net.adamec.lib.common.utils__7vdji9)           
Assembly: net.adamec.lib.common.actor           
Type: [BaseDisposable](#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Sources: ackages\RadCommons.utils.BaseDisposable\BaseDisposable.cs           
Source-only packages: [RadCommons.utils.BaseDisposable](#src-only-package--RadCommons.utils.BaseDisposable)</small>


Dispose of COM objects, Handles, etc. Then set those objects to null.



```csharp
protected virtual void DisposeNative()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="src-only-package--RadCommons.extensions.TypeExtensions.DefaultValue" />  RadCommons.extensions.TypeExtensions.DefaultValue Source only package ##
<small>Tags: RadCommons           
Includes: None           
Declaring file: Files\cs\any\App_Packages\RadCommons.extensions.TypeExtensions.DefaultValue\TypeExtensionsDefaultValue.cs</small>


Provides default value for types (Source only package).


<strong>Package members</strong><dl><dt>[TypeExtensions (Type)](#t-net.adamec.lib.common.extensions.typeextensions__63ezc8)</dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> extensions</dd><dt>[GetDefaultValue(Type) (Method)](#m-net.adamec.lib.common.extensions.typeextensions.getdefaultvalue_system.type___vn2w69)</dt><dd>Gets the default value of given <strong>type</strong></dd></dl>


<strong>Sources</strong><dl><dt>Files\cs\any\App_Packages\RadCommons.extensions.TypeExtensions.DefaultValue\TypeExtensionsDefaultValue.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="src-only-package--RadCommons.logging.CommonLogging" />  RadCommons.logging.CommonLogging Source only package ##
<small>Tags: RadCommons RadCommons-Logging           
Includes: Folder           
Declaring file: Packages\RadCommons.logging.CommonLogging\_SourceOnlyPackage.cs</small>


RadCommons logging wrapper around NLog (Source only package).


<strong>References needed</strong><dl><dt>NLog</dt><dd></dd><dt>ProxyFoo</dt><dd></dd></dl>


<strong>Package members</strong><dl><dt>[CommonLogging (Type)](#t-net.adamec.lib.common.logging.commonlogging__1dar5wb)</dt><dd>[ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) factory</dd><dt>[CreateLogger(string) (Method)](#m-net.adamec.lib.common.logging.commonlogging.createlogger_system.string___wn77if)</dt><dd>Creates the logger with given <strong>categoryName</strong></dd><dt>[CreateLogger(Type) (Method)](#m-net.adamec.lib.common.logging.commonlogging.createlogger_system.type___uhum9e)</dt><dd>Creates the logger for given type. The name of the logger will be <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type.fullname#System_Type_FullName" target="_blank" >System.Type.FullName</a></dd><dt>[CreateLogger&lt;T&gt;() (Method)](#m-net.adamec.lib.common.logging.commonlogging.createlogger--1__lp2vax)</dt><dd>Creates the logger for given type. The name of the logger will be <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type.fullname#System_Type_FullName" target="_blank" >System.Type.FullName</a></dd><dt>[ILogger (Type)](#t-net.adamec.lib.common.logging.ilogger__y2ollm)</dt><dd>Logger interface - wrapper around the <em>NLog.ILogger</em></dd><dt>[LoggerExtensions (Type)](#t-net.adamec.lib.common.logging.loggerextensions__wainxv)</dt><dd>[ILogger](#t-net.adamec.lib.common.logging.ilogger__y2ollm) extensions</dd><dt>[Debug(ILogger, string, string) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.debug_net.adamec.lib.common.logging.ilogger-system.string-system.string___1ivhtea)</dt><dd>Writes the diagnostic message at the `Debug` level.</dd><dt>[Info(ILogger, string, string) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.info_net.adamec.lib.common.logging.ilogger-system.string-system.string___1ufgud1)</dt><dd>Writes the diagnostic message at the `Info` level.</dd><dt>[Warn(ILogger, string, string) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.warn_net.adamec.lib.common.logging.ilogger-system.string-system.string___1mophq5)</dt><dd>Writes the diagnostic message at the `Warn` level.</dd><dt>[Error(ILogger, string, string) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.error_net.adamec.lib.common.logging.ilogger-system.string-system.string___1rt5ddv)</dt><dd>Writes the diagnostic message at the `Error` level.</dd><dt>[Fatal(ILogger, string, string) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.fatal_net.adamec.lib.common.logging.ilogger-system.string-system.string___7ptull)</dt><dd>Writes the diagnostic message at the `Fatal` level.</dd><dt>[Warn(ILogger, string, Exception, string) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.warn_net.adamec.lib.common.logging.ilogger-system.string-system.exception-system.string___4coctd)</dt><dd>Writes the diagnostic message at the `Warn` level.</dd><dt>[Error(ILogger, string, Exception, string) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.error_net.adamec.lib.common.logging.ilogger-system.string-system.exception-system.string___yb2lv7)</dt><dd>Writes the diagnostic message at the `Error` level.</dd><dt>[Fatal(ILogger, string, Exception, string) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.fatal_net.adamec.lib.common.logging.ilogger-system.string-system.exception-system.string___zech9x)</dt><dd>Writes the diagnostic message at the `Fatal` level.</dd><dt>[Fatal&lt;TException&gt;(ILogger, string, Exception) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.fatal--1_net.adamec.lib.common.logging.ilogger-system.string-system.exception___1i44id8)</dt><dd>Writes the diagnostic message at the `Fatal` level. Creates and returns the exception of given type</dd><dt>[Fatal&lt;TException&gt;(ILogger, string, string, Exception) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.fatal--1_net.adamec.lib.common.logging.ilogger-system.string-system.string-system.exception___1lozfm8)</dt><dd>Writes the diagnostic message at the `Fatal` level. Creates and returns the exception of given type</dd><dt>[Error&lt;TException&gt;(ILogger, string, Exception) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.error--1_net.adamec.lib.common.logging.ilogger-system.string-system.exception___1i16h8s)</dt><dd>Writes the diagnostic message at the `Error` level. Creates and returns the exception of given type</dd><dt>[Error&lt;TException&gt;(ILogger, string, string, Exception) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.error--1_net.adamec.lib.common.logging.ilogger-system.string-system.string-system.exception___1473s)</dt><dd>Writes the diagnostic message at the `Error` level. Creates and returns the exception of given type</dd><dt>[Debug(ILogger, Dictionary&lt;string,object&gt;, string) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.debug_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.string___j9my8t)</dt><dd>Writes the diagnostic message at the `Debug` level.</dd><dt>[Info(ILogger, Dictionary&lt;string,object&gt;, string) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.info_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.string___q80pva)</dt><dd>Writes the diagnostic message at the `Info` level.</dd><dt>[Warn(ILogger, Dictionary&lt;string,object&gt;, string) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.warn_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.string___oq47e2)</dt><dd>Writes the diagnostic message at the `Warn` level.</dd><dt>[Error(ILogger, Dictionary&lt;string,object&gt;, string) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.error_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.string___cx87zg)</dt><dd>Writes the diagnostic message at the `Error` level.</dd><dt>[Fatal(ILogger, Dictionary&lt;string,object&gt;, string) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.fatal_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.string___1ron6v0)</dt><dd>Writes the diagnostic message at the `Fatal` level.</dd><dt>[Warn(ILogger, Dictionary&lt;string,object&gt;, Exception, string) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.warn_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___sahasq)</dt><dd>Writes the diagnostic message at the `Warn` level.</dd><dt>[Error(ILogger, Dictionary&lt;string,object&gt;, Exception, string) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.error_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___m1gnmw)</dt><dd>Writes the diagnostic message at the `Error` level.</dd><dt>[Fatal(ILogger, Dictionary&lt;string,object&gt;, Exception, string) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.fatal_net.adamec.lib.common.logging.ilogger-system.collections.generic.dictionary_system.string-system.object_-system.exception-system.string___1u2znd0)</dt><dd>Writes the diagnostic message at the `Fatal` level.</dd><dt>[LogIt(ILogger, LogLevel, string, string, Exception) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.logit_net.adamec.lib.common.logging.ilogger-nlog.loglevel-system.string-system.string-system.exception___rb1ido)</dt><dd>Writes the item (message with optional exception)  into the log</dd><dt>[LogIt(ILogger, LogLevel, Dictionary&lt;string,object&gt;, string, Exception) (Method)](#m-net.adamec.lib.common.logging.loggerextensions.logit_net.adamec.lib.common.logging.ilogger-nlog.loglevel-system.collections.generic.dictionary_system.string-system.object_-system.string-system.exception___1pbym9v)</dt><dd>Writes the item (message with optional event properties and exception)  into the log</dd></dl>


<strong>Sources</strong><dl><dt>Packages\RadCommons.logging.CommonLogging\_SourceOnlyPackage.cs</dt><dd></dd><dt>Packages\RadCommons.logging.CommonLogging\CommonLogging.cs</dt><dd></dd><dt>Packages\RadCommons.logging.CommonLogging\ILogger.cs</dt><dd></dd><dt>Packages\RadCommons.logging.CommonLogging\LoggerExtensions.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="src-only-package--RadCommons.utils.BaseDisposable" />  RadCommons.utils.BaseDisposable Source only package ##
<small>Tags: RadCommons           
Includes: None           
Declaring file: ackages\RadCommons.utils.BaseDisposable\BaseDisposable.cs</small>


Helper class for implementation of IDisposable types (Source only package).


<strong>Package members</strong><dl><dt>[BaseDisposable (Type)](#t-net.adamec.lib.common.utils.basedisposable__7s72ps)</dt><dd>Helper class for implementation of <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> types</dd><dt>[Disposed (Property)](#p-net.adamec.lib.common.utils.basedisposable.disposed__nxq2fp)</dt><dd>Flag whether the object is fully disposed</dd><dt>[DisposedManaged (Property)](#p-net.adamec.lib.common.utils.basedisposable.disposedmanaged__1pm7df6)</dt><dd>Flag whether the managed resources are disposed</dd><dt>[DisposedNative (Property)](#p-net.adamec.lib.common.utils.basedisposable.disposednative__fqjn7i)</dt><dd>Flag whether the native resources are disposed</dd><dt>[Dispose() (Method)](#m-net.adamec.lib.common.utils.basedisposable.dispose__6qe9ri)</dt><dd>Dispose the object</dd><dt>[Dispose(bool) (Method)](#m-net.adamec.lib.common.utils.basedisposable.dispose_system.boolean___1vzs8w4)</dt><dd>Internal implementation of dispose - free the managed and native resources using the respective methods</dd><dt>[DisposeManaged() (Method)](#m-net.adamec.lib.common.utils.basedisposable.disposemanaged__1ht3p85)</dt><dd>Dispose any disposable managed fields or properties.</dd><dt>[DisposeNative() (Method)](#m-net.adamec.lib.common.utils.basedisposable.disposenative__uaa3i9)</dt><dd>Dispose of COM objects, Handles, etc. Then set those objects to null.</dd><dt>[~BaseDisposable() (Method)](#m-net.adamec.lib.common.utils.basedisposable.finalize__1l3n8dl)</dt><dd></dd></dl>


<strong>Sources</strong><dl><dt>ackages\RadCommons.utils.BaseDisposable\BaseDisposable.cs</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 



