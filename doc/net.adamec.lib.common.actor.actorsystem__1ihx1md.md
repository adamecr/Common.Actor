#  RAD Actor System Documentation #
##  <a id="n-net.adamec.lib.common.actor.actorsystem__1ihx1md" />  net.adamec.lib.common.actor.actorsystem Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3) | public | Implementation of actor system | 
 | [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe) | internal | Message dispatched used by [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.actorsystem__1osgm3w) | 
 | [ActorSystemOptions](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j) | public | User defined configuration of [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3) | 
 | [ScheduledMessageInfo](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5) | internal | Scheduled message definition | 

 


###  Interfaces ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs) | public abstract | The Actor System published interface Provides access to options and system queues, supports the actor (de)registration, dispatcher management (start/stop) as well as message scheduling and synchronous (Request-Reply) messaging. | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3" />  ActorSystem Class ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Sources: actorsystem\ActorSystem.cs</small>


Implementation of actor system



```csharp
public class ActorSystem : BaseDisposable, IActorSystem
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.utils.BaseDisposable](net.adamec.lib.common.utils__7vdji9.md#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>, [net.adamec.lib.common.actor.actorsystem.IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Logger](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#f-net.adamec.lib.common.actor.actorsystem.actorsystem.logger__1fhxf7) | internal static |  | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorsByRef](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystem.actorsbyref__b06x73) | private | Dictionary of actors by actor reference | 
 | [DeadLetters](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystem.deadletters__1p4w7em) | public | Provides the access to dead letters queue | 
 | [Dispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystem.dispatcher__16sohre) | private | Reference to dispatcher used by actor system | 
 | [ErrorMessageQueue](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystem.errormessagequeue__kecg1b) | public | Provides the access to error messages queue | 
 | [Options](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystem.options__1qogkkh) | public | Returns the reference to current [ActorSystemOptions](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorSystem(ActorSystemOptions)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystem.-ctor_net.adamec.lib.common.actor.actorsystem.actorsystemoptions___1wtfo99) | public | [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3) constructor | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Ask(IActorRef, object, Type, int, bool)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystem.ask_net.adamec.lib.common.actor.actor.iactorref-system.object-system.type-system.int32-system.boolean___sxd0yo) | public | Sends a request <strong>message</strong> to <strong>recipient</strong> and waits for the response of required <strong>responseType</strong> . | 
 | [Ask&lt;T&gt;(IActorRef, object, int, bool)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystem.ask--1_net.adamec.lib.common.actor.actor.iactorref-system.object-system.int32-system.boolean___2dxd0s) | public | Sends a request <strong>message</strong> to <strong>recipient</strong> and waits for the response of type  . | 
 | [CancelScheduledMessage(string)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystem.cancelscheduledmessage_system.string___1w85qxn) | public | Cancels the scheduled message with given <strong>id</strong> - removes the message from list of the scheduled messages | 
 | [CancelScheduledMessages(IActorRef, Type)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystem.cancelscheduledmessages_net.adamec.lib.common.actor.actor.iactorref-system.type___sfq920) | public | Cancels all messages scheduled for <strong>recipient</strong> that are of given <strong>messageType</strong> - removes the messages from list of the scheduled messages | 
 | [DeRegisterActor(IActorRef)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystem.deregisteractor_net.adamec.lib.common.actor.actor.iactorref___1x86w27) | public | De-register actor identified by <strong>actorRef</strong> from the actor system If <strong>actorRef</strong> is not found within the actor system, WARN message is logged, but raises no error/exception | 
 | [DisposeManaged()](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystem.disposemanaged__162jz4w) | protected | Stops and disposes the [Dispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystem.dispatcher__16sohre) | 
 | [GetMailboxesWithMessages()](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystem.getmailboxeswithmessages__1oiw8zq) | internal | Returns the list of the mailboxes (internal actor references) that have at least one message and the actor is not being already processed | 
 | [RegisterActor(IActor, string)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystem.registeractor_net.adamec.lib.common.actor.actor.iactor-system.string___o3h1j1) | public | Registers the <strong>actor</strong> to actor system. Name of the actor should be unique, but this is not checked. Each actor must register first to be able to receive the messages within the actor system. | 
 | [ScheduleMessage(IActorRef, IActorRef, DateTime, object)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystem.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.datetime-system.object___1mc0hrz) | public | Schedule one-time <strong>message</strong> to be sent to <strong>recipient</strong> at given date and time | 
 | [ScheduleMessage(IActorRef, IActorRef, TimeSpan, object)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystem.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.timespan-system.object___kqn59b) | public | Schedule periodic <strong>message</strong> to be sent to <strong>recipient</strong> each <strong>period</strong> . | 
 | [Start()](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystem.start__zz3cpm) | public | Starts the message dispatcher (started by default within ActorSystem constructor) | 
 | [Stop()](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystem.stop__v7scp2) | public | Stops the message dispatcher (can be restarted using [Start()](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystem.start__zz3cpm) method) | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.actorsystem.actorsystem.logger__1fhxf7" />  ActorSystem.Logger Field ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>



```csharp
internal static ILogger Logger
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystem.actorsbyref__b06x73" />  ActorSystem.ActorsByRef Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Dictionary of actors by actor reference



```csharp
private ConcurrentDictionary<net.adamec.lib.common.actor.actor.IActorRef,net.adamec.lib.common.actor.actor.IActor> ActorsByRef { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent.concurrentdictionary-2" target="_blank" >System.Collections.Concurrent.ConcurrentDictionary&lt;net.adamec.lib.common.actor.actor.IActorRef,net.adamec.lib.common.actor.actor.IActor&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystem.deadletters__1p4w7em" />  ActorSystem.DeadLetters Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Provides the access to dead letters queue



```csharp
public IMessageQueue DeadLetters { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.queue.IMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)</dt><dd></dd></dl>Implements: [IActorSystem.DeadLetters](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.iactorsystem.deadletters__82oxzl)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystem.dispatcher__16sohre" />  ActorSystem.Dispatcher Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Reference to dispatcher used by actor system



```csharp
private ActorSystemDispatcher Dispatcher { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystem.errormessagequeue__kecg1b" />  ActorSystem.ErrorMessageQueue Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Provides the access to error messages queue



```csharp
public IMessageQueue ErrorMessageQueue { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.queue.IMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)</dt><dd></dd></dl>Implements: [IActorSystem.ErrorMessageQueue](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.iactorsystem.errormessagequeue__v9i6fy)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystem.options__1qogkkh" />  ActorSystem.Options Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Returns the reference to current [ActorSystemOptions](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)



```csharp
public ActorSystemOptions Options { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.ActorSystemOptions](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)</dt><dd></dd></dl>Implements: [IActorSystem.Options](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.iactorsystem.options__logleg)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.-ctor_net.adamec.lib.common.actor.actorsystem.actorsystemoptions___1wtfo99" />  ActorSystem.ActorSystem(ActorSystemOptions) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


[ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3) constructor



```csharp
public ActorSystem(ActorSystemOptions options)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.ActorSystemOptions](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j) <strong>options</strong></dt><dd>Actor system configuration options</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.ask_net.adamec.lib.common.actor.actor.iactorref-system.object-system.type-system.int32-system.boolean___sxd0yo" />  ActorSystem.Ask(IActorRef, object, Type, int, bool) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Sends a request <strong>message</strong> to <strong>recipient</strong> and waits for the response of required <strong>responseType</strong> .



```csharp
public object Ask(IActorRef recipient, object message, Type responseType, int timeoutMilliseconds, bool throwTimeoutException = false)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Reference to recipient actor</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Request message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>responseType</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message to wait for</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>timeoutMilliseconds</strong></dt><dd>Timeout for the response</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>throwTimeoutException</strong></dt><dd>If true, the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.timeoutexception" target="_blank" >System.TimeoutException</a> is raised, otherwise the default(T) response is returned</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd>The &quot;synchronous&quot; response</dd></dl>Implements: [IActorSystem.Ask(IActorRef, object, Type, int, bool)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.ask_net.adamec.lib.common.actor.actor.iactorref-system.object-system.type-system.int32-system.boolean___14ecl67)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.ask--1_net.adamec.lib.common.actor.actor.iactorref-system.object-system.int32-system.boolean___2dxd0s" />  ActorSystem.Ask&lt;T&gt;(IActorRef, object, int, bool) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Sends a request <strong>message</strong> to <strong>recipient</strong> and waits for the response of type  .



```csharp
public ActorSystem.T Ask<T>(IActorRef recipient, object message, int timeoutMilliseconds, bool throwTimeoutException = false)
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message to wait for</dd></dl>
<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Reference to recipient actor</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Request message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>timeoutMilliseconds</strong></dt><dd>Timeout for the response</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>throwTimeoutException</strong></dt><dd>If true, the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.timeoutexception" target="_blank" >System.TimeoutException</a> is raised, otherwise the default(T) response is returned</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.actor.actorsystem.ActorSystem.T</dt><dd>The &quot;synchronous&quot; response</dd></dl>Implements: [IActorSystem.Ask&lt;T&gt;(IActorRef, object, int, bool)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.ask--1_net.adamec.lib.common.actor.actor.iactorref-system.object-system.int32-system.boolean___1d7ni9h)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.cancelscheduledmessage_system.string___1w85qxn" />  ActorSystem.CancelScheduledMessage(string) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Cancels the scheduled message with given <strong>id</strong> - removes the message from list of the scheduled messages



```csharp
public bool CancelScheduledMessage(string id)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>id</strong></dt><dd>Unique ID of the scheduled message. When the id is not found, it&#39;s just ignored.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True if the message has been found and canceled, false when the message has not been found</dd></dl>Implements: [IActorSystem.CancelScheduledMessage(string)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.cancelscheduledmessage_system.string___bluqps)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.cancelscheduledmessages_net.adamec.lib.common.actor.actor.iactorref-system.type___sfq920" />  ActorSystem.CancelScheduledMessages(IActorRef, Type) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Cancels all messages scheduled for <strong>recipient</strong> that are of given <strong>messageType</strong> - removes the messages from list of the scheduled messages



```csharp
public bool CancelScheduledMessages(IActorRef recipient, Type messageType)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>The recipient of the scheduled messages to be canceled.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>messageType</strong></dt><dd>The type of the scheduled messages to be canceled.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True if at least one message has been found and canceled, false when none has been found</dd></dl>Implements: [IActorSystem.CancelScheduledMessages(IActorRef, Type)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.cancelscheduledmessages_net.adamec.lib.common.actor.actor.iactorref-system.type___c89uf5)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.deregisteractor_net.adamec.lib.common.actor.actor.iactorref___1x86w27" />  ActorSystem.DeRegisterActor(IActorRef) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


De-register actor identified by <strong>actorRef</strong> from the actor system If <strong>actorRef</strong> is not found within the actor system, WARN message is logged, but raises no error/exception



```csharp
public void DeRegisterActor(IActorRef actorRef)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to actor to be de-registered</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [IActorSystem.DeRegisterActor(IActorRef)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.deregisteractor_net.adamec.lib.common.actor.actor.iactorref___102bphm)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.disposemanaged__162jz4w" />  ActorSystem.DisposeManaged() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Stops and disposes the [Dispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystem.dispatcher__16sohre)



```csharp
protected override void DisposeManaged()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Overrides: [BaseDisposable.DisposeManaged()](net.adamec.lib.common.utils__7vdji9.md#m-net.adamec.lib.common.utils.basedisposable.disposemanaged__1ht3p85)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.getmailboxeswithmessages__1oiw8zq" />  ActorSystem.GetMailboxesWithMessages() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Returns the list of the mailboxes (internal actor references) that have at least one message and the actor is not being already processed



```csharp
internal List<net.adamec.lib.common.actor.actor.ActorRefInternal> GetMailboxesWithMessages()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.actor.actor.ActorRefInternal&gt;</a></dt><dd>List of mailboxes(internal actor references) having the messages for processing</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.registeractor_net.adamec.lib.common.actor.actor.iactor-system.string___o3h1j1" />  ActorSystem.RegisterActor(IActor, string) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Registers the <strong>actor</strong> to actor system. Name of the actor should be unique, but this is not checked. Each actor must register first to be able to receive the messages within the actor system.



```csharp
public IActorRef RegisterActor(IActor actor, string name)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi) <strong>actor</strong></dt><dd>Actor to be registered</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the actor. Name of the actor should be unique, but this is not checked. Name is mandatory and can&#39;t be empty</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd>Actor reference to the registered actor</dd></dl>Implements: [IActorSystem.RegisterActor(IActor, string)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.registeractor_net.adamec.lib.common.actor.actor.iactor-system.string___c4sh8g)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.datetime-system.object___1mc0hrz" />  ActorSystem.ScheduleMessage(IActorRef, IActorRef, DateTime, object) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Schedule one-time <strong>message</strong> to be sent to <strong>recipient</strong> at given date and time



```csharp
public string ScheduleMessage(IActorRef sender, IActorRef recipient, DateTime nextFire, object message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>Optional information about the sender, usually used by <strong>recipient</strong> to respond to the <strong>message</strong></dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Recipient of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.datetime" target="_blank" >DateTime</a> <strong>nextFire</strong></dt><dd>Date and time after which the message is enqueued to the <strong>recipient</strong> queue</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Message to be sent to the <strong>recipient</strong></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Unique ID of scheduled message</dd></dl>Implements: [IActorSystem.ScheduleMessage(IActorRef, IActorRef, DateTime, object)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.datetime-system.object___1o3fnac)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.timespan-system.object___kqn59b" />  ActorSystem.ScheduleMessage(IActorRef, IActorRef, TimeSpan, object) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Schedule periodic <strong>message</strong> to be sent to <strong>recipient</strong> each <strong>period</strong> .



```csharp
public string ScheduleMessage(IActorRef sender, IActorRef recipient, TimeSpan period, object message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>Optional information about the sender, usually used by <strong>recipient</strong> to respond to the <strong>message</strong></dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Recipient of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.timespan" target="_blank" >System.TimeSpan</a> <strong>period</strong></dt><dd>Period after which the message is periodically enqueued to the <strong>recipient</strong> queue</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Message to be periodically sent to the <strong>recipient</strong></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Unique ID of scheduled message</dd></dl>Implements: [IActorSystem.ScheduleMessage(IActorRef, IActorRef, TimeSpan, object)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.timespan-system.object___og1m84)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.start__zz3cpm" />  ActorSystem.Start() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Starts the message dispatcher (started by default within ActorSystem constructor)



```csharp
public void Start()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [IActorSystem.Start()](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.start__clajz5)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystem.stop__v7scp2" />  ActorSystem.Stop() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           
Sources: actorsystem\ActorSystem.cs</small>


Stops the message dispatcher (can be restarted using [Start()](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystem.start__zz3cpm) method)



```csharp
public void Stop()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [IActorSystem.Stop()](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.stop__dly8m5)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe" />  ActorSystemDispatcher Class ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Message dispatched used by [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.actorsystem__1osgm3w)



```csharp
internal class ActorSystemDispatcher : BaseDisposable
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.utils.BaseDisposable](net.adamec.lib.common.utils__7vdji9.md#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [isActive](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.isactive__1g6w74o) | private |  | 
 | [Logger](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.logger__1opp49m) | protected static |  | 
 | [MessageLogger](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.messagelogger__9fz30j) | protected static | Message logger | 
 | [scheduledMessagesLock](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.scheduledmessageslock__19elh26) | private |  | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.actorsystem__1osgm3w) | private |  | 
 | [ExecutorThread](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.executorthread__1a9snen) | private | Dispatcher executor thread | 
 | [IsActive](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.isactive__9h4ytm) | public | Flag whether the dispatcher is active (dispatching messages) | 
 | [Options](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.options__glvhoa) | protected | Actor System options | 
 | [ScheduledMessages](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.scheduledmessages__61sfpr) | private |  | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorSystemDispatcher(ActorSystem)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.-ctor_net.adamec.lib.common.actor.actorsystem.actorsystem___bl3uhi) | public | Initialize dispatcher | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CancelScheduledMessage(string)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.cancelscheduledmessage_system.string___1r5af14) | internal | Cancels the scheduled message with given <strong>id</strong> - removes the message from list of the scheduled messages | 
 | [CancelScheduledMessages(IActorRef, Type)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.cancelscheduledmessages_net.adamec.lib.common.actor.actor.iactorref-system.type___6bdh5j) | internal | Cancels all messages scheduled for <strong>recipient</strong> that are of given <strong>messageType</strong> - removes the messages from list of the scheduled messages | 
 | [DisposeManaged()](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.disposemanaged__121xst9) | protected | Stops the dispatched when disposing | 
 | [Execute(object)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.execute_system.object___q5nu8z) | private | Main dispatcher loop (runs within the [ExecutorThread](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.executorthread__1a9snen) ) The loop is active while [isActive](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.isactive__1g6w74o) is set to true, so setting [isActive](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.isactive__1g6w74o) to false forces the loop to exit Each run of the loop enqueue the due scheduled messages (if any) and process mailboxes (actors) with any pending messages. Actor (actor reference) is locked for processing and the task is scheduled in thread pool to process the actor&#39;s queue. The actor remains locked until the task is not finished, so it&#39;s not picked up by executor again during the processing | 
 | [GetScheduledMessagesDue()](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.getscheduledmessagesdue__5eu7es) | private | Gets the list of scheduled messages that should be enqueued (are due) When the scheduled message is periodic, the next fire time is calculated and a new instance of scheduled message is added to to schedule | 
 | [ProcessActorQueue(object)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.processactorqueue_system.object___1ifalnd) | private | Main actor queue processor - scheduled by executor within the thread pool for each eligible actor (actor ref) Processes the batch of the messages for given actor. The messages are being processed sequentially in FIFO order within the loop with following constraints - there are still messages in actor&#39;s queue - actor can receive the messages - the batch size (number of messages for single actor processed in one cycle) has not been reached - dispatcher is not stopped The messages are sent to current actor receive target | 
 | [ScheduleMessage(IActorRef, IActorRef, DateTime, object)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.datetime-system.object___6k32uw) | internal | Schedule one-time <strong>message</strong> to be sent to <strong>recipient</strong> at given date and time Creates the [ScheduledMessageInfo](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5) instance based on the parameters and let it add to the internal list of the scheduled messages | 
 | [ScheduleMessage(IActorRef, IActorRef, TimeSpan, object)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.timespan-system.object___vt99rw) | internal | Schedule periodic <strong>message</strong> to be sent to <strong>recipient</strong> each <strong>period</strong> . Creates the [ScheduledMessageInfo](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5) instance based on the parameters and let it add to the internal list of the scheduled messages | 
 | [ScheduleMessage(ScheduledMessageInfo)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.schedulemessage_net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo___1xwfair) | private | Get&#39;s the given [ScheduledMessageInfo](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5) and adds it to internal list of scheduled messages. | 
 | [Start()](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.start__2g0p6j) | public | Starts the dispatcher Creates the executor thread and starts processing the messages | 
 | [Stop()](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.stop__8jn5gr) | public | Stops the dispatcher Finish current processing and &quot;close&quot; the executor thread | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.isactive__1g6w74o" />  ActorSystemDispatcher.isActive Field ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>



```csharp
private volatile bool isActive
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.logger__1opp49m" />  ActorSystemDispatcher.Logger Field ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>



```csharp
protected static ILogger Logger
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.messagelogger__9fz30j" />  ActorSystemDispatcher.MessageLogger Field ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Message logger



```csharp
protected static ILogger MessageLogger
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.scheduledmessageslock__19elh26" />  ActorSystemDispatcher.scheduledMessagesLock Field ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>



```csharp
private readonly object scheduledMessagesLock
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.actorsystem__1osgm3w" />  ActorSystemDispatcher.ActorSystem Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>



```csharp
private ActorSystem ActorSystem { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.executorthread__1a9snen" />  ActorSystemDispatcher.ExecutorThread Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Dispatcher executor thread



```csharp
private Thread ExecutorThread { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.thread" target="_blank" >System.Threading.Thread</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.isactive__9h4ytm" />  ActorSystemDispatcher.IsActive Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Flag whether the dispatcher is active (dispatching messages)



```csharp
public bool IsActive { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.options__glvhoa" />  ActorSystemDispatcher.Options Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Actor System options



```csharp
protected ActorSystemOptions Options { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.ActorSystemOptions](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.scheduledmessages__61sfpr" />  ActorSystemDispatcher.ScheduledMessages Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>



```csharp
private List<net.adamec.lib.common.actor.actorsystem.ScheduledMessageInfo> ScheduledMessages { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.lib.common.actor.actorsystem.ScheduledMessageInfo&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.-ctor_net.adamec.lib.common.actor.actorsystem.actorsystem___bl3uhi" />  ActorSystemDispatcher.ActorSystemDispatcher(ActorSystem) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Initialize dispatcher



```csharp
public ActorSystemDispatcher(ActorSystem actorSystem)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3) <strong>actorSystem</strong></dt><dd>Actor System the dispatcher belongs to</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.cancelscheduledmessage_system.string___1r5af14" />  ActorSystemDispatcher.CancelScheduledMessage(string) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Cancels the scheduled message with given <strong>id</strong> - removes the message from list of the scheduled messages



```csharp
internal bool CancelScheduledMessage(string id)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>id</strong></dt><dd>Unique ID of the scheduled message. When the id is not found, it&#39;s just ignored.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True if the message has been found and canceled, false when the message has not been found</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.cancelscheduledmessages_net.adamec.lib.common.actor.actor.iactorref-system.type___6bdh5j" />  ActorSystemDispatcher.CancelScheduledMessages(IActorRef, Type) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Cancels all messages scheduled for <strong>recipient</strong> that are of given <strong>messageType</strong> - removes the messages from list of the scheduled messages



```csharp
internal bool CancelScheduledMessages(IActorRef recipient, Type messageType)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>The recipient of the scheduled messages to be canceled.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>messageType</strong></dt><dd>The type of the scheduled messages to be canceled.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True if at least one message has been found and canceled, false when none has been found</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.disposemanaged__121xst9" />  ActorSystemDispatcher.DisposeManaged() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Stops the dispatched when disposing



```csharp
protected override void DisposeManaged()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Overrides: [BaseDisposable.DisposeManaged()](net.adamec.lib.common.utils__7vdji9.md#m-net.adamec.lib.common.utils.basedisposable.disposemanaged__1ht3p85)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.execute_system.object___q5nu8z" />  ActorSystemDispatcher.Execute(object) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Main dispatcher loop (runs within the [ExecutorThread](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.executorthread__1a9snen) ) The loop is active while [isActive](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.isactive__1g6w74o) is set to true, so setting [isActive](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#f-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.isactive__1g6w74o) to false forces the loop to exit Each run of the loop enqueue the due scheduled messages (if any) and process mailboxes (actors) with any pending messages. Actor (actor reference) is locked for processing and the task is scheduled in thread pool to process the actor&#39;s queue. The actor remains locked until the task is not finished, so it&#39;s not picked up by executor again during the processing



```csharp
private void Execute(object actorSystemObj)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>actorSystemObj</strong></dt><dd>Actor System</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.getscheduledmessagesdue__5eu7es" />  ActorSystemDispatcher.GetScheduledMessagesDue() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Gets the list of scheduled messages that should be enqueued (are due) When the scheduled message is periodic, the next fire time is calculated and a new instance of scheduled message is added to to schedule



```csharp
private IEnumerable<net.adamec.lib.common.actor.actorsystem.ScheduledMessageInfo> GetScheduledMessagesDue()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;net.adamec.lib.common.actor.actorsystem.ScheduledMessageInfo&gt;</a></dt><dd>The list of scheduled messages that to be enqueued</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.processactorqueue_system.object___1ifalnd" />  ActorSystemDispatcher.ProcessActorQueue(object) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Main actor queue processor - scheduled by executor within the thread pool for each eligible actor (actor ref) Processes the batch of the messages for given actor. The messages are being processed sequentially in FIFO order within the loop with following constraints - there are still messages in actor&#39;s queue - actor can receive the messages - the batch size (number of messages for single actor processed in one cycle) has not been reached - dispatcher is not stopped The messages are sent to current actor receive target



```csharp
private void ProcessActorQueue(object actorRef)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>actorRef</strong></dt><dd>Actor to process</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.datetime-system.object___6k32uw" />  ActorSystemDispatcher.ScheduleMessage(IActorRef, IActorRef, DateTime, object) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Schedule one-time <strong>message</strong> to be sent to <strong>recipient</strong> at given date and time Creates the [ScheduledMessageInfo](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5) instance based on the parameters and let it add to the internal list of the scheduled messages



```csharp
internal string ScheduleMessage(IActorRef sender, IActorRef recipient, DateTime nextFire, object message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>Optional information about the sender, usually used by <strong>recipient</strong> to respond to the <strong>message</strong></dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Recipient of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.datetime" target="_blank" >DateTime</a> <strong>nextFire</strong></dt><dd>Date and time after which the message is enqueued to the <strong>recipient</strong> queue</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Message to be sent to the <strong>recipient</strong></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Unique ID of scheduled message</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.timespan-system.object___vt99rw" />  ActorSystemDispatcher.ScheduleMessage(IActorRef, IActorRef, TimeSpan, object) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Schedule periodic <strong>message</strong> to be sent to <strong>recipient</strong> each <strong>period</strong> . Creates the [ScheduledMessageInfo](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5) instance based on the parameters and let it add to the internal list of the scheduled messages



```csharp
internal string ScheduleMessage(IActorRef sender, IActorRef recipient, TimeSpan period, object message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>Optional information about the sender, usually used by <strong>recipient</strong> to respond to the <strong>message</strong></dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Recipient of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.timespan" target="_blank" >System.TimeSpan</a> <strong>period</strong></dt><dd>Period after which the message is enqueued to the <strong>recipient</strong> queue</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Message to be periodically sent to the <strong>recipient</strong></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Unique ID of scheduled message</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.schedulemessage_net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo___1xwfair" />  ActorSystemDispatcher.ScheduleMessage(ScheduledMessageInfo) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Get&#39;s the given [ScheduledMessageInfo](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5) and adds it to internal list of scheduled messages.



```csharp
private void ScheduleMessage(ScheduledMessageInfo msg)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.ScheduledMessageInfo](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5) <strong>msg</strong></dt><dd>Scheduled message description to be added to the internal list of scheduled messages.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.start__2g0p6j" />  ActorSystemDispatcher.Start() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Starts the dispatcher Creates the executor thread and starts processing the messages



```csharp
public void Start()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher.stop__8jn5gr" />  ActorSystemDispatcher.Stop() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemDispatcher](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemdispatcher__1p6wtbe)           
Sources: actorsystem\ActorSystemDispatcher.cs</small>


Stops the dispatcher Finish current processing and &quot;close&quot; the executor thread



```csharp
public void Stop()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j" />  ActorSystemOptions Class ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Sources: actorsystem\ActorSystemOptions.cs</small>


User defined configuration of [ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)



```csharp
public class ActorSystemOptions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Default](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.default__12pheto) | public static | Returns the default [ActorSystemOptions](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j) | 
 | [LogDispatchMessages](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.logdispatchmessages__b8w2y1) | public | If enabled, logs each message before dispatched to actor with DEBUG level (default false) | 
 | [LogEnqueuedMessages](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.logenqueuedmessages__1on1j1f) | public | If enabled, logs each enqueued message with DEBUG level (default false) | 
 | [LogNotHandledMessages](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.lognothandledmessages__982jd6) | public | If enabled, logs each not handled message with WARN level (default false) | 
 | [MaxDispatchMessagesInBatch](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.maxdispatchmessagesinbatch__47yvmi) | public | Defines the maximum number of messages send for processing to single actor during one cycle of ActorDispatcher executor  (default 10) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorSystemOptions()](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.-cctor__coeb0w) | private static | Static CTOR - initialize default options instance | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.default__12pheto" />  ActorSystemOptions.Default Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemOptions](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)           
Sources: actorsystem\ActorSystemOptions.cs</small>


Returns the default [ActorSystemOptions](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)



```csharp
public static ActorSystemOptions Default { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.ActorSystemOptions](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.logdispatchmessages__b8w2y1" />  ActorSystemOptions.LogDispatchMessages Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemOptions](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)           
Sources: actorsystem\ActorSystemOptions.cs</small>


If enabled, logs each message before dispatched to actor with DEBUG level (default false)



```csharp
public bool LogDispatchMessages { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.logenqueuedmessages__1on1j1f" />  ActorSystemOptions.LogEnqueuedMessages Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemOptions](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)           
Sources: actorsystem\ActorSystemOptions.cs</small>


If enabled, logs each enqueued message with DEBUG level (default false)



```csharp
public bool LogEnqueuedMessages { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.lognothandledmessages__982jd6" />  ActorSystemOptions.LogNotHandledMessages Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemOptions](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)           
Sources: actorsystem\ActorSystemOptions.cs</small>


If enabled, logs each not handled message with WARN level (default false)



```csharp
public bool LogNotHandledMessages { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.maxdispatchmessagesinbatch__47yvmi" />  ActorSystemOptions.MaxDispatchMessagesInBatch Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemOptions](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)           
Sources: actorsystem\ActorSystemOptions.cs</small>


Defines the maximum number of messages send for processing to single actor during one cycle of ActorDispatcher executor  (default 10)



```csharp
public int MaxDispatchMessagesInBatch { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.actorsystemoptions.-cctor__coeb0w" />  ActorSystemOptions.ActorSystemOptions() Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorSystemOptions](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)           
Sources: actorsystem\ActorSystemOptions.cs</small>


Static CTOR - initialize default options instance



```csharp
private static ActorSystemOptions()
```

Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5" />  ScheduledMessageInfo Class ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
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
 | [Id](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.id__d1ho0y) | internal | Unique ID of scheduled message | 
 | [Message](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.message__8wrme2) | internal | Message to be (periodically) sent to the [Recipient](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.recipient__9cyy92) | 
 | [NextFire](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.nextfire__16ekkf2) | internal | Date and Time after which the message is enqueued to the [Recipient](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.recipient__9cyy92) queue | 
 | [Period](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.period__v8c71e) | internal | Period after which the message is periodically enqueued to the [Recipient](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.recipient__9cyy92) queue. Null for non-periodic messages | 
 | [Recipient](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.recipient__9cyy92) | internal | Recipient of the message | 
 | [Sender](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.sender__1m7ejeu) | internal | Optional information about the sender, usually used by [Recipient](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.recipient__9cyy92) to respond to the [Message](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.message__8wrme2) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ScheduledMessageInfo(IActorRef, IActorRef, DateTime, object)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.-ctor_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.datetime-system.object___d10rbc) | internal | CTOR for one-time scheduled message info | 
 | [ScheduledMessageInfo(IActorRef, IActorRef, TimeSpan, object)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.-ctor_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.timespan-system.object___w2q5fc) | internal | CTOR for periodic scheduled message info | 
 | [ScheduledMessageInfo(ScheduledMessageInfo)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.-ctor_net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo___1cbqekh) | internal | CTOR for the new instance of scheduled message definition for existing periodic scheduled message Used when creating the definition of each new run of the periodic schedule. Copies the information from current definition and preservers the ID | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.id__d1ho0y" />  ScheduledMessageInfo.Id Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ScheduledMessageInfo](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5)           
Sources: actorsystem\ScheduledMessageInfo.cs</small>


Unique ID of scheduled message



```csharp
internal string Id { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.message__8wrme2" />  ScheduledMessageInfo.Message Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ScheduledMessageInfo](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5)           
Sources: actorsystem\ScheduledMessageInfo.cs</small>


Message to be (periodically) sent to the [Recipient](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.recipient__9cyy92)



```csharp
internal object Message { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.nextfire__16ekkf2" />  ScheduledMessageInfo.NextFire Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ScheduledMessageInfo](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5)           
Sources: actorsystem\ScheduledMessageInfo.cs</small>


Date and Time after which the message is enqueued to the [Recipient](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.recipient__9cyy92) queue



```csharp
internal DateTime NextFire { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.datetime" target="_blank" >DateTime</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.period__v8c71e" />  ScheduledMessageInfo.Period Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ScheduledMessageInfo](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5)           
Sources: actorsystem\ScheduledMessageInfo.cs</small>


Period after which the message is periodically enqueued to the [Recipient](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.recipient__9cyy92) queue. Null for non-periodic messages



```csharp
internal System.TimeSpan? Period { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1" target="_blank" >System.TimeSpan?</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.recipient__9cyy92" />  ScheduledMessageInfo.Recipient Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ScheduledMessageInfo](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5)           
Sources: actorsystem\ScheduledMessageInfo.cs</small>


Recipient of the message



```csharp
internal IActorRef Recipient { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.sender__1m7ejeu" />  ScheduledMessageInfo.Sender Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ScheduledMessageInfo](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5)           
Sources: actorsystem\ScheduledMessageInfo.cs</small>


Optional information about the sender, usually used by [Recipient](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.recipient__9cyy92) to respond to the [Message](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.message__8wrme2)



```csharp
internal IActorRef Sender { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.-ctor_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.datetime-system.object___d10rbc" />  ScheduledMessageInfo.ScheduledMessageInfo(IActorRef, IActorRef, DateTime, object) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ScheduledMessageInfo](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5)           
Sources: actorsystem\ScheduledMessageInfo.cs</small>


CTOR for one-time scheduled message info



```csharp
internal ScheduledMessageInfo(IActorRef sender, IActorRef recipient, DateTime nextFire, object message)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>Optional information about the sender, usually used by <strong>recipient</strong> to respond to the <strong>message</strong></dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Recipient of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.datetime" target="_blank" >DateTime</a> <strong>nextFire</strong></dt><dd>Date and time after which the message is enqueued to the <strong>recipient</strong> queue</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Message to be sent to the <strong>recipient</strong></dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.-ctor_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.timespan-system.object___w2q5fc" />  ScheduledMessageInfo.ScheduledMessageInfo(IActorRef, IActorRef, TimeSpan, object) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ScheduledMessageInfo](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5)           
Sources: actorsystem\ScheduledMessageInfo.cs</small>


CTOR for periodic scheduled message info



```csharp
internal ScheduledMessageInfo(IActorRef sender, IActorRef recipient, TimeSpan period, object message)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>Optional information about the sender, usually used by <strong>recipient</strong> to respond to the <strong>message</strong></dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Recipient of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.timespan" target="_blank" >System.TimeSpan</a> <strong>period</strong></dt><dd>Period after which the message is enqueued to the <strong>recipient</strong> queue</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Message to be periodically sent to the <strong>recipient</strong></dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo.-ctor_net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo___1cbqekh" />  ScheduledMessageInfo.ScheduledMessageInfo(ScheduledMessageInfo) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [ScheduledMessageInfo](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5)           
Sources: actorsystem\ScheduledMessageInfo.cs</small>


CTOR for the new instance of scheduled message definition for existing periodic scheduled message Used when creating the definition of each new run of the periodic schedule. Copies the information from current definition and preservers the ID



```csharp
internal ScheduledMessageInfo(ScheduledMessageInfo existingPeriodicScheduledMessageInfo)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.ScheduledMessageInfo](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.scheduledmessageinfo__ifn4s5) <strong>existingPeriodicScheduledMessageInfo</strong></dt><dd></dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs" />  IActorSystem Interface ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Sources: actorsystem\IActorSystem.cs</small>


The Actor System published interface Provides access to options and system queues, supports the actor (de)registration, dispatcher management (start/stop) as well as message scheduling and synchronous (Request-Reply) messaging.



```csharp
public interface IActorSystem
```

Implemented by: [net.adamec.lib.common.actor.actorsystem.ActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystem__2jlyi3)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DeadLetters](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.iactorsystem.deadletters__82oxzl) | public abstract | Provides the access to dead letters queue | 
 | [ErrorMessageQueue](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.iactorsystem.errormessagequeue__v9i6fy) | public abstract | Provides the access to error messages queue | 
 | [Options](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.iactorsystem.options__logleg) | public abstract | Returns the reference to current [ActorSystemOptions](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Ask(IActorRef, object, Type, int, bool)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.ask_net.adamec.lib.common.actor.actor.iactorref-system.object-system.type-system.int32-system.boolean___14ecl67) | public abstract | Sends a request <strong>message</strong> to <strong>recipient</strong> and waits for the response of required <strong>responseType</strong> . | 
 | [Ask&lt;T&gt;(IActorRef, object, int, bool)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.ask--1_net.adamec.lib.common.actor.actor.iactorref-system.object-system.int32-system.boolean___1d7ni9h) | public abstract | Sends a request <strong>message</strong> to <strong>recipient</strong> and waits for the response of type  . | 
 | [CancelScheduledMessage(string)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.cancelscheduledmessage_system.string___bluqps) | public abstract | Cancels the scheduled message with given <strong>id</strong> - removes the message from list of the scheduled messages | 
 | [CancelScheduledMessages(IActorRef, Type)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.cancelscheduledmessages_net.adamec.lib.common.actor.actor.iactorref-system.type___c89uf5) | public abstract | Cancels all messages scheduled for <strong>recipient</strong> that are of given <strong>messageType</strong> - removes the messages from list of the scheduled messages | 
 | [DeRegisterActor(IActorRef)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.deregisteractor_net.adamec.lib.common.actor.actor.iactorref___102bphm) | public abstract | De-register actor identified by <strong>actorRef</strong> from the actor system If <strong>actorRef</strong> is not found within the actor system, WARN message is logged, but raises no error/exception | 
 | [RegisterActor(IActor, string)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.registeractor_net.adamec.lib.common.actor.actor.iactor-system.string___c4sh8g) | public abstract | Registers the <strong>actor</strong> to actor system. Name of the actor should be unique, but this is not checked. Each actor must register first to be able to receive the messages within the actor system. | 
 | [ScheduleMessage(IActorRef, IActorRef, DateTime, object)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.datetime-system.object___1o3fnac) | public abstract | Schedule one-time <strong>message</strong> to be sent to <strong>recipient</strong> at given date and time | 
 | [ScheduleMessage(IActorRef, IActorRef, TimeSpan, object)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.timespan-system.object___og1m84) | public abstract | Schedule periodic <strong>message</strong> to be sent to <strong>recipient</strong> each <strong>period</strong> . | 
 | [Start()](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.start__clajz5) | public abstract | Starts the message dispatcher (started by default within ActorSystem constructor) | 
 | [Stop()](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.stop__dly8m5) | public abstract | Stops the message dispatcher (can be restarted using [Start()](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.start__clajz5) method) | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.iactorsystem.deadletters__82oxzl" />  IActorSystem.DeadLetters Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Provides the access to dead letters queue



```csharp
public abstract IMessageQueue DeadLetters { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.queue.IMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.iactorsystem.errormessagequeue__v9i6fy" />  IActorSystem.ErrorMessageQueue Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Provides the access to error messages queue



```csharp
public abstract IMessageQueue ErrorMessageQueue { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.queue.IMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actorsystem.iactorsystem.options__logleg" />  IActorSystem.Options Property ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Returns the reference to current [ActorSystemOptions](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)



```csharp
public abstract ActorSystemOptions Options { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.ActorSystemOptions](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.actorsystemoptions__1e8lf7j)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.iactorsystem.ask_net.adamec.lib.common.actor.actor.iactorref-system.object-system.type-system.int32-system.boolean___14ecl67" />  IActorSystem.Ask(IActorRef, object, Type, int, bool) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Sends a request <strong>message</strong> to <strong>recipient</strong> and waits for the response of required <strong>responseType</strong> .



```csharp
public abstract object Ask(IActorRef recipient, object message, Type responseType, int timeoutMilliseconds, bool throwTimeoutException = false)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Reference to recipient actor</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Request message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>responseType</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message to wait for</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>timeoutMilliseconds</strong></dt><dd>Timeout for the response</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>throwTimeoutException</strong></dt><dd>If true, the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.timeoutexception" target="_blank" >System.TimeoutException</a> is raised, otherwise the default(T) response is returned</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd>The &quot;synchronous&quot; response</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.iactorsystem.ask--1_net.adamec.lib.common.actor.actor.iactorref-system.object-system.int32-system.boolean___1d7ni9h" />  IActorSystem.Ask&lt;T&gt;(IActorRef, object, int, bool) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Sends a request <strong>message</strong> to <strong>recipient</strong> and waits for the response of type  .



```csharp
public abstract IActorSystem.T Ask<T>(IActorRef recipient, object message, int timeoutMilliseconds, bool throwTimeoutException = false)
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message to wait for</dd></dl>
<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Reference to recipient actor</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Request message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>timeoutMilliseconds</strong></dt><dd>Timeout for the response</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>throwTimeoutException</strong></dt><dd>If true, the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.timeoutexception" target="_blank" >System.TimeoutException</a> is raised, otherwise the default(T) response is returned</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.actor.actorsystem.IActorSystem.T</dt><dd>The &quot;synchronous&quot; response</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.iactorsystem.cancelscheduledmessage_system.string___bluqps" />  IActorSystem.CancelScheduledMessage(string) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Cancels the scheduled message with given <strong>id</strong> - removes the message from list of the scheduled messages



```csharp
public abstract bool CancelScheduledMessage(string id)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>id</strong></dt><dd>Unique ID of the scheduled message. When the id is not found, it&#39;s just ignored.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True if the message has been found and canceled, false when the message has not been found</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.iactorsystem.cancelscheduledmessages_net.adamec.lib.common.actor.actor.iactorref-system.type___c89uf5" />  IActorSystem.CancelScheduledMessages(IActorRef, Type) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Cancels all messages scheduled for <strong>recipient</strong> that are of given <strong>messageType</strong> - removes the messages from list of the scheduled messages



```csharp
public abstract bool CancelScheduledMessages(IActorRef recipient, Type messageType)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>The recipient of the scheduled messages to be canceled.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>messageType</strong></dt><dd>The type of the scheduled messages to be canceled.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True if at least one message has been found and canceled, false when none has been found</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.iactorsystem.deregisteractor_net.adamec.lib.common.actor.actor.iactorref___102bphm" />  IActorSystem.DeRegisterActor(IActorRef) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


De-register actor identified by <strong>actorRef</strong> from the actor system If <strong>actorRef</strong> is not found within the actor system, WARN message is logged, but raises no error/exception



```csharp
public abstract void DeRegisterActor(IActorRef actorRef)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to actor to be de-registered</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.iactorsystem.registeractor_net.adamec.lib.common.actor.actor.iactor-system.string___c4sh8g" />  IActorSystem.RegisterActor(IActor, string) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Registers the <strong>actor</strong> to actor system. Name of the actor should be unique, but this is not checked. Each actor must register first to be able to receive the messages within the actor system.



```csharp
public abstract IActorRef RegisterActor(IActor actor, string name)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi) <strong>actor</strong></dt><dd>Actor to be registered</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the actor. Name of the actor should be unique, but this is not checked. Name is mandatory and can&#39;t be empty</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd>Actor reference to the registered actor</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.iactorsystem.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.datetime-system.object___1o3fnac" />  IActorSystem.ScheduleMessage(IActorRef, IActorRef, DateTime, object) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Schedule one-time <strong>message</strong> to be sent to <strong>recipient</strong> at given date and time



```csharp
public abstract string ScheduleMessage(IActorRef sender, IActorRef recipient, DateTime nextFire, object message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>Optional information about the sender, usually used by <strong>recipient</strong> to respond to the <strong>message</strong></dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Recipient of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.datetime" target="_blank" >DateTime</a> <strong>nextFire</strong></dt><dd>Date and time after which the message is enqueued to the <strong>recipient</strong> queue</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Message to be sent to the <strong>recipient</strong></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Unique ID of scheduled message</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.iactorsystem.schedulemessage_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.timespan-system.object___og1m84" />  IActorSystem.ScheduleMessage(IActorRef, IActorRef, TimeSpan, object) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Schedule periodic <strong>message</strong> to be sent to <strong>recipient</strong> each <strong>period</strong> .



```csharp
public abstract string ScheduleMessage(IActorRef sender, IActorRef recipient, TimeSpan period, object message)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>Optional information about the sender, usually used by <strong>recipient</strong> to respond to the <strong>message</strong></dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Recipient of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.timespan" target="_blank" >System.TimeSpan</a> <strong>period</strong></dt><dd>Period after which the message is periodically enqueued to the <strong>recipient</strong> queue</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Message to be periodically sent to the <strong>recipient</strong></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Unique ID of scheduled message</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.iactorsystem.start__clajz5" />  IActorSystem.Start() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Starts the message dispatcher (started by default within ActorSystem constructor)



```csharp
public abstract void Start()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actorsystem.iactorsystem.stop__dly8m5" />  IActorSystem.Stop() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actorsystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#n-net.adamec.lib.common.actor.actorsystem__1ihx1md)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)           
Sources: actorsystem\IActorSystem.cs</small>


Stops the message dispatcher (can be restarted using [Start()](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.start__clajz5) method)



```csharp
public abstract void Stop()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 



