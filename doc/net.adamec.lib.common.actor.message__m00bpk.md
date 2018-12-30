#  RAD Actor System Documentation #
##  <a id="n-net.adamec.lib.common.actor.message__m00bpk" />  net.adamec.lib.common.actor.message Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) | public | Message envelope | 
 | [ErrorMessage](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.errormessage__1gj1wb) | public | Specialized [Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) for messages in [ErrorMessageQueue](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.iactorsystem.errormessagequeue__v9i6fy) | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.message.envelope__5oxc3s" />  Envelope Class ##
<small>Namespace: [net.adamec.lib.common.actor.message](net.adamec.lib.common.actor.message__m00bpk.md#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Sources: message\Envelope.cs</small>


Message envelope



```csharp
public class Envelope
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Derived: [net.adamec.lib.common.actor.message.ErrorMessage](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.errormessage__1gj1wb)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CorrelationId](net.adamec.lib.common.actor.message__m00bpk.md#p-net.adamec.lib.common.actor.message.envelope.correlationid__1b0zym1) | public | Correlation ID used to identify the message (envelope) | 
 | [CreatedOn](net.adamec.lib.common.actor.message__m00bpk.md#p-net.adamec.lib.common.actor.message.envelope.createdon__1kpt9ip) | public | Timestamp when the envelope has been created | 
 | [Message](net.adamec.lib.common.actor.message__m00bpk.md#p-net.adamec.lib.common.actor.message.envelope.message__j08krj) | public | Message | 
 | [Recipient](net.adamec.lib.common.actor.message__m00bpk.md#p-net.adamec.lib.common.actor.message.envelope.recipient__1fcsz7b) | public | Message recipient | 
 | [RoutingKey](net.adamec.lib.common.actor.message__m00bpk.md#p-net.adamec.lib.common.actor.message.envelope.routingkey__1t0mr4v) | public | Optional routing key that can be used by actors (as &quot;a parameter outside the message&quot;) | 
 | [Sender](net.adamec.lib.common.actor.message__m00bpk.md#p-net.adamec.lib.common.actor.message.envelope.sender__154pdc7) | public | Message sender | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Envelope(Envelope)](net.adamec.lib.common.actor.message__m00bpk.md#m-net.adamec.lib.common.actor.message.envelope.-ctor_net.adamec.lib.common.actor.message.envelope___1a00gop) | protected | CTOR - creates the exact copy of <strong>original</strong> message including the [CorrelationId](net.adamec.lib.common.actor.message__m00bpk.md#p-net.adamec.lib.common.actor.message.envelope.correlationid__1b0zym1) and [CreatedOn](net.adamec.lib.common.actor.message__m00bpk.md#p-net.adamec.lib.common.actor.message.envelope.createdon__1kpt9ip) timestamp | 
 | [Envelope(IActorRef, IActorRef, object, string)](net.adamec.lib.common.actor.message__m00bpk.md#m-net.adamec.lib.common.actor.message.envelope.-ctor_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.object-system.string___k4a7n5) | internal | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ForwardTo(IActorRef)](net.adamec.lib.common.actor.message__m00bpk.md#m-net.adamec.lib.common.actor.message.envelope.forwardto_net.adamec.lib.common.actor.actor.iactorref___qf18qp) | public | Forwards the message to another recipient. Keeps the original message, sender and routing key. | 
 | [ForwardTo(IActorRef, string)](net.adamec.lib.common.actor.message__m00bpk.md#m-net.adamec.lib.common.actor.message.envelope.forwardto_net.adamec.lib.common.actor.actor.iactorref-system.string___1pf93xv) | public | Forwards the message to another recipient. Keeps the original message and sender, but cleans/set the [RoutingKey](net.adamec.lib.common.actor.message__m00bpk.md#p-net.adamec.lib.common.actor.message.envelope.routingkey__1t0mr4v) based on <strong>routingKey</strong> parameter. | 
 | [ToString()](net.adamec.lib.common.actor.message__m00bpk.md#m-net.adamec.lib.common.actor.message.envelope.tostring__3dg837) | public |  | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.message.envelope.correlationid__1b0zym1" />  Envelope.CorrelationId Property ##
<small>Namespace: [net.adamec.lib.common.actor.message](net.adamec.lib.common.actor.message__m00bpk.md#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>


Correlation ID used to identify the message (envelope)



```csharp
public string CorrelationId { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.message.envelope.createdon__1kpt9ip" />  Envelope.CreatedOn Property ##
<small>Namespace: [net.adamec.lib.common.actor.message](net.adamec.lib.common.actor.message__m00bpk.md#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>


Timestamp when the envelope has been created



```csharp
public DateTime CreatedOn { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.datetime" target="_blank" >DateTime</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.message.envelope.message__j08krj" />  Envelope.Message Property ##
<small>Namespace: [net.adamec.lib.common.actor.message](net.adamec.lib.common.actor.message__m00bpk.md#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>


Message



```csharp
public object Message { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.message.envelope.recipient__1fcsz7b" />  Envelope.Recipient Property ##
<small>Namespace: [net.adamec.lib.common.actor.message](net.adamec.lib.common.actor.message__m00bpk.md#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>


Message recipient



```csharp
public IActorRef Recipient { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.message.envelope.routingkey__1t0mr4v" />  Envelope.RoutingKey Property ##
<small>Namespace: [net.adamec.lib.common.actor.message](net.adamec.lib.common.actor.message__m00bpk.md#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>


Optional routing key that can be used by actors (as &quot;a parameter outside the message&quot;)



```csharp
public string RoutingKey { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.message.envelope.sender__154pdc7" />  Envelope.Sender Property ##
<small>Namespace: [net.adamec.lib.common.actor.message](net.adamec.lib.common.actor.message__m00bpk.md#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>


Message sender



```csharp
public IActorRef Sender { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.message.envelope.-ctor_net.adamec.lib.common.actor.message.envelope___1a00gop" />  Envelope.Envelope(Envelope) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.message](net.adamec.lib.common.actor.message__m00bpk.md#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>


CTOR - creates the exact copy of <strong>original</strong> message including the [CorrelationId](net.adamec.lib.common.actor.message__m00bpk.md#p-net.adamec.lib.common.actor.message.envelope.correlationid__1b0zym1) and [CreatedOn](net.adamec.lib.common.actor.message__m00bpk.md#p-net.adamec.lib.common.actor.message.envelope.createdon__1kpt9ip) timestamp



```csharp
protected Envelope(Envelope original)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>original</strong></dt><dd></dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.message.envelope.-ctor_net.adamec.lib.common.actor.actor.iactorref-net.adamec.lib.common.actor.actor.iactorref-system.object-system.string___k4a7n5" />  Envelope.Envelope(IActorRef, IActorRef, object, string) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.message](net.adamec.lib.common.actor.message__m00bpk.md#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>


CTOR



```csharp
internal Envelope(IActorRef sender, IActorRef recipient, object message, string routingKey = null)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>sender</strong></dt><dd>Message sender</dd><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Message recipient</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>message</strong></dt><dd>Message (payload)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>routingKey</strong></dt><dd>Optional routing key that can be used by actors (as &quot;a parameter outside the message&quot;)</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.message.envelope.forwardto_net.adamec.lib.common.actor.actor.iactorref___qf18qp" />  Envelope.ForwardTo(IActorRef) Method ##
<small>Namespace: [net.adamec.lib.common.actor.message](net.adamec.lib.common.actor.message__m00bpk.md#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>


Forwards the message to another recipient. Keeps the original message, sender and routing key.



```csharp
public virtual void ForwardTo(IActorRef recipient)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Target recipient</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.message.envelope.forwardto_net.adamec.lib.common.actor.actor.iactorref-system.string___1pf93xv" />  Envelope.ForwardTo(IActorRef, string) Method ##
<small>Namespace: [net.adamec.lib.common.actor.message](net.adamec.lib.common.actor.message__m00bpk.md#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>


Forwards the message to another recipient. Keeps the original message and sender, but cleans/set the [RoutingKey](net.adamec.lib.common.actor.message__m00bpk.md#p-net.adamec.lib.common.actor.message.envelope.routingkey__1t0mr4v) based on <strong>routingKey</strong> parameter.



```csharp
public virtual void ForwardTo(IActorRef recipient, string routingKey)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.actor.IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) <strong>recipient</strong></dt><dd>Target recipient</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>routingKey</strong></dt><dd>New [RoutingKey](net.adamec.lib.common.actor.message__m00bpk.md#p-net.adamec.lib.common.actor.message.envelope.routingkey__1t0mr4v) , if not provided, the routing key will be cleaned up (set to null)!</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.message.envelope.tostring__3dg837" />  Envelope.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.actor.message](net.adamec.lib.common.actor.message__m00bpk.md#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           
Sources: message\Envelope.cs</small>



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.message.errormessage__1gj1wb" />  ErrorMessage Class ##
<small>Namespace: [net.adamec.lib.common.actor.message](net.adamec.lib.common.actor.message__m00bpk.md#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Sources: message\ErrorMessage.cs</small>


Specialized [Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) for messages in [ErrorMessageQueue](net.adamec.lib.common.actor.actorsystem__1ihx1md.md#p-net.adamec.lib.common.actor.actorsystem.iactorsystem.errormessagequeue__v9i6fy)



```csharp
public class ErrorMessage : Envelope
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.lib.common.actor.message.Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Error](net.adamec.lib.common.actor.message__m00bpk.md#p-net.adamec.lib.common.actor.message.errormessage.error__1649m0l) | public | Error message | 
 | [ErrorOn](net.adamec.lib.common.actor.message__m00bpk.md#p-net.adamec.lib.common.actor.message.errormessage.erroron__b1f28) | public | Timestamp when the error envelope has been created | 
 | [Exception](net.adamec.lib.common.actor.message__m00bpk.md#p-net.adamec.lib.common.actor.message.errormessage.exception__crgqc2) | public | Exception thrown | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ErrorMessage(Envelope, string, Exception)](net.adamec.lib.common.actor.message__m00bpk.md#m-net.adamec.lib.common.actor.message.errormessage.-ctor_net.adamec.lib.common.actor.message.envelope-system.string-system.exception___7xh1dy) | public | CTOR - creates the error message envelope based on given message <strong>envelope</strong> | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.lib.common.actor.message__m00bpk.md#m-net.adamec.lib.common.actor.message.errormessage.tostring__1v7vk6u) | public |  | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.message.errormessage.error__1649m0l" />  ErrorMessage.Error Property ##
<small>Namespace: [net.adamec.lib.common.actor.message](net.adamec.lib.common.actor.message__m00bpk.md#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [ErrorMessage](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.errormessage__1gj1wb)           
Sources: message\ErrorMessage.cs</small>


Error message



```csharp
public string Error { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.message.errormessage.erroron__b1f28" />  ErrorMessage.ErrorOn Property ##
<small>Namespace: [net.adamec.lib.common.actor.message](net.adamec.lib.common.actor.message__m00bpk.md#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [ErrorMessage](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.errormessage__1gj1wb)           
Sources: message\ErrorMessage.cs</small>


Timestamp when the error envelope has been created



```csharp
public DateTime ErrorOn { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.datetime" target="_blank" >DateTime</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.message.errormessage.exception__crgqc2" />  ErrorMessage.Exception Property ##
<small>Namespace: [net.adamec.lib.common.actor.message](net.adamec.lib.common.actor.message__m00bpk.md#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [ErrorMessage](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.errormessage__1gj1wb)           
Sources: message\ErrorMessage.cs</small>


Exception thrown



```csharp
public Exception Exception { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.message.errormessage.-ctor_net.adamec.lib.common.actor.message.envelope-system.string-system.exception___7xh1dy" />  ErrorMessage.ErrorMessage(Envelope, string, Exception) Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.message](net.adamec.lib.common.actor.message__m00bpk.md#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [ErrorMessage](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.errormessage__1gj1wb)           
Sources: message\ErrorMessage.cs</small>


CTOR - creates the error message envelope based on given message <strong>envelope</strong>



```csharp
public ErrorMessage(Envelope envelope, string error, Exception exception)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Envelope of message causing the error</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>error</strong></dt><dd>Error message</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>exception</strong></dt><dd>Exception thrown</dd></dl>
Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.message.errormessage.tostring__1v7vk6u" />  ErrorMessage.ToString() Method ##
<small>Namespace: [net.adamec.lib.common.actor.message](net.adamec.lib.common.actor.message__m00bpk.md#n-net.adamec.lib.common.actor.message__m00bpk)           
Assembly: net.adamec.lib.common.actor           
Type: [ErrorMessage](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.errormessage__1gj1wb)           
Sources: message\ErrorMessage.cs</small>



```csharp
[ExcludeFromCodeCoverage]
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Overrides: [Envelope.ToString()](net.adamec.lib.common.actor.message__m00bpk.md#m-net.adamec.lib.common.actor.message.envelope.tostring__3dg837)Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 



