#  RAD Actor System Documentation #
##  <a id="n-net.adamec.lib.common.actor.queue__1lh8qrc" />  net.adamec.lib.common.actor.queue Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [InternalQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8) | internal | An unbounded mailbox managed message queue used by [ManagedMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09) as the main message queue Allows access to stored messages for monitoring using [Copy()](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.internalqueue.copy__1co1b8y) . Note: the messages in the array must not be modified!!! | 
 | [ManagedMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09) | public | Message queue for <em>net.adamec.home.control.common.actor.manager.mailbox.ManagedUnboundedDequeBasedMailbox</em> allowing the monitoring (access to) messages stores in the queue The main queue is implemented using <em>net.adamec.home.control.common.actor.manager.mailbox.ManagedMessageQueue</em> and also uses a <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1" target="_blank" >System.Collections.Generic.Stack`1</a> internally to store each individual <em>net.adamec.home.control.common.actor.manager.mailbox.ManagedMessageQueue.EnqueueFirst(Akka.Actor.Envelope)</em> messages - supports stashing | 

 


###  Interfaces ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl) | public abstract |  | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8" />  InternalQueue Class ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Sources: queue\InternalQueue.cs</small>


An unbounded mailbox managed message queue used by [ManagedMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09) as the main message queue Allows access to stored messages for monitoring using [Copy()](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.internalqueue.copy__1co1b8y) . Note: the messages in the array must not be modified!!!



```csharp
internal class InternalQueue : IMessageQueue
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: [net.adamec.lib.common.actor.queue.IMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#f-net.adamec.lib.common.actor.queue.internalqueue.queue__11mr03p) | private | Internal queue | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Count](net.adamec.lib.common.actor.queue__1lh8qrc.md#p-net.adamec.lib.common.actor.queue.internalqueue.count__1dorya5) | public | Number of messages in the queue | 
 | [HasMessages](net.adamec.lib.common.actor.queue__1lh8qrc.md#p-net.adamec.lib.common.actor.queue.internalqueue.hasmessages__1im69ka) | public | Flag whether the queue contains any messages | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CleanUp(IMessageQueue)](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.internalqueue.cleanup_net.adamec.lib.common.actor.queue.imessagequeue___1hi25kd) | public | Cleans the queue, the messages are sent to <strong>deadletters</strong> queue | 
 | [Copy()](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.internalqueue.copy__1co1b8y) | public | Gets the messages stored in the queue. The messages in the array must not be modified!!! | 
 | [Enqueue(Envelope)](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.internalqueue.enqueue_net.adamec.lib.common.actor.message.envelope___ve2fas) | public | Enqueue a new message envelope | 
 | [TryDequeue(Envelope)](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.internalqueue.trydequeue_net.adamec.lib.common.actor.message.envelope-___19jzc8l) | public | Tries to dequeue a message from the queue | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.queue.internalqueue.queue__11mr03p" />  InternalQueue.queue Field ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [InternalQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8)           
Sources: queue\InternalQueue.cs</small>


Internal queue



```csharp
private readonly ConcurrentQueue<net.adamec.lib.common.actor.message.Envelope> queue
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent.concurrentqueue-1" target="_blank" >System.Collections.Concurrent.ConcurrentQueue&lt;net.adamec.lib.common.actor.message.Envelope&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.queue.internalqueue.count__1dorya5" />  InternalQueue.Count Property ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [InternalQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8)           
Sources: queue\InternalQueue.cs</small>


Number of messages in the queue



```csharp
public int Count { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>Implements: [IMessageQueue.Count](net.adamec.lib.common.actor.queue__1lh8qrc.md#p-net.adamec.lib.common.actor.queue.imessagequeue.count__g0891s)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.queue.internalqueue.hasmessages__1im69ka" />  InternalQueue.HasMessages Property ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [InternalQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8)           
Sources: queue\InternalQueue.cs</small>


Flag whether the queue contains any messages



```csharp
public bool HasMessages { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>Implements: [IMessageQueue.HasMessages](net.adamec.lib.common.actor.queue__1lh8qrc.md#p-net.adamec.lib.common.actor.queue.imessagequeue.hasmessages__1iz3wad)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.internalqueue.cleanup_net.adamec.lib.common.actor.queue.imessagequeue___1hi25kd" />  InternalQueue.CleanUp(IMessageQueue) Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [InternalQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8)           
Sources: queue\InternalQueue.cs</small>


Cleans the queue, the messages are sent to <strong>deadletters</strong> queue



```csharp
[ExcludeFromCodeCoverage]
public void CleanUp(IMessageQueue deadletters)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.queue.IMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl) <strong>deadletters</strong></dt><dd>DeadLetters queue</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [IMessageQueue.CleanUp(IMessageQueue)](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.imessagequeue.cleanup_net.adamec.lib.common.actor.queue.imessagequeue___2qe93s)Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.internalqueue.copy__1co1b8y" />  InternalQueue.Copy() Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [InternalQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8)           
Sources: queue\InternalQueue.cs</small>


Gets the messages stored in the queue. The messages in the array must not be modified!!!



```csharp
[ExcludeFromCodeCoverage]
public Envelope[] Copy()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope[]](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)</dt><dd>Messages stored in the queue. The messages in the array must not be modified!!!</dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.internalqueue.enqueue_net.adamec.lib.common.actor.message.envelope___ve2fas" />  InternalQueue.Enqueue(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [InternalQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8)           
Sources: queue\InternalQueue.cs</small>


Enqueue a new message envelope



```csharp
public void Enqueue(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Message envelope</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [IMessageQueue.Enqueue(Envelope)](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.imessagequeue.enqueue_net.adamec.lib.common.actor.message.envelope___13cgq6h)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.internalqueue.trydequeue_net.adamec.lib.common.actor.message.envelope-___19jzc8l" />  InternalQueue.TryDequeue(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [InternalQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8)           
Sources: queue\InternalQueue.cs</small>


Tries to dequeue a message from the queue



```csharp
public bool TryDequeue(out Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Message envelope dequeued</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True if any message is returned in <strong>envelope</strong></dd></dl>Implements: [IMessageQueue.TryDequeue(Envelope)](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.imessagequeue.trydequeue_net.adamec.lib.common.actor.message.envelope-___1jw22qo)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09" />  ManagedMessageQueue Class ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Sources: queue\ManagedMessageQueue.cs</small>


Message queue for <em>net.adamec.home.control.common.actor.manager.mailbox.ManagedUnboundedDequeBasedMailbox</em> allowing the monitoring (access to) messages stores in the queue The main queue is implemented using <em>net.adamec.home.control.common.actor.manager.mailbox.ManagedMessageQueue</em> and also uses a <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1" target="_blank" >System.Collections.Generic.Stack`1</a> internally to store each individual <em>net.adamec.home.control.common.actor.manager.mailbox.ManagedMessageQueue.EnqueueFirst(Akka.Actor.Envelope)</em> messages - supports stashing



```csharp
public class ManagedMessageQueue : IMessageQueue
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: [net.adamec.lib.common.actor.queue.IMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#f-net.adamec.lib.common.actor.queue.managedmessagequeue.messagequeue__f6vqnz) | protected | The underlying [InternalQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8) . | 
 | [prependBuffer](net.adamec.lib.common.actor.queue__1lh8qrc.md#f-net.adamec.lib.common.actor.queue.managedmessagequeue.prependbuffer__8wamat) | private |  | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Count](net.adamec.lib.common.actor.queue__1lh8qrc.md#p-net.adamec.lib.common.actor.queue.managedmessagequeue.count__h0822) | public | Returns the number of messages in both the internal message queue and the prepend buffer. | 
 | [HasMessages](net.adamec.lib.common.actor.queue__1lh8qrc.md#p-net.adamec.lib.common.actor.queue.managedmessagequeue.hasmessages__17b0d3x) | public | Returns true if there are any messages inside the queue. | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ManagedMessageQueue()](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.managedmessagequeue.-ctor__1c6oeh3) | public | Creates [ManagedMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CleanUp(IMessageQueue)](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.managedmessagequeue.cleanup_net.adamec.lib.common.actor.queue.imessagequeue___1e5rsai) | public | Cleans the queue, the messages are sent to <strong>deadletters</strong> queue | 
 | [Copy()](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.managedmessagequeue.copy__xeyi8r) | public | Gets the all queued messages stored in the prepend buffer and main queue. The messages in the array must not be modified!!! | 
 | [Enqueue(Envelope)](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.managedmessagequeue.enqueue_net.adamec.lib.common.actor.message.envelope___fs8mtl) | public | Enqueue a new message envelope | 
 | [EnqueueFirst(Envelope)](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.managedmessagequeue.enqueuefirst_net.adamec.lib.common.actor.message.envelope___3gbbrz) | public | Add a message to the front of the queue via the prepend buffer. | 
 | [TryDequeue(Envelope)](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.managedmessagequeue.trydequeue_net.adamec.lib.common.actor.message.envelope-___1k976aa) | public | Attempt to dequeue a message from the front of the prepend buffer.  If the prepend buffer is empty, dequeue a message from the main message queue | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.queue.managedmessagequeue.messagequeue__f6vqnz" />  ManagedMessageQueue.MessageQueue Field ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [ManagedMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)           
Sources: queue\ManagedMessageQueue.cs</small>


The underlying [InternalQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8) .



```csharp
protected readonly IMessageQueue MessageQueue
```

<strong>Field value</strong><dl><dt>[net.adamec.lib.common.actor.queue.IMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)</dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="f-net.adamec.lib.common.actor.queue.managedmessagequeue.prependbuffer__8wamat" />  ManagedMessageQueue.prependBuffer Field ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [ManagedMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)           
Sources: queue\ManagedMessageQueue.cs</small>



```csharp
private readonly Stack<net.adamec.lib.common.actor.message.Envelope> prependBuffer
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1" target="_blank" >Stack&lt;net.adamec.lib.common.actor.message.Envelope&gt;</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.queue.managedmessagequeue.count__h0822" />  ManagedMessageQueue.Count Property ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [ManagedMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)           
Sources: queue\ManagedMessageQueue.cs</small>


Returns the number of messages in both the internal message queue and the prepend buffer.



```csharp
public int Count { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>Implements: [IMessageQueue.Count](net.adamec.lib.common.actor.queue__1lh8qrc.md#p-net.adamec.lib.common.actor.queue.imessagequeue.count__g0891s)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.queue.managedmessagequeue.hasmessages__17b0d3x" />  ManagedMessageQueue.HasMessages Property ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [ManagedMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)           
Sources: queue\ManagedMessageQueue.cs</small>


Returns true if there are any messages inside the queue.



```csharp
public bool HasMessages { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>Implements: [IMessageQueue.HasMessages](net.adamec.lib.common.actor.queue__1lh8qrc.md#p-net.adamec.lib.common.actor.queue.imessagequeue.hasmessages__1iz3wad)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.managedmessagequeue.-ctor__1c6oeh3" />  ManagedMessageQueue.ManagedMessageQueue() Constructor ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [ManagedMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)           
Sources: queue\ManagedMessageQueue.cs</small>


Creates [ManagedMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)



```csharp
public ManagedMessageQueue()
```

Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.managedmessagequeue.cleanup_net.adamec.lib.common.actor.queue.imessagequeue___1e5rsai" />  ManagedMessageQueue.CleanUp(IMessageQueue) Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [ManagedMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)           
Sources: queue\ManagedMessageQueue.cs</small>


Cleans the queue, the messages are sent to <strong>deadletters</strong> queue



```csharp
public void CleanUp(IMessageQueue deadletters)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.queue.IMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl) <strong>deadletters</strong></dt><dd>DeadLetters queue</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [IMessageQueue.CleanUp(IMessageQueue)](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.imessagequeue.cleanup_net.adamec.lib.common.actor.queue.imessagequeue___2qe93s)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.managedmessagequeue.copy__xeyi8r" />  ManagedMessageQueue.Copy() Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [ManagedMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)           
Sources: queue\ManagedMessageQueue.cs</small>


Gets the all queued messages stored in the prepend buffer and main queue. The messages in the array must not be modified!!!



```csharp
[ExcludeFromCodeCoverage]
public Envelope[] Copy()
```

<strong>Return value</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope[]](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s)</dt><dd>All queued messages stored in the prepend buffer and main queue. The messages in the array must not be modified!!!</dd></dl>Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute" target="_blank" >System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute</a>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.managedmessagequeue.enqueue_net.adamec.lib.common.actor.message.envelope___fs8mtl" />  ManagedMessageQueue.Enqueue(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [ManagedMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)           
Sources: queue\ManagedMessageQueue.cs</small>


Enqueue a new message envelope



```csharp
public void Enqueue(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>Message envelope</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [IMessageQueue.Enqueue(Envelope)](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.imessagequeue.enqueue_net.adamec.lib.common.actor.message.envelope___13cgq6h)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.managedmessagequeue.enqueuefirst_net.adamec.lib.common.actor.message.envelope___3gbbrz" />  ManagedMessageQueue.EnqueueFirst(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [ManagedMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)           
Sources: queue\ManagedMessageQueue.cs</small>


Add a message to the front of the queue via the prepend buffer.



```csharp
public void EnqueueFirst(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>The message we wish to append to the front of the queue.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.managedmessagequeue.trydequeue_net.adamec.lib.common.actor.message.envelope-___1k976aa" />  ManagedMessageQueue.TryDequeue(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [ManagedMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)           
Sources: queue\ManagedMessageQueue.cs</small>


Attempt to dequeue a message from the front of the prepend buffer.  If the prepend buffer is empty, dequeue a message from the main message queue



```csharp
public bool TryDequeue(out Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>The message to return, if any</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>`true` if a message was available, `false` otherwise.</dd></dl>Implements: [IMessageQueue.TryDequeue(Envelope)](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.imessagequeue.trydequeue_net.adamec.lib.common.actor.message.envelope-___1jw22qo)


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl" />  IMessageQueue Interface ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Sources: queue\IMessageQueue.cs</small>



```csharp
public interface IMessageQueue
```

Implemented by: [net.adamec.lib.common.actor.queue.InternalQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.internalqueue__49i5r8), [net.adamec.lib.common.actor.queue.ManagedMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.managedmessagequeue__1xckl09)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Count](net.adamec.lib.common.actor.queue__1lh8qrc.md#p-net.adamec.lib.common.actor.queue.imessagequeue.count__g0891s) | public abstract | Returns the count of messages currently in the message queue | 
 | [HasMessages](net.adamec.lib.common.actor.queue__1lh8qrc.md#p-net.adamec.lib.common.actor.queue.imessagequeue.hasmessages__1iz3wad) | public abstract | Tests if the message queue contains any messages | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CleanUp(IMessageQueue)](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.imessagequeue.cleanup_net.adamec.lib.common.actor.queue.imessagequeue___2qe93s) | public abstract | Called when the [IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) this queue belongs to is de-registered. All remaining messages are transferred  into the dead-letter queue | 
 | [Enqueue(Envelope)](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.imessagequeue.enqueue_net.adamec.lib.common.actor.message.envelope___13cgq6h) | public abstract | Enqueue an mailbox envelope onto the message queue | 
 | [TryDequeue(Envelope)](net.adamec.lib.common.actor.queue__1lh8qrc.md#m-net.adamec.lib.common.actor.queue.imessagequeue.trydequeue_net.adamec.lib.common.actor.message.envelope-___1jw22qo) | public abstract | Tries to pull an envelope of the message queue | 

 


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.queue.imessagequeue.count__g0891s" />  IMessageQueue.Count Property ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [IMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)           
Sources: queue\IMessageQueue.cs</small>


Returns the count of messages currently in the message queue



```csharp
public abstract int Count { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="p-net.adamec.lib.common.actor.queue.imessagequeue.hasmessages__1iz3wad" />  IMessageQueue.HasMessages Property ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [IMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)           
Sources: queue\IMessageQueue.cs</small>


Tests if the message queue contains any messages



```csharp
public abstract bool HasMessages { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.imessagequeue.cleanup_net.adamec.lib.common.actor.queue.imessagequeue___2qe93s" />  IMessageQueue.CleanUp(IMessageQueue) Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [IMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)           
Sources: queue\IMessageQueue.cs</small>


Called when the [IActorRef](net.adamec.lib.common.actor.actor__1ldg5ba.md#t-net.adamec.lib.common.actor.actor.iactorref__63mbv) this queue belongs to is de-registered. All remaining messages are transferred  into the dead-letter queue



```csharp
public abstract void CleanUp(IMessageQueue deadletters)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.queue.IMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl) <strong>deadletters</strong></dt><dd>The dead letters message queue.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.imessagequeue.enqueue_net.adamec.lib.common.actor.message.envelope___13cgq6h" />  IMessageQueue.Enqueue(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [IMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)           
Sources: queue\IMessageQueue.cs</small>


Enqueue an mailbox envelope onto the message queue



```csharp
public abstract void Enqueue(Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>The envelope to enqueue</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 


##  <a id="m-net.adamec.lib.common.actor.queue.imessagequeue.trydequeue_net.adamec.lib.common.actor.message.envelope-___1jw22qo" />  IMessageQueue.TryDequeue(Envelope) Method ##
<small>Namespace: [net.adamec.lib.common.actor.queue](net.adamec.lib.common.actor.queue__1lh8qrc.md#n-net.adamec.lib.common.actor.queue__1lh8qrc)           
Assembly: net.adamec.lib.common.actor           
Type: [IMessageQueue](net.adamec.lib.common.actor.queue__1lh8qrc.md#t-net.adamec.lib.common.actor.queue.imessagequeue__1ndgarl)           
Sources: queue\IMessageQueue.cs</small>


Tries to pull an envelope of the message queue



```csharp
public abstract bool TryDequeue(out Envelope envelope)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.lib.common.actor.message.Envelope](net.adamec.lib.common.actor.message__m00bpk.md#t-net.adamec.lib.common.actor.message.envelope__5oxc3s) <strong>envelope</strong></dt><dd>The envelope that was dequeued</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>`true` if there&#39;s a message in the queue. `false` otherwise.</dd></dl>


Go to [namespaces](net.adamec.lib.common.actor.md#namespace-list) or [types](net.adamec.lib.common.actor.md#type-list) or [source-only packages](net.adamec.lib.common.actor.md#package-list)


 



