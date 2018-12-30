#  RAD Actor System Documentation #
##  <a id="n-net.adamec.lib.common.actor.actor__1ldg5ba" />  net.adamec.lib.common.actor.actor Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actor__buuxwr) | public abstract | Reference implementation of [IActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi) that can be simply inherited in own actors. It provides the automatic registration in constructor and de-registration while disposing. The actor reference is published via [Self](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actor.self__1kgayjx) property. | 
 | [ActorRefEmpty](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefempty__c8py9n) | public | Reference to empty virtual actor | 
 | [ActorRefInternal](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal) | internal | Internal implementation of actor reference. Encapsulates the mailbox (queue) for the actor | 
 | [ActorRefNameOnly](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefnameonly__eu2rbh) | public abstract | Base class for the virtual actors | 
 | [ActorRefs](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefs__17fr5vh) | public | Common references to virtual actors | 
 | [ActorRefSystem](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefsystem__43zotr) | public | Reference to system virtual actor | 
 | [SyncActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6) | internal | Internal actor used in [Ask(IActorRef, object, Type, int, bool)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.ask_net.adamec.lib.common.actor.actor.iactorref-system.object-system.type-system.int32-system.boolean___14ecl67) methods to implement Request-Reply pattern | 

 


###  Interfaces ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi) | public abstract | Actor interface | 
 | [IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) | public abstract | Reference to actor | 

 


###  Delegates ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Receive](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.receive__1adwyjn) | public | Delegate describing the recipient target (method processing the messages) | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.actor__buuxwr" />  Actor Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\Actor.cs</small>


Reference implementation of [IActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi) that can be simply inherited in own actors. It provides the automatic registration in constructor and de-registration while disposing. The actor reference is published via [Self](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actor.self__1kgayjx) property.



```csharp
public abstract class Actor : BaseDisposable, IActor
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.utils.BaseDisposable](net.adamec.lib.common.utils__7vdji9.md#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Derived: [net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>, [net.adamec.lib.common.actor.actor.IActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorSystem](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actor.actorsystem__1g6mmur) | protected | Actor system | 
 | [CanReceive](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actor.canreceive__19sq0hk) | public | Returns true if the actor can receive messages. If false, the messages will not be dispatched to the actor (they will still be enqueued to actor&#39;s mailbox) | 
 | [DropAllReceive](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actor.dropallreceive__1g3skf2) | protected | Message handler that drops all messages and returns false (unhandled) | 
 | [ReceiveTarget](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actor.receivetarget__rq6a5r) | public | Current method processing the messages (to where the messages are dispatched to) | 
 | [Self](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actor.self__1kgayjx) | public | Actor reference to self | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Actor(IActorSystem, string)](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.actor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___sft7zm) | protected | CTOR Registers the actor into <strong>actorSystem</strong> using given <strong>name</strong> Enables the message processing of the actor and sets the [ReceiveTarget](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actor.receivetarget__rq6a5r) to [Receive(Envelope)](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.actor.receive_net.adamec.lib.common.actor.message.envelope___lic5c4) method | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Become(Receive)](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.actor.become_net.adamec.lib.common.actor.actor.receive___cfu8bb) | protected | Switches the actor behavior by setting the message <strong>handler</strong> . When the <strong>handler</strong> is not set, [DropAllReceive](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actor.dropallreceive__1g3skf2) handler is used. | 
 | [BecomeDefault()](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.actor.becomedefault__gzylss) | protected | Switch the message handler to [Receive(Envelope)](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.actor.receive_net.adamec.lib.common.actor.message.envelope___lic5c4) method | 
 | [DisposeManaged()](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.actor.disposemanaged__m3e4v4) | protected | De-registers the actor from actor system | 
 | [Receive(Envelope)](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.actor.receive_net.adamec.lib.common.actor.message.envelope___lic5c4) | protected | Default message handler. | 
 | [Unhandled(Envelope)](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.actor.unhandled_net.adamec.lib.common.actor.message.envelope___1cb59zm) | protected | Helper for processing unhandled messages, returns false by default | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actor.actorsystem__1g6mmur" />  Actor.ActorSystem Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


Actor system



```csharp
protected IActorSystem ActorSystem { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actor.canreceive__19sq0hk" />  Actor.CanReceive Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


Returns true if the actor can receive messages. If false, the messages will not be dispatched to the actor (they will still be enqueued to actor&#39;s mailbox)



```csharp
public bool CanReceive { get; protected set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>Implements: [IActor.CanReceive](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.iactor.canreceive__f9x86f)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actor.dropallreceive__1g3skf2" />  Actor.DropAllReceive Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


Message handler that drops all messages and returns false (unhandled)



```csharp
protected Receive DropAllReceive { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.Receive](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.receive__1adwyjn)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actor.receivetarget__rq6a5r" />  Actor.ReceiveTarget Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


Current method processing the messages (to where the messages are dispatched to)



```csharp
public Receive ReceiveTarget { get; protected set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.Receive](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.receive__1adwyjn)</dt><dd></dd></dl>Implements: [IActor.ReceiveTarget](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.iactor.receivetarget__n44wdg)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actor.self__1kgayjx" />  Actor.Self Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


Actor reference to self



```csharp
public IActorRef Self { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___sft7zm" />  Actor.Actor(IActorSystem, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


CTOR Registers the actor into <strong>actorSystem</strong> using given <strong>name</strong> Enables the message processing of the actor and sets the [ReceiveTarget](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actor.receivetarget__rq6a5r) to [Receive(Envelope)](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.actor.receive_net.adamec.lib.common.actor.message.envelope___lic5c4) method



```csharp
protected Actor(IActorSystem actorSystem, string name)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs) <strong>actorSystem</strong></dt><dd>Actor system</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Actor name</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actor.become_net.adamec.lib.common.actor.actor.receive___cfu8bb" />  Actor.Become(Receive) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


Switches the actor behavior by setting the message <strong>handler</strong> . When the <strong>handler</strong> is not set, [DropAllReceive](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actor.dropallreceive__1g3skf2) handler is used.



```csharp
protected virtual void Become(Receive handler)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.Receive](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.receive__1adwyjn) <strong>handler</strong></dt><dd>New message handler</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actor.becomedefault__gzylss" />  Actor.BecomeDefault() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


Switch the message handler to [Receive(Envelope)](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.actor.receive_net.adamec.lib.common.actor.message.envelope___lic5c4) method



```csharp
protected virtual void BecomeDefault()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actor.disposemanaged__m3e4v4" />  Actor.DisposeManaged() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


De-registers the actor from actor system



```csharp
protected override void DisposeManaged()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Overrides: [BaseDisposable.DisposeManaged()](net.adamec.lib.common.utils__7vdji9.md#m-net.adamec.lib.common.utils.basedisposable.disposemanaged__1ht3p85)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actor.receive_net.adamec.lib.common.actor.message.envelope___lic5c4" />  Actor.Receive(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


Default message handler.



```csharp
protected virtual bool Receive(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Envelope with incoming message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True if handled, false if not handled. The default implementation calls [Unhandled(Envelope)](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.actor.unhandled_net.adamec.lib.common.actor.message.envelope___1cb59zm) method that returns false</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actor.unhandled_net.adamec.lib.common.actor.message.envelope___1cb59zm" />  Actor.Unhandled(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [Actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Sources: actor\Actor.cs</small>


Helper for processing unhandled messages, returns false by default



```csharp
protected virtual bool Unhandled(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Envelope with incoming message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Should return false for unhandled messages and true if message has been finally handled here</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.actorrefempty__c8py9n" />  ActorRefEmpty Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\IActorRef.cs</small>


Reference to empty virtual actor



```csharp
public class ActorRefEmpty : ActorRefNameOnly
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.actor.actor.ActorRefNameOnly](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefnameonly__eu2rbh)           
Implements: [net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Name](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actorrefempty.name__175l78m) | public | Name of the actor - [EMPTY] | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actorrefempty.name__175l78m" />  ActorRefEmpty.Name Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefEmpty](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefempty__c8py9n)           
Sources: actor\IActorRef.cs</small>


Name of the actor - [EMPTY]



```csharp
public override string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Overrides: [ActorRefNameOnly.Name](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actorrefnameonly.name__qk183e)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal" />  ActorRefInternal Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\ActorRefInternal.cs</small>


Internal implementation of actor reference. Encapsulates the mailbox (queue) for the actor



```csharp
internal class ActorRefInternal : IActorRef
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: [net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [actorSystem](net.adamec.lib.common.actor.actor__1ldg5ba.md#f-net.adamec.lib.common.actor.actor.actorrefinternal.actorsystem__vswqpr) | private | Actor systems | 
 | [isBeingProcessed](net.adamec.lib.common.actor.actor__1ldg5ba.md#f-net.adamec.lib.common.actor.actor.actorrefinternal.isbeingprocessed__15vnbvu) | private | Flag whether the actor (mailbox) is being processed | 
 | [isBeingProcessedLock](net.adamec.lib.common.actor.actor__1ldg5ba.md#f-net.adamec.lib.common.actor.actor.actorrefinternal.isbeingprocessedlock__1p7p9sp) | private | Log used for [isBeingProcessed](net.adamec.lib.common.actor.actor__1ldg5ba.md#f-net.adamec.lib.common.actor.actor.actorrefinternal.isbeingprocessed__15vnbvu) flag ensuring the thread safe operations | 
 | [MessageLogger](net.adamec.lib.common.actor.actor__1ldg5ba.md#f-net.adamec.lib.common.actor.actor.actorrefinternal.messagelogger__1vqsaru) | protected static |  | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actorrefinternal.actor__10pf4r2) | internal | Actor the reference belongs to | 
 | [IsBeingProcessed](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actorrefinternal.isbeingprocessed__1cq6t5g) | internal | Flag whether the actor (mailbox) is being processed | 
 | [Name](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actorrefinternal.name__1uhi1my) | public | Name of the actor | 
 | [Queue](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actorrefinternal.queue__2gyn6w) | internal | Actor&#39;s mailbox (message queue) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorRefInternal(IActor, string, IActorSystem)](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.actorrefinternal.-ctor_net.adamec.lib.common.actor.actor.iactor-system.string-net.adamec.lib.common.actor.actorsystem.iactorsystem___8db4dq) | internal | CTOR Creates the mailbox (queue) for the actor | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [LockForProcessing()](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.actorrefinternal.lockforprocessing__i64cop) | internal | Locks the actor for message processing | 
 | [ProcessingFinished()](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.actorrefinternal.processingfinished__cj3e9v) | internal | Unlocks the actor for message processing | 
 | [Tell(object, IActorRef, string)](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.actorrefinternal.tell_system.object-net.adamec.lib.common.actor.actor.iactorref-system.string___ggyubr) | public | Asynchronously delivers a message actor&#39;s mailbox in a non-blocking fashion. | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.actor.actorrefinternal.actorsystem__vswqpr" />  ActorRefInternal.actorSystem Field ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


Actor systems



```csharp
private readonly IActorSystem actorSystem
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.actor.actorrefinternal.isbeingprocessed__15vnbvu" />  ActorRefInternal.isBeingProcessed Field ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


Flag whether the actor (mailbox) is being processed



```csharp
private bool isBeingProcessed
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.actor.actorrefinternal.isbeingprocessedlock__1p7p9sp" />  ActorRefInternal.isBeingProcessedLock Field ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


Log used for [isBeingProcessed](net.adamec.lib.common.actor.actor__1ldg5ba.md#f-net.adamec.lib.common.actor.actor.actorrefinternal.isbeingprocessed__15vnbvu) flag ensuring the thread safe operations



```csharp
private readonly object isBeingProcessedLock
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.actor.actorrefinternal.messagelogger__1vqsaru" />  ActorRefInternal.MessageLogger Field ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>



```csharp
protected static ILogger MessageLogger
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.logging.ILogger](net.adamec.lib.common.logging__1g9pm29.md#t-net.adamec.lib.common.logging.ilogger__y2ollm)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actorrefinternal.actor__10pf4r2" />  ActorRefInternal.Actor Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


Actor the reference belongs to



```csharp
internal IActor Actor { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actorrefinternal.isbeingprocessed__1cq6t5g" />  ActorRefInternal.IsBeingProcessed Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


Flag whether the actor (mailbox) is being processed



```csharp
internal bool IsBeingProcessed { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actorrefinternal.name__1uhi1my" />  ActorRefInternal.Name Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


Name of the actor



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Implements: [IActorRef.Name](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.iactorref.name__1ukc8z4)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actorrefinternal.queue__2gyn6w" />  ActorRefInternal.Queue Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


Actor&#39;s mailbox (message queue)



```csharp
internal IMessageQueue Queue { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.queue.IMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actorrefinternal.-ctor_net.adamec.lib.common.actor.actor.iactor-system.string-net.adamec.lib.common.actor.actorsystem.iactorsystem___8db4dq" />  ActorRefInternal.ActorRefInternal(IActor, string, IActorSystem) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


CTOR Creates the mailbox (queue) for the actor



```csharp
internal ActorRefInternal(IActor actor, string name, IActorSystem actorSystem)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi) <strong>actor</strong></dt><dd>Actor</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the actor</dd><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs) <strong>actorSystem</strong></dt><dd>Actor system</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actorrefinternal.lockforprocessing__i64cop" />  ActorRefInternal.LockForProcessing() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


Locks the actor for message processing



```csharp
internal void LockForProcessing()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actorrefinternal.processingfinished__cj3e9v" />  ActorRefInternal.ProcessingFinished() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


Unlocks the actor for message processing



```csharp
internal void ProcessingFinished()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actorrefinternal.tell_system.object-net.adamec.lib.common.actor.actor.iactorref-system.string___ggyubr" />  ActorRefInternal.Tell(object, IActorRef, string) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefInternal](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal)           
Sources: actor\ActorRefInternal.cs</small>


Asynchronously delivers a message actor&#39;s mailbox in a non-blocking fashion.



```csharp
public void Tell(object message, IActorRef sender, string routingKey = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>The message to be sent to the actor.</dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>The sender of this message. Defaults to [Empty](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actorrefs.empty__6f5cpu) if left to `null` .</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>routingKey</strong></dt><dd>Optional routing key - additional information that can be used for routing/processing the message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [IActorRef.Tell(object, IActorRef, string)](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.iactorref.tell_system.object-net.adamec.lib.common.actor.actor.iactorref-system.string___1xlz161)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.actorrefnameonly__eu2rbh" />  ActorRefNameOnly Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\IActorRef.cs</small>


Base class for the virtual actors



```csharp
public abstract class ActorRefNameOnly : IActorRef
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Derived: [net.adamec.lib.common.actor.actor.ActorRefEmpty](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefempty__c8py9n), [net.adamec.lib.common.actor.actor.ActorRefSystem](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefsystem__43zotr)           
Implements: [net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Name](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actorrefnameonly.name__qk183e) | public abstract | Name of the actor | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Tell(object, IActorRef, string)](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.actorrefnameonly.tell_system.object-net.adamec.lib.common.actor.actor.iactorref-system.string___rh50yb) | public | Empty implementation of the [Tell(object, IActorRef, string)](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.iactorref.tell_system.object-net.adamec.lib.common.actor.actor.iactorref-system.string___1xlz161) for the virtual actors | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actorrefnameonly.name__qk183e" />  ActorRefNameOnly.Name Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefNameOnly](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefnameonly__eu2rbh)           
Sources: actor\IActorRef.cs</small>


Name of the actor



```csharp
public abstract string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Implements: [IActorRef.Name](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.iactorref.name__1ukc8z4)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actorrefnameonly.tell_system.object-net.adamec.lib.common.actor.actor.iactorref-system.string___rh50yb" />  ActorRefNameOnly.Tell(object, IActorRef, string) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefNameOnly](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefnameonly__eu2rbh)           
Sources: actor\IActorRef.cs</small>


Empty implementation of the [Tell(object, IActorRef, string)](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.iactorref.tell_system.object-net.adamec.lib.common.actor.actor.iactorref-system.string___1xlz161) for the virtual actors



```csharp
public void Tell(object message, IActorRef sender, string routingKey = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Ignored</dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>Ignored</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>routingKey</strong></dt><dd>Ignored</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [IActorRef.Tell(object, IActorRef, string)](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.iactorref.tell_system.object-net.adamec.lib.common.actor.actor.iactorref-system.string___1xlz161)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.actorrefs__17fr5vh" />  ActorRefs Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
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
 | [Empty](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actorrefs.empty__6f5cpu) | public static | Empty actor (means no real actor defined) | 
 | [System](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actorrefs.system__1y8lt0o) | public static | System actor (to be used internally if needed) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorRefs()](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.actorrefs.-cctor__1qfbqdk) | private static | Static CTOR - Creates the static references | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actorrefs.empty__6f5cpu" />  ActorRefs.Empty Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefs](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefs__17fr5vh)           
Sources: actor\IActorRef.cs</small>


Empty actor (means no real actor defined)



```csharp
public static IActorRef Empty { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actorrefs.system__1y8lt0o" />  ActorRefs.System Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefs](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefs__17fr5vh)           
Sources: actor\IActorRef.cs</small>


System actor (to be used internally if needed)



```csharp
public static IActorRef System { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.actorrefs.-cctor__1qfbqdk" />  ActorRefs.ActorRefs() Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefs](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefs__17fr5vh)           
Sources: actor\IActorRef.cs</small>


Static CTOR - Creates the static references



```csharp
private static ActorRefs()
```

Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.actorrefsystem__43zotr" />  ActorRefSystem Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\IActorRef.cs</small>


Reference to system virtual actor



```csharp
public class ActorRefSystem : ActorRefNameOnly
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.actor.actor.ActorRefNameOnly](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefnameonly__eu2rbh)           
Implements: [net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Name](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actorrefsystem.name__q7wot2) | public | Name of the actor - [SYSTEM] | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.actorrefsystem.name__q7wot2" />  ActorRefSystem.Name Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [ActorRefSystem](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefsystem__43zotr)           
Sources: actor\IActorRef.cs</small>


Name of the actor - [SYSTEM]



```csharp
public override string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Overrides: [ActorRefNameOnly.Name](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actorrefnameonly.name__qk183e)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6" />  SyncActor Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\SyncActor.cs</small>


Internal actor used in [Ask(IActorRef, object, Type, int, bool)](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#m-net.adamec.lib.common.actor.actorsystem.iactorsystem.ask_net.adamec.lib.common.actor.actor.iactorref-system.object-system.type-system.int32-system.boolean___14ecl67) methods to implement Request-Reply pattern



```csharp
internal class SyncActor : BaseDisposable, IActor
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.utils.BaseDisposable](net.adamec.lib.common.utils__7vdji9.md#t-net.adamec.lib.common.utils.basedisposable__7s72ps)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>, [net.adamec.lib.common.actor.actor.IActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorSystem](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.syncactor.actorsystem__1jy3biw) | private |  | 
 | [CanReceive](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.syncactor.canreceive__37hi1h) | public | Returns true if the actor can receive messages. If false, the messages will not be dispatched to the actor (they will still be enqueued to actor&#39;s mailbox) | 
 | [ReceiveTarget](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.syncactor.receivetarget__fqhb9w) | public | Current method processing the messages (to where the messages are dispatched to) | 
 | [Response](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.syncactor.response__1nj5lt1) | public | Response message envelope | 
 | [ResponseType](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.syncactor.responsetype__13oqz9h) | public | Expected response type | 
 | [Self](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.syncactor.self__7tb7a6) | public | Actor reference to self | 
 | [WaitHandle](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.syncactor.waithandle__8yoz6j) | public | Wait handle used to signal that the response has arrived | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [SyncActor(IActorSystem, Type, AutoResetEvent)](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.syncactor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.type-system.threading.autoresetevent___2ekqnh) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DisposeManaged()](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.syncactor.disposemanaged__1ldukpd) | protected | Deregisters itself from actor system | 
 | [Receive(Envelope)](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.syncactor.receive_net.adamec.lib.common.actor.message.envelope___1adxu0d) | protected | Message handler - waits for the message of required [ResponseType](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.syncactor.responsetype__13oqz9h) and when arrived, the message envelope is set to [Response](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.syncactor.response__1nj5lt1) and the [WaitHandle](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.syncactor.waithandle__8yoz6j) is set to signal the blocked &quot;parent&quot; thread that the response has been received. | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.syncactor.actorsystem__1jy3biw" />  SyncActor.ActorSystem Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [SyncActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6)           
Sources: actor\SyncActor.cs</small>



```csharp
private IActorSystem ActorSystem { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.syncactor.canreceive__37hi1h" />  SyncActor.CanReceive Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [SyncActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6)           
Sources: actor\SyncActor.cs</small>


Returns true if the actor can receive messages. If false, the messages will not be dispatched to the actor (they will still be enqueued to actor&#39;s mailbox)



```csharp
public bool CanReceive { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>Implements: [IActor.CanReceive](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.iactor.canreceive__f9x86f)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.syncactor.receivetarget__fqhb9w" />  SyncActor.ReceiveTarget Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [SyncActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6)           
Sources: actor\SyncActor.cs</small>


Current method processing the messages (to where the messages are dispatched to)



```csharp
public Receive ReceiveTarget { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.Receive](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.receive__1adwyjn)</dt><dd></dd></dl>Implements: [IActor.ReceiveTarget](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.iactor.receivetarget__n44wdg)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.syncactor.response__1nj5lt1" />  SyncActor.Response Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [SyncActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6)           
Sources: actor\SyncActor.cs</small>


Response message envelope



```csharp
public Envelope Response { get; private set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.syncactor.responsetype__13oqz9h" />  SyncActor.ResponseType Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [SyncActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6)           
Sources: actor\SyncActor.cs</small>


Expected response type



```csharp
public Type ResponseType { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.syncactor.self__7tb7a6" />  SyncActor.Self Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [SyncActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6)           
Sources: actor\SyncActor.cs</small>


Actor reference to self



```csharp
public IActorRef Self { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.syncactor.waithandle__8yoz6j" />  SyncActor.WaitHandle Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [SyncActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6)           
Sources: actor\SyncActor.cs</small>


Wait handle used to signal that the response has arrived



```csharp
public AutoResetEvent WaitHandle { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.autoresetevent" target="_blank" >System.Threading.AutoResetEvent</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.syncactor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.type-system.threading.autoresetevent___2ekqnh" />  SyncActor.SyncActor(IActorSystem, Type, AutoResetEvent) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [SyncActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6)           
Sources: actor\SyncActor.cs</small>


CTOR



```csharp
public SyncActor(IActorSystem actorSystem, Type responseType, AutoResetEvent waitHandle)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs) <strong>actorSystem</strong></dt><dd>Actor system</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>responseType</strong></dt><dd>Expected type of the response</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.autoresetevent" target="_blank" >System.Threading.AutoResetEvent</a> <strong>waitHandle</strong></dt><dd>Wait handle used to signal that the response has arrived</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.syncactor.disposemanaged__1ldukpd" />  SyncActor.DisposeManaged() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [SyncActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6)           
Sources: actor\SyncActor.cs</small>


Deregisters itself from actor system



```csharp
protected override void DisposeManaged()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Overrides: [BaseDisposable.DisposeManaged()](net.adamec.lib.common.utils__7vdji9.md#m-net.adamec.lib.common.utils.basedisposable.disposemanaged__1ht3p85)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.syncactor.receive_net.adamec.lib.common.actor.message.envelope___1adxu0d" />  SyncActor.Receive(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [SyncActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6)           
Sources: actor\SyncActor.cs</small>


Message handler - waits for the message of required [ResponseType](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.syncactor.responsetype__13oqz9h) and when arrived, the message envelope is set to [Response](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.syncactor.response__1nj5lt1) and the [WaitHandle](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.syncactor.waithandle__8yoz6j) is set to signal the blocked &quot;parent&quot; thread that the response has been received.



```csharp
protected virtual bool Receive(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Incoming message envelope</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True when message processed (handled) otherwise false</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.iactor__16hx1xi" />  IActor Interface ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\IActor.cs</small>


Actor interface



```csharp
public interface IActor
```

Implemented by: [net.adamec.lib.common.actor.actor.Actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actor__buuxwr), [net.adamec.lib.common.actor.actor.SyncActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.syncactor__cgt0u6), [net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq), [net.adamec.lib.common.actor.actor.exchanges.single.SingleExchangeActor](net.adamec.lib.common.actor.actor.exchanges.single__6r83x4.md#t-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor__1q6rr7y), [net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeyExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor__1inw5x7), [net.adamec.lib.common.actor.actor.exchanges.typed.TypedMultiExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor__1rgmwat), [net.adamec.lib.common.actor.actor.exchanges.typed.TypedSingleExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor__i752da)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CanReceive](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.iactor.canreceive__f9x86f) | public abstract | Returns true if the actor can receive messages. If false, the messages will not be dispatched to the actor (they will still be enqueued to actor&#39;s mailbox) | 
 | [ReceiveTarget](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.iactor.receivetarget__n44wdg) | public abstract | Current method processing the messages (to where the messages are dispatched to) | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.iactor.canreceive__f9x86f" />  IActor.CanReceive Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [IActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi)           
Sources: actor\IActor.cs</small>


Returns true if the actor can receive messages. If false, the messages will not be dispatched to the actor (they will still be enqueued to actor&#39;s mailbox)



```csharp
public abstract bool CanReceive { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.iactor.receivetarget__n44wdg" />  IActor.ReceiveTarget Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [IActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi)           
Sources: actor\IActor.cs</small>


Current method processing the messages (to where the messages are dispatched to)



```csharp
public abstract Receive ReceiveTarget { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.Receive](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.receive__1adwyjn)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.iactorref__63mbv" />  IActorRef Interface ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\IActorRef.cs</small>


Reference to actor



```csharp
public interface IActorRef
```

Implemented by: [net.adamec.lib.common.actor.actor.ActorRefInternal](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefinternal__1l1obal), [net.adamec.lib.common.actor.actor.ActorRefNameOnly](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefnameonly__eu2rbh), [net.adamec.lib.common.actor.actor.ActorRefEmpty](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefempty__c8py9n), [net.adamec.lib.common.actor.actor.ActorRefSystem](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actorrefsystem__43zotr)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Name](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.iactorref.name__1ukc8z4) | public abstract | Name of the actor | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Tell(object, IActorRef, string)](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.iactorref.tell_system.object-net.adamec.lib.common.actor.actor.iactorref-system.string___1xlz161) | public abstract | Asynchronously delivers a message to this [IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) in a non-blocking fashion. Uses &quot;at most once&quot; delivery semantics. | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.iactorref.name__1ukc8z4" />  IActorRef.Name Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)           
Sources: actor\IActorRef.cs</small>


Name of the actor



```csharp
public abstract string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.iactorref.tell_system.object-net.adamec.lib.common.actor.actor.iactorref-system.string___1xlz161" />  IActorRef.Tell(object, IActorRef, string) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Type: [IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)           
Sources: actor\IActorRef.cs</small>


Asynchronously delivers a message to this [IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) in a non-blocking fashion. Uses &quot;at most once&quot; delivery semantics.



```csharp
public abstract void Tell(object message, IActorRef sender, string routingKey = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>The message to be sent to the target.</dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>The sender of this message. Defaults to [Empty](net.adamec.lib.common.actor.actor__1ldg5ba.md#p-net.adamec.lib.common.actor.actor.actorrefs.empty__6f5cpu) if left to `null` .</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>routingKey</strong></dt><dd>Optional routing key - additional information that can be used for routing/processing the message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.receive__1adwyjn" />  Receive Delegate ##
<small>Namespace: [net.adamec.lib.common.actor.actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#n-net.adamec.lib.common.actor.actor__1ldg5ba)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\IActor.cs</small>


Delegate describing the recipient target (method processing the messages)



```csharp
public delegate bool Receive(Envelope envelope)
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Recipient&#39;s method processing the messages</dd></dl>


<strong>Delegate parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Message envelope</dd></dl>
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.delegate" target="_blank" >Delegate</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.multicastdelegate" target="_blank" >MulticastDelegate</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icloneable" target="_blank" >System.ICloneable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.iserializable" target="_blank" >System.Runtime.Serialization.ISerializable</a>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 



