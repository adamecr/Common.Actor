#  RAD Actor System Documentation #
##  <a id="n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao" />  net.adamec.lib.common.actor.actor.exchanges.typed Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RoutingKeyExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor__1inw5x7) | public | Exchange Actor with zero or more actors per message type with routing based also on routing key Subscriptions are per actor, type and routing key. Subscription filter gets the all subscriptions where message is instance of  filter type or its children and the routing keys match | 
 | [RoutingKeySubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0) | public | Subscription for exchanges that routes the messages based on their type and routing key | 
 | [RoutingKeySubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage__1h3lr73) | public | Subscription message for [RoutingKeySubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0) | 
 | [RoutingKeyUnSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage__emjdu2) | public | UnSubscription message for [RoutingKeySubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0) | 
 | [TypedMultiExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor__1rgmwat) | public | Exchange Actor with zero or more actors per message type Subscriptions are per actor and type. Subscription filter gets the all subscriptions where message is instance of  filter type or its children | 
 | [TypedSingleExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor__i752da) | public | Exchange Actor with zero or one actor per message type Subscriptions are per type. Subscription filter gets the exact type match and if not found, then first match where message is instance of  filter type or its children | 
 | [TypedSubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) | public | Subscription for exchanges that routes the messages based on their type | 
 | [TypedSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage__1hh0wlc) | public | Subscription message for [TypedSubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) | 
 | [TypedUnSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage__9g51i3) | public | UnSubscription message for [TypedSubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor__1inw5x7" />  RoutingKeyExchangeActor Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\typed\RoutingKeyExchangeActor.cs</small>


Exchange Actor with zero or more actors per message type with routing based also on routing key Subscriptions are per actor, type and routing key. Subscription filter gets the all subscriptions where message is instance of  filter type or its children and the routing keys match



```csharp
public class RoutingKeyExchangeActor : ExchangeActor<net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscription,net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscriptionMessage,net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeyUnSubscriptionMessage>
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.utils.BaseDisposable](net.adamec.lib.common.utils__7vdji9.md#t-net.adamec.lib.common.utils.basedisposable__7s72ps) -&gt; [net.adamec.lib.common.actor.actor.Actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actor__buuxwr) -&gt; [net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscription,net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscriptionMessage,net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeyUnSubscriptionMessage&gt;](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>, [net.adamec.lib.common.actor.actor.IActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi)


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RoutingKeyExchangeActor(IActorSystem, string)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___17ryw0k) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetSubscriptionsForMessage(Envelope)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.getsubscriptionsformessage_net.adamec.lib.common.actor.message.envelope___1iabgbj) | protected | Returns the list of subscriptions that match the incoming <strong>envelope</strong> The filter gets all matches where message is instance of  filter type or its children and the routing key matches the subscription | 
 | [IsRoutingKeyMatch(string, string)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.isroutingkeymatch_system.string-system.string___102orov) | protected | Checks whether the message routing key matches the subscription routing key The default implementation is for the exact match, override this method for more complex matching (for example regexp) | 
 | [IsUnSubscribeMatch(RoutingKeySubscription, RoutingKeyUnSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.isunsubscribematch_net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage___1qyhqkr) | protected | Checks whether the <strong>unSubscriptionMessage</strong> can unsubscribe the <strong>subscription</strong> (both related to the same actor) The match is when both <strong>subscription</strong> and <strong>unSubscriptionMessage</strong> use the same message type | 
 | [ReplaceOnSubscribe(IActorRef, RoutingKeySubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage___rj17km) | protected | Removes existing subscriptions for <strong>actorRef</strong> with the same &quot;subscription type&quot; when a new subscription message arrives. | 
 | [SubscriptionFactory(IActorRef, RoutingKeySubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage___3ufphk) | protected | Creates a new <em>net.adamec.lib.common.actor.actor.exchanges.typed.TypedRoutingKeySubscription</em> instance based on the <strong>subscriptionMessage</strong> | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___17ryw0k" />  RoutingKeyExchangeActor.RoutingKeyExchangeActor(IActorSystem, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeyExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor__1inw5x7)           
Sources: actor\exchanges\typed\RoutingKeyExchangeActor.cs</small>


CTOR



```csharp
public RoutingKeyExchangeActor(IActorSystem actorSystem, string name)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs) <strong>actorSystem</strong></dt><dd>Actor system</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the exchange actor</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.getsubscriptionsformessage_net.adamec.lib.common.actor.message.envelope___1iabgbj" />  RoutingKeyExchangeActor.GetSubscriptionsForMessage(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeyExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor__1inw5x7)           
Sources: actor\exchanges\typed\RoutingKeyExchangeActor.cs</small>


Returns the list of subscriptions that match the incoming <strong>envelope</strong> The filter gets all matches where message is instance of  filter type or its children and the routing key matches the subscription



```csharp
protected override RoutingKeySubscription[] GetSubscriptionsForMessage(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Incoming message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscription[]](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0)</dt><dd>List of subscriptions that match the incoming <strong>envelope</strong></dd></dl>Overrides: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.GetSubscriptionsForMessage(Envelope)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.getsubscriptionsformessage_net.adamec.lib.common.actor.message.envelope___1lba1kc)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.isroutingkeymatch_system.string-system.string___102orov" />  RoutingKeyExchangeActor.IsRoutingKeyMatch(string, string) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeyExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor__1inw5x7)           
Sources: actor\exchanges\typed\RoutingKeyExchangeActor.cs</small>


Checks whether the message routing key matches the subscription routing key The default implementation is for the exact match, override this method for more complex matching (for example regexp)



```csharp
protected virtual bool IsRoutingKeyMatch(string subscriptionRoutingKey, string messageRoutingKey)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>subscriptionRoutingKey</strong></dt><dd>Subscription routing key</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>messageRoutingKey</strong></dt><dd>Message routing key</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True when the message routing key matches the subscription routing key, otherwise false</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.isunsubscribematch_net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage___1qyhqkr" />  RoutingKeyExchangeActor.IsUnSubscribeMatch(RoutingKeySubscription, RoutingKeyUnSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeyExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor__1inw5x7)           
Sources: actor\exchanges\typed\RoutingKeyExchangeActor.cs</small>


Checks whether the <strong>unSubscriptionMessage</strong> can unsubscribe the <strong>subscription</strong> (both related to the same actor) The match is when both <strong>subscription</strong> and <strong>unSubscriptionMessage</strong> use the same message type



```csharp
protected override bool IsUnSubscribeMatch(RoutingKeySubscription subscription, RoutingKeyUnSubscriptionMessage unSubscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0) <strong>subscription</strong></dt><dd>Existing subscription</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeyUnSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage__emjdu2) <strong>unSubscriptionMessage</strong></dt><dd>UnSubscription message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Returns true when the <strong>unSubscriptionMessage</strong> unsubscribes the <strong>subscription</strong> , otherwise false is returned</dd></dl>Overrides: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.IsUnSubscribeMatch(ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscription, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TUnSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.isunsubscribematch_-0--2___87gny2)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage___rj17km" />  RoutingKeyExchangeActor.ReplaceOnSubscribe(IActorRef, RoutingKeySubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeyExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor__1inw5x7)           
Sources: actor\exchanges\typed\RoutingKeyExchangeActor.cs</small>


Removes existing subscriptions for <strong>actorRef</strong> with the same &quot;subscription type&quot; when a new subscription message arrives.



```csharp
protected override RoutingKeySubscription[] ReplaceOnSubscribe(IActorRef actorRef, RoutingKeySubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage__1h3lr73) <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscription[]](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0)</dt><dd>List of all existing subscriptions</dd></dl>Overrides: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.ReplaceOnSubscribe(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref--1___16aaybh)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage___3ufphk" />  RoutingKeyExchangeActor.SubscriptionFactory(IActorRef, RoutingKeySubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeyExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyexchangeactor__1inw5x7)           
Sources: actor\exchanges\typed\RoutingKeyExchangeActor.cs</small>


Creates a new <em>net.adamec.lib.common.actor.actor.exchanges.typed.TypedRoutingKeySubscription</em> instance based on the <strong>subscriptionMessage</strong>



```csharp
protected override RoutingKeySubscription SubscriptionFactory(IActorRef actorRef, RoutingKeySubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage__1h3lr73) <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0)</dt><dd>Subscription instance</dd></dl>Overrides: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.SubscriptionFactory(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref--1___hz2yob)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0" />  RoutingKeySubscription Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\typed\RoutingKeySubscription.cs</small>


Subscription for exchanges that routes the messages based on their type and routing key



```csharp
public class RoutingKeySubscription : TypedSubscription
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.actor.actor.exchanges.@base.Subscription](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm) -&gt; [net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RoutingKey](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#p-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription.routingkey__a5qax5) | public | Routing key filter (if null, matches all messages) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RoutingKeySubscription(Type, string, IActorRef)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription.-ctor_system.type-system.string-net.adamec.lib.common.actor.actor.iactorref___15anvd7) | public | CTOR | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription.routingkey__a5qax5" />  RoutingKeySubscription.RoutingKey Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeySubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0)           
Sources: actor\exchanges\typed\RoutingKeySubscription.cs</small>


Routing key filter (if null, matches all messages)



```csharp
public string RoutingKey { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription.-ctor_system.type-system.string-net.adamec.lib.common.actor.actor.iactorref___15anvd7" />  RoutingKeySubscription.RoutingKeySubscription(Type, string, IActorRef) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeySubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0)           
Sources: actor\exchanges\typed\RoutingKeySubscription.cs</small>


CTOR



```csharp
public RoutingKeySubscription(Type messageType, string routingKey, IActorRef actorRef)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>messageType</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>routingKey</strong></dt><dd>Routing key filter (if null, matches all messages)</dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribed actor</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage__1h3lr73" />  RoutingKeySubscriptionMessage Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\typed\RoutingKeySubscriptionMessage.cs</small>


Subscription message for [RoutingKeySubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0)



```csharp
public class RoutingKeySubscriptionMessage : TypedSubscriptionMessage
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.actor.actor.exchanges.@base.SubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage__1d4egm1) -&gt; [net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage__1hh0wlc)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RoutingKey](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#p-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage.routingkey__qsyr8a) | public | Routing key filter (if null, matches all messages) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RoutingKeySubscriptionMessage(Type, string)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage.-ctor_system.type-system.string___bzfl4x) | public | CTOR | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage.routingkey__qsyr8a" />  RoutingKeySubscriptionMessage.RoutingKey Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeySubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage__1h3lr73)           
Sources: actor\exchanges\typed\RoutingKeySubscriptionMessage.cs</small>


Routing key filter (if null, matches all messages)



```csharp
public string RoutingKey { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage.-ctor_system.type-system.string___bzfl4x" />  RoutingKeySubscriptionMessage.RoutingKeySubscriptionMessage(Type, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeySubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage__1h3lr73)           
Sources: actor\exchanges\typed\RoutingKeySubscriptionMessage.cs</small>


CTOR



```csharp
public RoutingKeySubscriptionMessage(Type messageType, string routingKey)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>messageType</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>routingKey</strong></dt><dd>Routing key filter (if null, matches all messages)</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage__emjdu2" />  RoutingKeyUnSubscriptionMessage Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\typed\RoutingKeySubscriptionMessage.cs</small>


UnSubscription message for [RoutingKeySubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0)



```csharp
public class RoutingKeyUnSubscriptionMessage : TypedUnSubscriptionMessage
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.actor.actor.exchanges.@base.UnSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.unsubscriptionmessage__15gfzkw) -&gt; [net.adamec.lib.common.actor.actor.exchanges.typed.TypedUnSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage__9g51i3)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RoutingKey](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#p-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage.routingkey__16ll9yd) | public | Routing key filter (if null, matches all messages) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RoutingKeyUnSubscriptionMessage(Type, string)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage.-ctor_system.type-system.string___1eem2s) | public | CTOR | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage.routingkey__16ll9yd" />  RoutingKeyUnSubscriptionMessage.RoutingKey Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeyUnSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage__emjdu2)           
Sources: actor\exchanges\typed\RoutingKeySubscriptionMessage.cs</small>


Routing key filter (if null, matches all messages)



```csharp
public string RoutingKey { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage.-ctor_system.type-system.string___1eem2s" />  RoutingKeyUnSubscriptionMessage.RoutingKeyUnSubscriptionMessage(Type, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [RoutingKeyUnSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage__emjdu2)           
Sources: actor\exchanges\typed\RoutingKeySubscriptionMessage.cs</small>


CTOR



```csharp
public RoutingKeyUnSubscriptionMessage(Type messageType, string routingKey)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>messageType</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>routingKey</strong></dt><dd>Routing key filter (if null, matches all messages)</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor__1rgmwat" />  TypedMultiExchangeActor Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\typed\TypedMultiExchangeActor.cs</small>


Exchange Actor with zero or more actors per message type Subscriptions are per actor and type. Subscription filter gets the all subscriptions where message is instance of  filter type or its children



```csharp
public class TypedMultiExchangeActor : ExchangeActor<net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription,net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscriptionMessage,net.adamec.lib.common.actor.actor.exchanges.typed.TypedUnSubscriptionMessage>
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.utils.BaseDisposable](net.adamec.lib.common.utils__7vdji9.md#t-net.adamec.lib.common.utils.basedisposable__7s72ps) -&gt; [net.adamec.lib.common.actor.actor.Actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actor__buuxwr) -&gt; [net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription,net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscriptionMessage,net.adamec.lib.common.actor.actor.exchanges.typed.TypedUnSubscriptionMessage&gt;](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>, [net.adamec.lib.common.actor.actor.IActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi)


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TypedMultiExchangeActor(IActorSystem, string)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___1l0lpb0) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetSubscriptionsForMessage(Envelope)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor.getsubscriptionsformessage_net.adamec.lib.common.actor.message.envelope___9uu8op) | protected | Returns the list of subscriptions that match the incoming <strong>envelope</strong> The filter gets all matches where message is instance of  filter type or its children | 
 | [IsUnSubscribeMatch(TypedSubscription, TypedUnSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor.isunsubscribematch_net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage___kjj5nt) | protected | Checks whether the <strong>unSubscriptionMessage</strong> can unsubscribe the <strong>subscription</strong> (both related to the same actor) The match is when both <strong>subscription</strong> and <strong>unSubscriptionMessage</strong> use the same message type | 
 | [ReplaceOnSubscribe(IActorRef, TypedSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage___1wvem41) | protected | Removes existing subscriptions for <strong>actorRef</strong> with the same &quot;subscription type&quot; when a new subscription message arrives. | 
 | [SubscriptionFactory(IActorRef, TypedSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage___10dtbmj) | protected | Creates a new [TypedSubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) instance based on the <strong>subscriptionMessage</strong> | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___1l0lpb0" />  TypedMultiExchangeActor.TypedMultiExchangeActor(IActorSystem, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedMultiExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor__1rgmwat)           
Sources: actor\exchanges\typed\TypedMultiExchangeActor.cs</small>


CTOR



```csharp
public TypedMultiExchangeActor(IActorSystem actorSystem, string name)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs) <strong>actorSystem</strong></dt><dd>Actor system</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the exchange actor</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor.getsubscriptionsformessage_net.adamec.lib.common.actor.message.envelope___9uu8op" />  TypedMultiExchangeActor.GetSubscriptionsForMessage(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedMultiExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor__1rgmwat)           
Sources: actor\exchanges\typed\TypedMultiExchangeActor.cs</small>


Returns the list of subscriptions that match the incoming <strong>envelope</strong> The filter gets all matches where message is instance of  filter type or its children



```csharp
protected override TypedSubscription[] GetSubscriptionsForMessage(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Incoming message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription[]](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)</dt><dd>List of subscriptions that match the incoming <strong>envelope</strong></dd></dl>Overrides: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.GetSubscriptionsForMessage(Envelope)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.getsubscriptionsformessage_net.adamec.lib.common.actor.message.envelope___1lba1kc)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor.isunsubscribematch_net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage___kjj5nt" />  TypedMultiExchangeActor.IsUnSubscribeMatch(TypedSubscription, TypedUnSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedMultiExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor__1rgmwat)           
Sources: actor\exchanges\typed\TypedMultiExchangeActor.cs</small>


Checks whether the <strong>unSubscriptionMessage</strong> can unsubscribe the <strong>subscription</strong> (both related to the same actor) The match is when both <strong>subscription</strong> and <strong>unSubscriptionMessage</strong> use the same message type



```csharp
protected override bool IsUnSubscribeMatch(TypedSubscription subscription, TypedUnSubscriptionMessage unSubscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) <strong>subscription</strong></dt><dd>Existing subscription</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedUnSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage__9g51i3) <strong>unSubscriptionMessage</strong></dt><dd>UnSubscription message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Returns true when the <strong>unSubscriptionMessage</strong> unsubscribes the <strong>subscription</strong> , otherwise false is returned</dd></dl>Overrides: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.IsUnSubscribeMatch(ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscription, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TUnSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.isunsubscribematch_-0--2___87gny2)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage___1wvem41" />  TypedMultiExchangeActor.ReplaceOnSubscribe(IActorRef, TypedSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedMultiExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor__1rgmwat)           
Sources: actor\exchanges\typed\TypedMultiExchangeActor.cs</small>


Removes existing subscriptions for <strong>actorRef</strong> with the same &quot;subscription type&quot; when a new subscription message arrives.



```csharp
protected override TypedSubscription[] ReplaceOnSubscribe(IActorRef actorRef, TypedSubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage__1hh0wlc) <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription[]](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)</dt><dd>List of all existing subscriptions</dd></dl>Overrides: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.ReplaceOnSubscribe(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref--1___16aaybh)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage___10dtbmj" />  TypedMultiExchangeActor.SubscriptionFactory(IActorRef, TypedSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedMultiExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedmultiexchangeactor__1rgmwat)           
Sources: actor\exchanges\typed\TypedMultiExchangeActor.cs</small>


Creates a new [TypedSubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) instance based on the <strong>subscriptionMessage</strong>



```csharp
protected override TypedSubscription SubscriptionFactory(IActorRef actorRef, TypedSubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage__1hh0wlc) <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)</dt><dd>Subscription instance</dd></dl>Overrides: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.SubscriptionFactory(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref--1___hz2yob)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor__i752da" />  TypedSingleExchangeActor Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\typed\TypedSingleExchangeActor.cs</small>


Exchange Actor with zero or one actor per message type Subscriptions are per type. Subscription filter gets the exact type match and if not found, then first match where message is instance of  filter type or its children



```csharp
public class TypedSingleExchangeActor : ExchangeActor<net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription,net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscriptionMessage,net.adamec.lib.common.actor.actor.exchanges.typed.TypedUnSubscriptionMessage>
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.utils.BaseDisposable](net.adamec.lib.common.utils__7vdji9.md#t-net.adamec.lib.common.utils.basedisposable__7s72ps) -&gt; [net.adamec.lib.common.actor.actor.Actor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.actor__buuxwr) -&gt; [net.adamec.lib.common.actor.actor.exchanges.@base.ExchangeActor&lt;net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription,net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscriptionMessage,net.adamec.lib.common.actor.actor.exchanges.typed.TypedUnSubscriptionMessage&gt;](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3__1p1cfiq)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>, [net.adamec.lib.common.actor.actor.IActor](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactor__16hx1xi)


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TypedSingleExchangeActor(IActorSystem, string)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___1nv1jk7) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetSubscriptionsForMessage(Envelope)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor.getsubscriptionsformessage_net.adamec.lib.common.actor.message.envelope___1pc989c) | protected | Returns the list of subscriptions that match the incoming <strong>envelope</strong> The filter gets the exact type match and if not found, then first match where message is instance of  filter type or its children Note: There can be only one subscription per message type | 
 | [IsUnSubscribeMatch(TypedSubscription, TypedUnSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor.isunsubscribematch_net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage___zk123g) | protected | Checks whether the <strong>unSubscriptionMessage</strong> can unsubscribe the <strong>subscription</strong> (both related to the same actor) The match is when both <strong>subscription</strong> and <strong>unSubscriptionMessage</strong> use the same message type | 
 | [ReplaceOnSubscribe(IActorRef, TypedSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage___azg7e0) | protected | Removes existing subscriptions with the same &quot;subscription type&quot; when a new subscription message arrives. | 
 | [SubscriptionFactory(IActorRef, TypedSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage___1dxxz9k) | protected | Creates a new [TypedSubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) instance based on the <strong>subscriptionMessage</strong> | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor.-ctor_net.adamec.lib.common.actor.actorsystem.iactorsystem-system.string___1nv1jk7" />  TypedSingleExchangeActor.TypedSingleExchangeActor(IActorSystem, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedSingleExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor__i752da)           
Sources: actor\exchanges\typed\TypedSingleExchangeActor.cs</small>


CTOR



```csharp
public TypedSingleExchangeActor(IActorSystem actorSystem, string name)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actorsystem.IActorSystem](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#t-net.adamec.lib.common.actor.actorsystem.iactorsystem__wkr3cs) <strong>actorSystem</strong></dt><dd>Actor system</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the exchange actor</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor.getsubscriptionsformessage_net.adamec.lib.common.actor.message.envelope___1pc989c" />  TypedSingleExchangeActor.GetSubscriptionsForMessage(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedSingleExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor__i752da)           
Sources: actor\exchanges\typed\TypedSingleExchangeActor.cs</small>


Returns the list of subscriptions that match the incoming <strong>envelope</strong> The filter gets the exact type match and if not found, then first match where message is instance of  filter type or its children Note: There can be only one subscription per message type



```csharp
protected override TypedSubscription[] GetSubscriptionsForMessage(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Incoming message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription[]](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)</dt><dd>List of subscriptions that match the incoming <strong>envelope</strong></dd></dl>Overrides: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.GetSubscriptionsForMessage(Envelope)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.getsubscriptionsformessage_net.adamec.lib.common.actor.message.envelope___1lba1kc)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor.isunsubscribematch_net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage___zk123g" />  TypedSingleExchangeActor.IsUnSubscribeMatch(TypedSubscription, TypedUnSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedSingleExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor__i752da)           
Sources: actor\exchanges\typed\TypedSingleExchangeActor.cs</small>


Checks whether the <strong>unSubscriptionMessage</strong> can unsubscribe the <strong>subscription</strong> (both related to the same actor) The match is when both <strong>subscription</strong> and <strong>unSubscriptionMessage</strong> use the same message type



```csharp
protected override bool IsUnSubscribeMatch(TypedSubscription subscription, TypedUnSubscriptionMessage unSubscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) <strong>subscription</strong></dt><dd>Existing subscription</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedUnSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage__9g51i3) <strong>unSubscriptionMessage</strong></dt><dd>UnSubscription message</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Returns true when the <strong>unSubscriptionMessage</strong> unsubscribes the <strong>subscription</strong> , otherwise false is returned</dd></dl>Overrides: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.IsUnSubscribeMatch(ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscription, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TUnSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.isunsubscribematch_-0--2___87gny2)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage___azg7e0" />  TypedSingleExchangeActor.ReplaceOnSubscribe(IActorRef, TypedSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedSingleExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor__i752da)           
Sources: actor\exchanges\typed\TypedSingleExchangeActor.cs</small>


Removes existing subscriptions with the same &quot;subscription type&quot; when a new subscription message arrives.



```csharp
protected override TypedSubscription[] ReplaceOnSubscribe(IActorRef actorRef, TypedSubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage__1hh0wlc) <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription[]](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)</dt><dd>List of all existing subscriptions</dd></dl>Overrides: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.ReplaceOnSubscribe(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.replaceonsubscribe_net.adamec.lib.common.actor.actor.iactorref--1___16aaybh)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage___1dxxz9k" />  TypedSingleExchangeActor.SubscriptionFactory(IActorRef, TypedSubscriptionMessage) Method ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedSingleExchangeActor](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsingleexchangeactor__i752da)           
Sources: actor\exchanges\typed\TypedSingleExchangeActor.cs</small>


Creates a new [TypedSubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b) instance based on the <strong>subscriptionMessage</strong>



```csharp
protected override TypedSubscription SubscriptionFactory(IActorRef actorRef, TypedSubscriptionMessage subscriptionMessage)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribing actor</dd><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage__1hh0wlc) <strong>subscriptionMessage</strong></dt><dd>Subscription message</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.actor.exchanges.typed.TypedSubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)</dt><dd>Subscription instance</dd></dl>Overrides: [ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.SubscriptionFactory(IActorRef, ExchangeActor&lt;TSubscription,TSubscriptionMessage,TUnSubscriptionMessage&gt;.TSubscriptionMessage)](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#m-net.adamec.lib.common.actor.actor.exchanges.base.exchangeactor-3.subscriptionfactory_net.adamec.lib.common.actor.actor.iactorref--1___hz2yob)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b" />  TypedSubscription Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\typed\TypedSubscription.cs</small>


Subscription for exchanges that routes the messages based on their type



```csharp
public class TypedSubscription : Subscription
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.actor.actor.exchanges.@base.Subscription](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.subscription__1q5jclm)           
Derived: [net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscription__1t32gw0)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MessageType](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#p-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription.messagetype__1os7ees) | public | <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TypedSubscription(Type, IActorRef)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription.-ctor_system.type-net.adamec.lib.common.actor.actor.iactorref___vgut5o) | public | CTOR | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription.messagetype__1os7ees" />  TypedSubscription.MessageType Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedSubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)           
Sources: actor\exchanges\typed\TypedSubscription.cs</small>


<a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message



```csharp
public Type MessageType { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription.-ctor_system.type-net.adamec.lib.common.actor.actor.iactorref___vgut5o" />  TypedSubscription.TypedSubscription(Type, IActorRef) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedSubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)           
Sources: actor\exchanges\typed\TypedSubscription.cs</small>


CTOR



```csharp
public TypedSubscription(Type messageType, IActorRef actorRef)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>messageType</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message</dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>actorRef</strong></dt><dd>Reference to subscribed actor</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage__1hh0wlc" />  TypedSubscriptionMessage Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\typed\TypedSubscriptionMessage.cs</small>


Subscription message for [TypedSubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)



```csharp
public class TypedSubscriptionMessage : SubscriptionMessage
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.actor.actor.exchanges.@base.SubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.subscriptionmessage__1d4egm1)           
Derived: [net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeySubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeysubscriptionmessage__1h3lr73)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MessageType](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#p-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage.messagetype__kfnrfx) | public | <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TypedSubscriptionMessage(Type)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage.-ctor_system.type___6y7fn4) | public | CTOR | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage.messagetype__kfnrfx" />  TypedSubscriptionMessage.MessageType Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage__1hh0wlc)           
Sources: actor\exchanges\typed\TypedSubscriptionMessage.cs</small>


<a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message



```csharp
public Type MessageType { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage.-ctor_system.type___6y7fn4" />  TypedSubscriptionMessage.TypedSubscriptionMessage(Type) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscriptionmessage__1hh0wlc)           
Sources: actor\exchanges\typed\TypedSubscriptionMessage.cs</small>


CTOR



```csharp
public TypedSubscriptionMessage(Type messageType)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>messageType</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage__9g51i3" />  TypedUnSubscriptionMessage Class ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Sources: actor\exchanges\typed\TypedSubscriptionMessage.cs</small>


UnSubscription message for [TypedSubscription](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedsubscription__otg9b)



```csharp
public class TypedUnSubscriptionMessage : UnSubscriptionMessage
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.actor.actor.exchanges.@base.UnSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.@base__1g84l6h.md#t-net.adamec.lib.common.actor.actor.exchanges.base.unsubscriptionmessage__15gfzkw)           
Derived: [net.adamec.lib.common.actor.actor.exchanges.typed.RoutingKeyUnSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.routingkeyunsubscriptionmessage__emjdu2)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MessageType](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#p-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage.messagetype__1i0fwqk) | public | <a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TypedUnSubscriptionMessage(Type)](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#m-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage.-ctor_system.type___1lj7u7r) | public | CTOR | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage.messagetype__1i0fwqk" />  TypedUnSubscriptionMessage.MessageType Property ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedUnSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage__9g51i3)           
Sources: actor\exchanges\typed\TypedSubscriptionMessage.cs</small>


<a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message



```csharp
public Type MessageType { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage.-ctor_system.type___1lj7u7r" />  TypedUnSubscriptionMessage.TypedUnSubscriptionMessage(Type) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.actor.exchanges.typed](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#n-net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao)           
Assembly: net.adamec.lib.common.actor           
Type: [TypedUnSubscriptionMessage](net.adamec.lib.common.actor.actor.exchanges.typed__1mtmrao.md#t-net.adamec.lib.common.actor.actor.exchanges.typed.typedunsubscriptionmessage__9g51i3)           
Sources: actor\exchanges\typed\TypedSubscriptionMessage.cs</small>


CTOR



```csharp
public TypedUnSubscriptionMessage(Type messageType)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>messageType</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> of the message</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 



