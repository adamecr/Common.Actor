#  RAD Actor System Documentation #
##  <a id="n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h" />  net.adamec.lib.common.actor.actor.exchanges.@base Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq) | public abstract | Exchange actor base class providing the common logic for implementation of exchanges - the actors routing the messages to another actors based on subscriptions. | 
 | [Subscription](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm) | public | Base exchange actor subscription | 
 | [SubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage__1d4egm1) | public | Base exchange actor subscription messages | 
 | [UnSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.unsubscriptionmessage__15gfzkw) | public | Base exchange actor un-subscription message | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt; Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
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
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.utils.BaseDisposable](net.adamec.lib.common.utils__7vdji9.md#t-net.adamec.lib.common.utils.basedisposable__7s72ps) -&gt; [net.adamec.lib.common.actor.actor.Actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actor__buuxwr)           
Derived: [net.adamec.lib.common.actor.actor.exchanges.single.SingleExchangeActor](net.adamec.lib.common.actor.actor.exchanges.single__6r83x4.md#t-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor__1q6rr7y), [net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeyExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor__1inw5x7), [net.adamec.lib.common.actor.actor.exchanges.typed.TypedMultiExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor__1rgmwat), [net.adamec.lib.common.actor.actor.exchanges.typed.TypedSingleExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor__i752da)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>, [net.adamec.lib.common.actor.actor.IActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Subscriptions](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#p-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptions__n0rnra) | protected | List of subscriptions | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;(IActorSystem, string)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___x732m3) | protected | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DistributeMessage(Envelope, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscription)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.distributemessage_net.adamec.lib.common.actor.message.envelope--0___10o2gwi) | protected | Distributes the message according to single <strong>subscription</strong> | 
 | [GetSubscriptionsForMessage(Envelope)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.getsubscriptionsformessage_net.adamec.lib.common.actor.message.envelope___1lba1kc) | protected | Returns the list of subscriptions that match the incoming <strong>envelope</strong> | 
 | [IsUnSubscribeMatch(ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscription, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TUnSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.isunsubscribematch_-0--2___87gny2) | protected | Checks whether the <strong>unSubscriptionMessage</strong> can unsubscribe the <strong>subscription</strong> (both related to the same actor) | 
 | [Receive(Envelope)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.receive_net.adamec.lib.common.actor.message.envelope___k7qhyb) | protected | Message handler The subscription/unsubscription messages are handled first, the other messages are matched to the existing subscriptions and distributed to matching subscribers | 
 | [ReplaceOnSubscribe(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref--1___16aaybh) | protected | Checks for the list of existing subscriptions that are to be replaced by the new subscription defined in <strong>subscriptionMessage</strong> The new subscription can replace the existing subscriptions of other actors.There is no &quot;signaling&quot; to the actors, that their subscription has been replaced (canceled). | 
 | [Start()](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.start__1sb73cd) | public | Starts the exchange actor | 
 | [Stop()](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.stop__1wazv35) | public | Stops the exchange actor | 
 | [Subscribe(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscribe_net.adamec.lib.common.actor.actor.iactorref--1___ajhl0) | protected | Processes the subscription message It first checks, whether the new subscription replaces any existing subscription by calling [ReplaceOnSubscribe(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref--1___16aaybh) . If the returned list is not empty, the replaces subscriptions are removed from the [Subscriptions](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#p-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptions__n0rnra) list. The [SubscriptionFactory(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref--1___hz2yob) is called to create the new instance of subscription and the subscription is added to the [Subscriptions](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#p-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptions__n0rnra) list. | 
 | [SubscriptionFactory(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref--1___hz2yob) | protected abstract | Creates a new subscription instance based on the <strong>subscriptionMessage</strong> | 
 | [UnSubscribe(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TUnSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.unsubscribe_net.adamec.lib.common.actor.actor.iactorref--2___198es5m) | protected | Processes the unsubscription message Checks the existing subscriptions of <strong>actorRef</strong> whether they match the <strong>unSubscriptionMessage</strong> and removes the matching ones from [Subscriptions](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#p-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptions__n0rnra) list. | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptions__n0rnra" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.Subscriptions Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


List of subscriptions



```csharp
protected List<TSubscription> Subscriptions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;TSubscription&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___x732m3" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;(IActorSystem, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


CTOR



```csharp
protected ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>(IActorSystem actorSystem, string name)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs) <strong>actorSystem</strong></dt><dd>Actor system</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the exchange actor</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.distributemessage_net.adamec.lib.common.actor.message.envelope--0___10o2gwi" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.DistributeMessage(Envelope, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscription) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


Distributes the message according to single <strong>subscription</strong>



```csharp
protected virtual void DistributeMessage(Envelope envelope, ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>.TSubscription subscription)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Message envelope</dd><dt>net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscription <strong>subscription</strong></dt><dd>Subscriptions matching the message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.getsubscriptionsformessage_net.adamec.lib.common.actor.message.envelope___1lba1kc" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.GetSubscriptionsForMessage(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


Returns the list of subscriptions that match the incoming <strong>envelope</strong>



```csharp
protected virtual ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>.TSubscription[] GetSubscriptionsForMessage(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Incoming message</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscription[]</dt><dd>List of subscriptions that match the incoming <strong>envelope</strong></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.isunsubscribematch_-0--2___87gny2" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.IsUnSubscribeMatch(ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscription, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TUnSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


Checks whether the <strong>unSubscriptionMessage</strong> can unsubscribe the <strong>subscription</strong> (both related to the same actor)



```csharp
protected virtual bool IsUnSubscribeMatch(ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>.TSubscription subscription, ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>.TUnSubscriptionMessage unSubscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscription <strong>subscription</strong></dt><dd>Existing subscription</dd><dt>net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TUnSubscriptionMessage <strong>unSubscriptionMessage</strong></dt><dd>UnSubscription message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Returns true when the <strong>unSubscriptionMessage</strong> unsubscribes the <strong>subscription</strong> , otherwise false is returned</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.receive_net.adamec.lib.common.actor.message.envelope___k7qhyb" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.Receive(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


Message handler The subscription/unsubscription messages are handled first, the other messages are matched to the existing subscriptions and distributed to matching subscribers



```csharp
protected override bool Receive(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Message envelope</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True if the messages has been handled, otherwise false</dd></dl>Overrides: [Actor.Receive(Envelope)](net.adamec.lib.common.actor.actor__1ldg5ba.md#m-net.adamec.lib.common.actor.actor.actor.receive_net.adamec.lib.common.actor.message.envelope___lic5c4)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref--1___16aaybh" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.ReplaceOnSubscribe(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


Checks for the list of existing subscriptions that are to be replaced by the new subscription defined in <strong>subscriptionMessage</strong> The new subscription can replace the existing subscriptions of other actors.There is no &quot;signaling&quot; to the actors, that their subscription has been replaced (canceled).



```csharp
protected virtual ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>.TSubscription[] ReplaceOnSubscribe(IActorRef actorRef, ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>.TSubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscription[]</dt><dd>List of existing subscriptions to be removed from the [Subscriptions](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#p-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptions__n0rnra) list</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.start__1sb73cd" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.Start() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


Starts the exchange actor



```csharp
public virtual void Start()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.stop__1wazv35" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.Stop() Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


Stops the exchange actor



```csharp
public virtual void Stop()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscribe_net.adamec.lib.common.actor.actor.iactorref--1___ajhl0" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.Subscribe(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


Processes the subscription message It first checks, whether the new subscription replaces any existing subscription by calling [ReplaceOnSubscribe(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref--1___16aaybh) . If the returned list is not empty, the replaces subscriptions are removed from the [Subscriptions](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#p-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptions__n0rnra) list. The [SubscriptionFactory(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref--1___hz2yob) is called to create the new instance of subscription and the subscription is added to the [Subscriptions](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#p-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptions__n0rnra) list.



```csharp
protected virtual void Subscribe(IActorRef actorRef, ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>.TSubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref--1___hz2yob" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.SubscriptionFactory(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


Creates a new subscription instance based on the <strong>subscriptionMessage</strong>



```csharp
protected abstract ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>.TSubscription SubscriptionFactory(IActorRef actorRef, ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>.TSubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscription</dt><dd>Subscription instance</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.unsubscribe_net.adamec.lib.common.actor.actor.iactorref--2___198es5m" />  ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.UnSubscribe(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TUnSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Sources: actor\exchanges\base\ExchangeActor.cs</small>


Processes the unsubscription message Checks the existing subscriptions of <strong>actorRef</strong> whether they match the <strong>unSubscriptionMessage</strong> and removes the matching ones from [Subscriptions](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#p-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptions__n0rnra) list.



```csharp
protected virtual void UnSubscribe(IActorRef actorRef, ExchangeActor<TSubscription,TSubscriptionMessage,TUnSubscriptionMessage>.TUnSubscriptionMessage unSubscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to unsubscribing actor</dd><dt>net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TUnSubscriptionMessage <strong>unSubscriptionMessage</strong></dt><dd>UnSubscription message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm" />  Subscription Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\base\Subscription.cs</small>


Base exchange actor subscription



```csharp
public class Subscription
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Derived: [net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ActorRef](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#p-net.adamec.lib.common.actor.actor.exchanges.base.subscription.actorref__4ba6je) | public | Reference to subscribed actor | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Subscription(IActorRef)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.subscription.-ctor_net.adamec.lib.common.actor.actor.iactorref___1vbtza6) | public | CTOR | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.exchanges.base.subscription.actorref__4ba6je" />  Subscription.ActorRef Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [Subscription](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm)           
Sources: actor\exchanges\base\Subscription.cs</small>


Reference to subscribed actor



```csharp
public IActorRef ActorRef { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.base.subscription.-ctor_net.adamec.lib.common.actor.actor.iactorref___1vbtza6" />  Subscription.Subscription(IActorRef) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Type: [Subscription](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm)           
Sources: actor\exchanges\base\Subscription.cs</small>


CTOR



```csharp
public Subscription(IActorRef actorRef)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribed actor</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage__1d4egm1" />  SubscriptionMessage Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\base\SubscriptionMessage.cs</small>


Base exchange actor subscription messages



```csharp
public class SubscriptionMessage
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Derived: [net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage__1hh0wlc)           



Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.base.unsubscriptionmessage__15gfzkw" />  UnSubscriptionMessage Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.@base](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#n-net.adamec.lib.common.actor.actor.exchanges.base__1g84l6h)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\base\SubscriptionMessage.cs</small>


Base exchange actor un-subscription message



```csharp
public class UnSubscriptionMessage
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Derived: [net.adamec.lib.common.actor.actor.exchanges.typed.TypedUnSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage__9g51i3)           



Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 



