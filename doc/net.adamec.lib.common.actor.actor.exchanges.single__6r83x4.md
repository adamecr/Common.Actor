#  RAD Actor System Documentation #
##  <a id="n-net.adamec.lib.common.actor.actor.exchanges.single__6r83x4" />  net.adamec.lib.common.actor.actor.exchanges.single Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [SingleExchangeActor](net.adamec.lib.common.actor.actor.exchanges.single__6r83x4.md#t-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor__1q6rr7y) | public | Exchange Actor with zero or one subscriber | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor__1q6rr7y" />  SingleExchangeActor Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.single](net.adamec.lib.common.actor.actor.exchanges.single__6r83x4.md#n-net.adamec.lib.common.actor.actor.exchanges.single__6r83x4)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\single\SingleExchangeActor.cs</small>


Exchange Actor with zero or one subscriber



```csharp
public class SingleExchangeActor : ExchangeActor<net.adamec.lib.common.actor.actor.exchanges.@base.Subscription,net.adamec.lib.common.actor.actor.exchanges.@base.SubscriptionMessage,net.adamec.lib.common.actor.actor.exchanges.@base.UnSubscriptionMessage>
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.utils.BaseDisposable](net.adamec.lib.common.utils__7vdji9.md#t-net.adamec.lib.common.utils.basedisposable__7s72ps) -&gt; [net.adamec.lib.common.actor.actor.Actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actor__buuxwr) -&gt; [net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;net.adamec.lib.common.actor.actor.exchanges.@base.Subscription,net.adamec.lib.common.actor.actor.exchanges.@base.SubscriptionMessage,net.adamec.lib.common.actor.actor.exchanges.@base.UnSubscriptionMessage&gt;](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>, [net.adamec.lib.common.actor.actor.IActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi)


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [SingleExchangeActor(IActorSystem, string)](net.adamec.lib.common.actor.actor.exchanges.single__6r83x4.md#m-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___1090o6d) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ReplaceOnSubscribe(IActorRef, SubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.single__6r83x4.md#m-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage___1t22f9h) | protected | Removes all existing subscription when a new subscription message arrives. | 
 | [SubscriptionFactory(IActorRef, SubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.single__6r83x4.md#m-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage___kht5cf) | protected | Creates a new [Subscription](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm) instance for incoming <strong>subscriptionMessage</strong> | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___1090o6d" />  SingleExchangeActor.SingleExchangeActor(IActorSystem, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.single](net.adamec.lib.common.actor.actor.exchanges.single__6r83x4.md#n-net.adamec.lib.common.actor.actor.exchanges.single__6r83x4)           
Assembly: net.adamec.lib.common.actor           
Type: [SingleExchangeActor](net.adamec.lib.common.actor.actor.exchanges.single__6r83x4.md#t-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor__1q6rr7y)           
Sources: actor\exchanges\single\SingleExchangeActor.cs</small>


CTOR



```csharp
public SingleExchangeActor(IActorSystem actorSystem, string name)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs) <strong>actorSystem</strong></dt><dd>Actor system</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the exchange actor</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage___1t22f9h" />  SingleExchangeActor.ReplaceOnSubscribe(IActorRef, SubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.single](net.adamec.lib.common.actor.actor.exchanges.single__6r83x4.md#n-net.adamec.lib.common.actor.actor.exchanges.single__6r83x4)           
Assembly: net.adamec.lib.common.actor           
Type: [SingleExchangeActor](net.adamec.lib.common.actor.actor.exchanges.single__6r83x4.md#t-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor__1q6rr7y)           
Sources: actor\exchanges\single\SingleExchangeActor.cs</small>


Removes all existing subscription when a new subscription message arrives.



```csharp
protected override Subscription[] ReplaceOnSubscribe(IActorRef actorRef, SubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.@base.SubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage__1d4egm1) <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.@base.Subscription[]](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm)</dt><dd>List of all existing subscriptions</dd></dl>Overrides: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.ReplaceOnSubscribe(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref--1___16aaybh)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage___kht5cf" />  SingleExchangeActor.SubscriptionFactory(IActorRef, SubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.single](net.adamec.lib.common.actor.actor.exchanges.single__6r83x4.md#n-net.adamec.lib.common.actor.actor.exchanges.single__6r83x4)           
Assembly: net.adamec.lib.common.actor           
Type: [SingleExchangeActor](net.adamec.lib.common.actor.actor.exchanges.single__6r83x4.md#t-net.adamec.lib.common.actor.actor.exchanges.single.singleexchangeactor__1q6rr7y)           
Sources: actor\exchanges\single\SingleExchangeActor.cs</small>


Creates a new [Subscription](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm) instance for incoming <strong>subscriptionMessage</strong>



```csharp
protected override Subscription SubscriptionFactory(IActorRef actorRef, SubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.@base.SubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage__1d4egm1) <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.@base.Subscription](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm)</dt><dd>Subscription instance</dd></dl>Overrides: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.SubscriptionFactory(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref--1___hz2yob)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 



