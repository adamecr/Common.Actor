using System;
using System.Threading;
using FluentAssertions;
using Moq;
using net.adamec.lib.common.actor.actor;
using net.adamec.lib.common.actor.actor.exchanges.@base;
using net.adamec.lib.common.actor.actor.exchanges.single;
using net.adamec.lib.common.actor.actor.exchanges.typed;
using net.adamec.lib.common.actor.actorsystem;
using Xunit;
using Xunit.Abstractions;

namespace net.adamec.lib.common.actor.test
{

    public class ExchangesTests
    {
        private readonly ITestOutputHelper output;

        public ExchangesTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void WrongSubscriptionTest()
        {
            //execute
            // ReSharper disable ObjectCreationAsStatement
            Action action1 = () => new Subscription(null);
            Action action2 = () => new TypedSubscription(null, ActorRefs.Empty);
            Action action3 = () => new TypedSubscription(typeof(object), null);
            Action action4 = () => new TypedSubscriptionMessage(null);
            Action action5 = () => new TypedUnSubscriptionMessage(null);
            // ReSharper restore ObjectCreationAsStatement

            //check
            action1.Should().Throw<ArgumentNullException>().WithMessage("Value cannot be null.*Parameter name: actorRef");
            action2.Should().Throw<ArgumentNullException>().WithMessage("Value cannot be null.*Parameter name: messageType");
            action3.Should().Throw<ArgumentNullException>().WithMessage("Value cannot be null.*Parameter name: actorRef");
            action4.Should().Throw<ArgumentNullException>().WithMessage("Value cannot be null.*Parameter name: messageType");
            action5.Should().Throw<ArgumentNullException>().WithMessage("Value cannot be null.*Parameter name: messageType");
        }

        [Fact]
        public void SingleExchangeActorTest()
        {
            var msgCount1 = 0;
            var msgCount2 = 0;
            using (var waitHandle = new AutoResetEvent(false))
            {
                var actorMock1 = new Mock<IActor>();
                actorMock1.Setup(a => a.CanReceive).Returns(true);
                actorMock1.Setup(a => a.ReceiveTarget).Returns(msg =>
                {
                    output.WriteLine($"Message received by {msg.Recipient.Name}: {msg.Message} from {msg.Sender.Name}");
                    msgCount1++;
                    // ReSharper disable once AccessToDisposedClosure
                    if (msg.Message.ToString().StartsWith("END")) waitHandle.Set();
                    return true;
                });
                var actorMock2 = new Mock<IActor>();
                actorMock2.Setup(a => a.CanReceive).Returns(true);
                actorMock2.Setup(a => a.ReceiveTarget).Returns(msg =>
                {
                    output.WriteLine($"Message received by {msg.Recipient.Name}: {msg.Message} from {msg.Sender.Name}");
                    msgCount2++;
                    return true;
                });

                using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
                {
                    //execute
                    using (var actorExch = new SingleExchangeActor(actorSystem, "EX"))
                    {
                        var actorRefExch = actorExch.Self;

                        var actorRef1 = actorSystem.RegisterActor(actorMock1.Object, "tst actor1");
                        var actorRef2 = actorSystem.RegisterActor(actorMock2.Object, "tst actor2");

                        actorRefExch.Tell("TST1", ActorRefs.Empty); //drop
                        actorRefExch.Tell(new SubscriptionMessage(), actorRef1); //subscribe
                        actorRefExch.Tell("TST2", ActorRefs.Empty); //a1
                        actorRefExch.Tell("TST3", ActorRefs.Empty); //a1
                        actorRefExch.Tell(new SubscriptionMessage(), actorRef2); //subscribe, replace a1
                        actorRefExch.Tell("TST4", ActorRefs.Empty); //a2
                        actorRefExch.Tell(new UnSubscriptionMessage(), actorRef1); //ignore
                        actorRefExch.Tell("TST5", ActorRefs.Empty); //a2
                        actorRefExch.Tell(new UnSubscriptionMessage(), actorRef2); //unsubscribe
                        actorRefExch.Tell("TST6", ActorRefs.Empty); //drop
                        actorRefExch.Tell(new SubscriptionMessage(), actorRef1); //subscribe again
                        actorRefExch.Tell("END", ActorRefs.Empty); //a1, finish

                        if (!waitHandle.WaitOne(2000, false))
                        {
                            output.WriteLine("ERR: Message receive timeout");
                            Assert.True(false, "Timeout");
                        }
                    }

                    //check
                    msgCount1.Should().Be(3);
                    msgCount2.Should().Be(2);
                    actorSystem.DeadLetters.Count.Should().Be(2);
                    actorSystem.ErrorMessageQueue.Count.Should().Be(0);
                }
            }
        }


        [Fact]
        public void ExchangeActorStartStopTest()
        {
            var msgCount1 = 0;
            var msgCount2 = 0;
            // ReSharper disable once TooWideLocalVariableScope
            int msgCount1Mid;
            // ReSharper disable once TooWideLocalVariableScope
            int msgCount2Mid;
            using (var waitHandle = new AutoResetEvent(false))
            {
                var actorMock1 = new Mock<IActor>();
                actorMock1.Setup(a => a.CanReceive).Returns(true);
                actorMock1.Setup(a => a.ReceiveTarget).Returns(msg =>
                {
                    output.WriteLine($"Message received by {msg.Recipient.Name}: {msg.Message} from {msg.Sender.Name}");
                    msgCount1++;
                    // ReSharper disable once AccessToDisposedClosure
                    if (msg.Message.ToString().StartsWith("END")) waitHandle.Set();
                    return true;
                });
                var actorMock2 = new Mock<IActor>();
                actorMock2.Setup(a => a.CanReceive).Returns(true);
                actorMock2.Setup(a => a.ReceiveTarget).Returns(msg =>
                {
                    output.WriteLine($"Message received by {msg.Recipient.Name}: {msg.Message} from {msg.Sender.Name}");
                    msgCount2++;
                    return true;
                });

                using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
                {
                    //execute
                    using (var actorExch = new SingleExchangeActor(actorSystem, "EX"))
                    {
                        var actorRefExch = actorExch.Self;

                        var actorRef1 = actorSystem.RegisterActor(actorMock1.Object, "tst actor1");
                        var actorRef2 = actorSystem.RegisterActor(actorMock2.Object, "tst actor2");

                        actorRefExch.Tell("TST1", ActorRefs.Empty); //drop
                        actorRefExch.Tell(new SubscriptionMessage(), actorRef1); //subscribe
                        actorRefExch.Tell("TST2", ActorRefs.Empty); //a1
                        actorRefExch.Tell("TST3", ActorRefs.Empty); //a1
                        actorRefExch.Tell(new SubscriptionMessage(), actorRef2); //subscribe, replace a1
                        actorRefExch.Tell("TST4", ActorRefs.Empty); //a2
                        actorRefExch.Tell(new UnSubscriptionMessage(), actorRef1); //ignore
                        actorRefExch.Tell("TST5", ActorRefs.Empty); //a2
                        actorRefExch.Tell(new UnSubscriptionMessage(), actorRef2); //unsubscribe
                        actorRefExch.Tell("TST6", ActorRefs.Empty); //drop
                        actorRefExch.Tell(new SubscriptionMessage(), actorRef1); //subscribe again
                        actorRefExch.Tell("END", ActorRefs.Empty); //a1, finish mid

                        if (!waitHandle.WaitOne(2000, false))
                        {
                            output.WriteLine("ERR: Message receive timeout");
                            Assert.True(false, "Timeout");
                        }

                        actorExch.Stop();

                        actorRefExch.Tell("TST7", ActorRefs.Empty); //a1 (later)
                        actorRefExch.Tell(new SubscriptionMessage(), actorRef2); //subscribe, replace a1 (later)
                        actorRefExch.Tell("TST8", ActorRefs.Empty); //a2 (later)
                        actorRefExch.Tell(new SubscriptionMessage(), actorRef1); //subscribe again (later)

                        Thread.Sleep(50);//wait some time
                        msgCount1Mid = msgCount1;
                        msgCount2Mid = msgCount2;

                        actorExch.Start();
                        actorRefExch.Tell("END", ActorRefs.Empty); //a1, finish mid
                    }

                    //check
                    msgCount1Mid.Should().Be(3);
                    msgCount2Mid.Should().Be(2);
                    msgCount1.Should().Be(5);
                    msgCount2.Should().Be(3);
                    actorSystem.DeadLetters.Count.Should().Be(2);
                    actorSystem.ErrorMessageQueue.Count.Should().Be(0);
                }
            }
        }


        [Fact]
        public void SingleTypedExchangeActorTest()
        {
            var msgCount1 = 0;
            var msgCount2 = 0;
            using (var waitHandle = new AutoResetEvent(false))
            {
                var actorMock1 = new Mock<IActor>();
                actorMock1.Setup(a => a.CanReceive).Returns(true);
                actorMock1.Setup(a => a.ReceiveTarget).Returns(msg =>
                {
                    output.WriteLine($"Message received by {msg.Recipient.Name}: {msg.Message} from {msg.Sender.Name}");
                    msgCount1++;
                    // ReSharper disable once AccessToDisposedClosure
                    if (msg.Message.ToString().StartsWith("END")) waitHandle.Set();
                    return true;
                });
                var actorMock2 = new Mock<IActor>();
                actorMock2.Setup(a => a.CanReceive).Returns(true);
                actorMock2.Setup(a => a.ReceiveTarget).Returns(msg =>
                {
                    output.WriteLine($"Message received by {msg.Recipient.Name}: {msg.Message} from {msg.Sender.Name}");
                    msgCount2++;
                    return true;
                });

                using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
                {
                    //execute
                    using (var actorExch = new TypedSingleExchangeActor(actorSystem, "EX"))
                    {
                        var actorRefExch = actorExch.Self;

                        var actorRef1 = actorSystem.RegisterActor(actorMock1.Object, "tst actor1");
                        var actorRef2 = actorSystem.RegisterActor(actorMock2.Object, "tst actor2");

                        actorRefExch.Tell("TST1", ActorRefs.Empty); //drop
                        actorRefExch.Tell(new SubscriptionMessage(), actorRef1); //drop - wrong type of subscription message
                        actorRefExch.Tell(new TypedSubscriptionMessage(typeof(string)), actorRef1); //string -> a1
                        actorRefExch.Tell(new TypedSubscriptionMessage(typeof(int)), actorRef2); //int to -> a2
                        actorRefExch.Tell("TST2", ActorRefs.Empty); //a1
                        actorRefExch.Tell("TST3", ActorRefs.Empty); //a1
                        actorRefExch.Tell(4, ActorRefs.Empty); //a2
                        actorRefExch.Tell(new TypedSubscriptionMessage(typeof(string)), actorRef2); //string -> a2
                        actorRefExch.Tell("TST5", ActorRefs.Empty); //a2
                        actorRefExch.Tell(new TypedUnSubscriptionMessage(typeof(string)), actorRef1); //ignore
                        actorRefExch.Tell("TST6", ActorRefs.Empty); //a2
                        actorRefExch.Tell(new TypedUnSubscriptionMessage(typeof(string)), actorRef2); //string ->drop
                        actorRefExch.Tell("TST7", ActorRefs.Empty); //drop
                        actorRefExch.Tell(8, ActorRefs.Empty); //a2
                        actorRefExch.Tell(9.0, ActorRefs.Empty); //drop
                        actorRefExch.Tell(new TypedSubscriptionMessage(typeof(string)), actorRef1); //subscribe again
                        actorRefExch.Tell("END", ActorRefs.Empty); //a1, finish

                        if (!waitHandle.WaitOne(3000, false))
                        {
                            output.WriteLine("ERR: Message receive timeout");
                            Assert.True(false, "Timeout");
                        }
                    }

                    //check
                    msgCount1.Should().Be(3);
                    msgCount2.Should().Be(4);
                    actorSystem.DeadLetters.Count.Should().Be(4);
                    actorSystem.ErrorMessageQueue.Count.Should().Be(0);
                }
            }
        }

        [Fact]
        public void SingleTypedExchangeActorInheritanceTest()
        {
            var msgCount1 = 0;
            var msgCount2 = 0;
            using (var waitHandle = new AutoResetEvent(false))
            {
                var actorMock1 = new Mock<IActor>();
                actorMock1.Setup(a => a.CanReceive).Returns(true);
                actorMock1.Setup(a => a.ReceiveTarget).Returns(msg =>
                {
                    output.WriteLine($"Message received by {msg.Recipient.Name}: {msg.Message} from {msg.Sender.Name}");
                    msgCount1++;
                    // ReSharper disable once AccessToDisposedClosure
                    if (msg.Message.ToString().StartsWith("END")) waitHandle.Set();
                    return true;
                });
                var actorMock2 = new Mock<IActor>();
                actorMock2.Setup(a => a.CanReceive).Returns(true);
                actorMock2.Setup(a => a.ReceiveTarget).Returns(msg =>
                {
                    output.WriteLine($"Message received by {msg.Recipient.Name}: {msg.Message} from {msg.Sender.Name}");
                    msgCount2++;
                    return true;
                });

                using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
                {
                    //execute
                    using (var actorExch = new TypedSingleExchangeActor(actorSystem, "EX"))
                    {
                        var actorRefExch = actorExch.Self;

                        var actorRef1 = actorSystem.RegisterActor(actorMock1.Object, "tst actor1");
                        var actorRef2 = actorSystem.RegisterActor(actorMock2.Object, "tst actor2");

                        actorRefExch.Tell("TST1", ActorRefs.Empty); //drop
                        actorRefExch.Tell(new SubscriptionMessage(), actorRef1); //drop - wrong type of subscription message
                        actorRefExch.Tell(new TypedSubscriptionMessage(typeof(NullReferenceException)), actorRef1); //a1: NPE; a2: N/A
                        actorRefExch.Tell(new TypedSubscriptionMessage(typeof(Exception)), actorRef2); //a1: NPE; a2: E
                        actorRefExch.Tell(new NullReferenceException("TST2"), ActorRefs.Empty); //a1
                        actorRefExch.Tell(new InvalidOperationException("TST3"), ActorRefs.Empty); //a2
                        actorRefExch.Tell(4, ActorRefs.Empty); //drop
                        actorRefExch.Tell(new TypedSubscriptionMessage(typeof(object)), actorRef1); //a1: NPE, obj; a2: E
                        actorRefExch.Tell(5, ActorRefs.Empty); //a1
                        actorRefExch.Tell(new Exception("TST6"), ActorRefs.Empty); //a2 - exact match
                        actorRefExch.Tell(new TypedUnSubscriptionMessage(typeof(Exception)), actorRef2); //a1: NPE, obj; a2: N/A
                        actorRefExch.Tell(new Exception("TST7"), ActorRefs.Empty); //a1 - fallback
                        actorRefExch.Tell(new TypedSubscriptionMessage(typeof(Exception)), actorRef2); //a1: NPE, obj; a2: E
                        actorRefExch.Tell(new InvalidOperationException("TST8"), ActorRefs.Empty); //a1 - fallback (object registered first)
                        actorRefExch.Tell(new TypedUnSubscriptionMessage(typeof(object)), actorRef1); //a1: NPE; a2: E
                        actorRefExch.Tell(new InvalidOperationException("TST9"), ActorRefs.Empty); //a2 - fallback
                        actorRefExch.Tell(new NullReferenceException("TST10"), ActorRefs.Empty); //a1
                        actorRefExch.Tell(new TypedSubscriptionMessage(typeof(string)), actorRef1); //a1: NPE,str; a2: E
                        actorRefExch.Tell("END", ActorRefs.Empty); //a1, finish

                        if (!waitHandle.WaitOne(2000, false))
                        {
                            output.WriteLine("ERR: Message receive timeout");
                            Assert.True(false, "Timeout");
                        }
                    }

                    //check
                    msgCount1.Should().Be(6);
                    msgCount2.Should().Be(3);
                    actorSystem.DeadLetters.Count.Should().Be(3);
                    actorSystem.ErrorMessageQueue.Count.Should().Be(0);
                }
            }
        }

        [Fact]
        public void MultiTypedExchangeActorTest()
        {
            var msgCount1 = 0;
            var msgCount2 = 0;
            using (var waitHandle = new AutoResetEvent(false))
            {
                var actorMock1 = new Mock<IActor>();
                actorMock1.Setup(a => a.CanReceive).Returns(true);
                actorMock1.Setup(a => a.ReceiveTarget).Returns(msg =>
                {
                    output.WriteLine($"Message received by {msg.Recipient.Name}: {msg.Message} from {msg.Sender.Name}");
                    msgCount1++;
                    // ReSharper disable once AccessToDisposedClosure
                    if (msg.Message.ToString().StartsWith("END")) waitHandle.Set();
                    return true;
                });
                var actorMock2 = new Mock<IActor>();
                actorMock2.Setup(a => a.CanReceive).Returns(true);
                actorMock2.Setup(a => a.ReceiveTarget).Returns(msg =>
                {
                    output.WriteLine($"Message received by {msg.Recipient.Name}: {msg.Message} from {msg.Sender.Name}");
                    msgCount2++;
                    return true;
                });

                using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
                {
                    //execute
                    using (var actorExch = new TypedMultiExchangeActor(actorSystem, "EX"))
                    {
                        var actorRefExch = actorExch.Self;

                        var actorRef1 = actorSystem.RegisterActor(actorMock1.Object, "tst actor1");
                        var actorRef2 = actorSystem.RegisterActor(actorMock2.Object, "tst actor2");

                        actorRefExch.Tell("TST1", ActorRefs.Empty); //drop
                        actorRefExch.Tell(new SubscriptionMessage(), actorRef1); //drop - wrong type of subscription message
                        actorRefExch.Tell(new TypedSubscriptionMessage(typeof(string)), actorRef1); //a1:string; a2:n/a
                        actorRefExch.Tell(new TypedSubscriptionMessage(typeof(int)), actorRef2); //a1:string; a2:int
                        actorRefExch.Tell("TST2", ActorRefs.Empty); //a1
                        actorRefExch.Tell("TST3", ActorRefs.Empty); //a1
                        actorRefExch.Tell(4, ActorRefs.Empty); //a2
                        actorRefExch.Tell(new TypedSubscriptionMessage(typeof(string)), actorRef2); //a1:string; a2:int,string
                        actorRefExch.Tell("TST5", ActorRefs.Empty); //a1,a2
                        actorRefExch.Tell(new TypedUnSubscriptionMessage(typeof(string)), actorRef1); //a1:n/a; a2:int,string
                        actorRefExch.Tell("TST6", ActorRefs.Empty); //a2
                        actorRefExch.Tell(new TypedUnSubscriptionMessage(typeof(string)), actorRef2); //a1:n/a; a2:int
                        actorRefExch.Tell("TST7", ActorRefs.Empty); //drop
                        actorRefExch.Tell(8, ActorRefs.Empty); //a2
                        actorRefExch.Tell(9.0, ActorRefs.Empty); //drop
                        actorRefExch.Tell(new TypedSubscriptionMessage(typeof(string)), actorRef1); //a1:string; a2:int
                        actorRefExch.Tell("END", ActorRefs.Empty); //a1, finish

                        if (!waitHandle.WaitOne(2000, false))
                        {
                            output.WriteLine("ERR: Message receive timeout");
                            Assert.True(false, "Timeout");
                        }
                    }

                    //check
                    msgCount1.Should().Be(4);
                    msgCount2.Should().Be(4);
                    actorSystem.DeadLetters.Count.Should().Be(4);
                    actorSystem.ErrorMessageQueue.Count.Should().Be(0);
                }
            }
        }

        [Fact]
        public void MultiTypedExchangeActorInheritanceTest()
        {
            var msgCount1 = 0;
            var msgCount2 = 0;
            using (var waitHandle = new AutoResetEvent(false))
            {
                var actorMock1 = new Mock<IActor>();
                actorMock1.Setup(a => a.CanReceive).Returns(true);
                actorMock1.Setup(a => a.ReceiveTarget).Returns(msg =>
                {
                    output.WriteLine($"Message received by {msg.Recipient.Name}: {msg.Message} from {msg.Sender.Name}");
                    msgCount1++;
                    // ReSharper disable once AccessToDisposedClosure
                    if (msg.Message.ToString().StartsWith("END")) waitHandle.Set();
                    return true;
                });
                var actorMock2 = new Mock<IActor>();
                actorMock2.Setup(a => a.CanReceive).Returns(true);
                actorMock2.Setup(a => a.ReceiveTarget).Returns(msg =>
                {
                    output.WriteLine($"Message received by {msg.Recipient.Name}: {msg.Message} from {msg.Sender.Name}");
                    msgCount2++;
                    return true;
                });

                using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
                {
                    //execute
                    using (var actorExch = new TypedMultiExchangeActor(actorSystem, "EX"))
                    {
                        var actorRefExch = actorExch.Self;

                        var actorRef1 = actorSystem.RegisterActor(actorMock1.Object, "tst actor1");
                        var actorRef2 = actorSystem.RegisterActor(actorMock2.Object, "tst actor2");

                        actorRefExch.Tell("TST1", ActorRefs.Empty); //drop
                        actorRefExch.Tell(new SubscriptionMessage(), actorRef1); //drop - wrong type of subscription message
                        actorRefExch.Tell(new TypedSubscriptionMessage(typeof(NullReferenceException)), actorRef1); //a1: NPE; a2: N/A
                        actorRefExch.Tell(new TypedSubscriptionMessage(typeof(Exception)), actorRef2); //a1: NPE; a2: E
                        actorRefExch.Tell(new NullReferenceException("TST2"), ActorRefs.Empty); //a1,a2
                        actorRefExch.Tell(new InvalidOperationException("TST3"), ActorRefs.Empty); //a2
                        actorRefExch.Tell(4, ActorRefs.Empty); //drop
                        actorRefExch.Tell(new TypedSubscriptionMessage(typeof(object)), actorRef1); //a1: NPE, obj; a2: E
                        actorRefExch.Tell(5, ActorRefs.Empty); //a1
                        actorRefExch.Tell(new Exception("TST6"), ActorRefs.Empty); //a1,a2
                        actorRefExch.Tell(new TypedUnSubscriptionMessage(typeof(Exception)), actorRef2); //a1: NPE, obj; a2: N/A
                        actorRefExch.Tell(new Exception("TST7"), ActorRefs.Empty); //a1 - fallback
                        actorRefExch.Tell(new TypedSubscriptionMessage(typeof(Exception)), actorRef2); //a1: NPE, obj; a2: E
                        actorRefExch.Tell(new InvalidOperationException("TST8"), ActorRefs.Empty); //a1,a2
                        actorRefExch.Tell(new TypedUnSubscriptionMessage(typeof(object)), actorRef1); //a1: NPE; a2: E
                        actorRefExch.Tell(new InvalidOperationException("TST9"), ActorRefs.Empty); //a2 - fallback
                        actorRefExch.Tell(new NullReferenceException("TST10"), ActorRefs.Empty); //a1,a2
                        actorRefExch.Tell(new TypedSubscriptionMessage(typeof(string)), actorRef1); //a1: NPE,str; a2: E
                        actorRefExch.Tell("END", ActorRefs.Empty); //a1, finish

                        if (!waitHandle.WaitOne(2000, false))
                        {
                            output.WriteLine("ERR: Message receive timeout");
                            Assert.True(false, "Timeout");
                        }
                    }

                    //check
                    msgCount1.Should().Be(7);
                    msgCount2.Should().Be(6);
                    actorSystem.DeadLetters.Count.Should().Be(3);
                    actorSystem.ErrorMessageQueue.Count.Should().Be(0);
                }
            }
        }

        [Fact]
        public void RoutingKeyExchangeActorInheritanceTest()
        {
            var msgCount1 = 0;
            var msgCount2 = 0;
            var msgCount3 = 0;
            using (var waitHandle = new AutoResetEvent(false))
            {
                var actorMock1 = new Mock<IActor>();
                actorMock1.Setup(a => a.CanReceive).Returns(true);
                actorMock1.Setup(a => a.ReceiveTarget).Returns(msg =>
                {
                    output.WriteLine($"Message received by {msg.Recipient.Name}: {msg.Message} from {msg.Sender.Name}");
                    msgCount1++;
                    // ReSharper disable once AccessToDisposedClosure
                    if (msg.Message.ToString().StartsWith("END")) waitHandle.Set();
                    return true;
                });
                var actorMock2 = new Mock<IActor>();
                actorMock2.Setup(a => a.CanReceive).Returns(true);
                actorMock2.Setup(a => a.ReceiveTarget).Returns(msg =>
                {
                    output.WriteLine($"Message received by {msg.Recipient.Name}: {msg.Message} from {msg.Sender.Name}");
                    msgCount2++;
                    return true;
                });
                var actorMock3 = new Mock<IActor>();
                actorMock3.Setup(a => a.CanReceive).Returns(true);
                actorMock3.Setup(a => a.ReceiveTarget).Returns(msg =>
                {
                    output.WriteLine($"Message received by {msg.Recipient.Name}: {msg.Message} from {msg.Sender.Name}");
                    msgCount3++;
                    return true;
                });

                using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
                {
                    //execute
                    using (var actorExch = new RoutingKeyExchangeActor(actorSystem, "EX"))
                    {
                        var actorRefExch = actorExch.Self;

                        var actorRef1 = actorSystem.RegisterActor(actorMock1.Object, "tst actor1");
                        var actorRef2 = actorSystem.RegisterActor(actorMock2.Object, "tst actor2");
                        var actorRef3 = actorSystem.RegisterActor(actorMock3.Object, "tst actor3");

                        actorRefExch.Tell("TST1", ActorRefs.Empty); //drop
                        actorRefExch.Tell(new SubscriptionMessage(), actorRef1); //drop - wrong type of subscription message

                        //a1: NPE; a2: E; a3: E:T
                        actorRefExch.Tell(new RoutingKeySubscriptionMessage(typeof(NullReferenceException), null), actorRef1);
                        actorRefExch.Tell(new RoutingKeySubscriptionMessage(typeof(Exception), null), actorRef2);
                        actorRefExch.Tell(new RoutingKeySubscriptionMessage(typeof(Exception), "T"), actorRef3);

                        actorRefExch.Tell(new NullReferenceException("TST2"), ActorRefs.Empty); //a1,a2
                        actorRefExch.Tell(new InvalidOperationException("TST3"), ActorRefs.Empty); //a2
                        actorRefExch.Tell(new InvalidOperationException("TST4"), ActorRefs.Empty, "T"); //a2, a3
                        actorRefExch.Tell(new InvalidOperationException("TST5"), ActorRefs.Empty, "X"); //a2
                        actorRefExch.Tell(6, ActorRefs.Empty); //drop
                        actorRefExch.Tell(7, ActorRefs.Empty, "T"); //drop

                        //a1: NPE, obj:T; a2: E; a3: E:T
                        actorRefExch.Tell(new RoutingKeySubscriptionMessage(typeof(object), "T"), actorRef1);

                        actorRefExch.Tell(8, ActorRefs.Empty); //drop
                        actorRefExch.Tell(9, ActorRefs.Empty, "X"); //drop
                        actorRefExch.Tell(10, ActorRefs.Empty, "T"); //a1
                        actorRefExch.Tell(new Exception("TST11"), ActorRefs.Empty); //a2
                        actorRefExch.Tell(new Exception("TST12"), ActorRefs.Empty, "X"); //a2
                        actorRefExch.Tell(new Exception("TST13"), ActorRefs.Empty, "T"); //a1,a2,a3

                        //a1: NPE, obj:T; a2: E,E:X; a3: E:T
                        actorRefExch.Tell(new RoutingKeySubscriptionMessage(typeof(Exception), "X"), actorRef2);

                        actorRefExch.Tell(new Exception("TST14"), ActorRefs.Empty, "X"); //a2,a2
                        actorRefExch.Tell(new Exception("TST15"), ActorRefs.Empty, "T"); //a1,a2,a3
                        actorRefExch.Tell(new NullReferenceException("TST16"), ActorRefs.Empty); //a1,a2
                        actorRefExch.Tell(new NullReferenceException("TST17"), ActorRefs.Empty, "T"); //a1,a1,a2,a3
                        actorRefExch.Tell(new NullReferenceException("TST18"), ActorRefs.Empty, "X"); //a1,a2,a2

                        //a1: NPE, obj:T; a2: E:X; a3: E:T
                        actorRefExch.Tell(new RoutingKeyUnSubscriptionMessage(typeof(Exception), null), actorRef2);
                        actorRefExch.Tell(new RoutingKeyUnSubscriptionMessage(typeof(object), null), actorRef1); //ignore
                        actorRefExch.Tell(new RoutingKeyUnSubscriptionMessage(typeof(object), "X"), actorRef1); //ignore
                        actorRefExch.Tell(new RoutingKeyUnSubscriptionMessage(typeof(NullReferenceException), "T"), actorRef1); //ignore
                        actorRefExch.Tell(new RoutingKeyUnSubscriptionMessage(typeof(object), "X"), actorRef2); //ignore

                        actorRefExch.Tell(new Exception("TST19"), ActorRefs.Empty, "X"); //a2
                        actorRefExch.Tell(new Exception("TST20"), ActorRefs.Empty, "T"); //a1,a3
                        actorRefExch.Tell(new NullReferenceException("TST21"), ActorRefs.Empty, "T"); //a1,a1,a3

                        //a1: obj:T, obj; a2: E:X; a3: E:T
                        actorRefExch.Tell(new RoutingKeyUnSubscriptionMessage(typeof(NullReferenceException), null), actorRef1);
                        actorRefExch.Tell(new RoutingKeySubscriptionMessage(typeof(object), null), actorRef1);

                        actorRefExch.Tell(new InvalidOperationException("TST22"), ActorRefs.Empty); //a1
                        actorRefExch.Tell(new InvalidOperationException("TST23"), ActorRefs.Empty, "X"); //a1,a2
                        actorRefExch.Tell(new InvalidOperationException("TST24"), ActorRefs.Empty, "T"); //a1,a1,a3
                        actorRefExch.Tell(25, ActorRefs.Empty, "X"); //a1
                        actorRefExch.Tell(26, ActorRefs.Empty, "T"); //a1,a1

                        actorRefExch.Tell("END", ActorRefs.Empty); //a1, finish

                        if (!waitHandle.WaitOne(3000, false))
                        {
                            output.WriteLine("ERR: Message receive timeout");
                            Assert.True(false, "Timeout");
                        }
                    }

                    //check
                    msgCount1.Should().Be(19);
                    msgCount2.Should().Be(16);
                    msgCount3.Should().Be(7);
                    actorSystem.DeadLetters.Count.Should().Be(6);
                    actorSystem.ErrorMessageQueue.Count.Should().Be(0);
                }
            }
        }

    }
}
