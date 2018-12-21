using System;
using System.Threading;
using FluentAssertions;
using Moq;
using net.adamec.lib.common.actor.actor;
using net.adamec.lib.common.actor.actorsystem;
using net.adamec.lib.common.actor.message;
using Xunit;
using Xunit.Abstractions;

namespace net.adamec.lib.common.actor.test
{
    public class BasicActorSystemTests
    {
        private readonly ITestOutputHelper output;

        public BasicActorSystemTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void ActorRegistrationTest()
        {
            //setup
            var actorMock = new Mock<IActor>();
            using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
            {
                //execute
                var actorRef = actorSystem.RegisterActor(actorMock.Object, "test actor");
                actorSystem.DeRegisterActor(actorRef);

                var actorRefMock = new Mock<IActorRef>();
                actorSystem.DeRegisterActor(actorRefMock.Object); //should be OK - Actor System ignores wrong deregistration

                //check
                actorRef.Should().NotBeNull();
                actorSystem.Should().NotBeNull();

            }
        }

        [Fact]
        public void SpecialActorsTest()
        {
            //setup
            IActorRef sender1 = null;
            IActorRef sender2 = null;
            using (var waitHandle = new AutoResetEvent(false))
            {
                var actorMock = new Mock<IActor>();
                actorMock.Setup(a => a.CanReceive).Returns(true);
                actorMock.Setup(a => a.ReceiveTarget).Returns(msg =>
                {
                    output.WriteLine($"Message received: {msg.Message} from {msg.Sender.Name}");
                    if (sender1 == null)
                    {
                        //msg 1
                        sender1 = msg.Sender;
                        output.WriteLine($"Sender1= {msg.Sender.Name}");
                    }
                    else
                    {
                        //msg2
                        sender2 = msg.Sender;
                        output.WriteLine($"Sender2= {msg.Sender.Name}");
                        // ReSharper disable once AccessToDisposedClosure
                        waitHandle.Set();
                    }

                    return true;
                });

                using (var actorSystem = new ActorSystem(new ActorSystemOptions
                {
                    LogDispatchMessages = true,
                    LogEnqueuedMessages = true,
                    LogNotHandledMessages = true,
                    MaxDispatchMessagesInBatch = 5
                }))
                {
                    //execute
                    ActorRefs.Empty.Tell("TST", null); //nothing should happen
                    ActorRefs.System.Tell("TST", null); //nothing should happen
                    var actorRef = actorSystem.RegisterActor(actorMock.Object, "tst actor");
                    actorRef.Tell("TSTnil", null);
                    actorRef.Tell("TSTsys", ActorRefs.System);

                    if (!waitHandle.WaitOne(2000, false))
                    {
                        output.WriteLine("ERR: Message receive timeout");
                        Assert.True(false, "Timeout");
                    }

                    //check
                    sender1.Should().Be(ActorRefs.Empty);
                    sender2.Should().Be(ActorRefs.System);
                    actorSystem.DeadLetters.Count.Should().Be(0);
                    actorSystem.ErrorMessageQueue.Count.Should().Be(0);
                }
            }
        }

        [Fact]
        public void ActorWrongRegistrationTest()
        {
            //setup
            using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
            {
                var actorMock = new Mock<IActor>();
                actorMock.Setup(a => a.CanReceive).Returns(true);
                actorMock.Setup(a => a.ReceiveTarget).Returns(msg => true);

                //execute
                // ReSharper disable AccessToDisposedClosure
                Action actNoActor = () => actorSystem.RegisterActor(null, "test actor");
                Action actNoName = () => actorSystem.RegisterActor(actorMock.Object, null);
                Action actEmptyName = () => actorSystem.RegisterActor(actorMock.Object, "");
                // ReSharper restore AccessToDisposedClosure

                //check
                actorSystem.Should().NotBeNull();

                actNoActor.Should().Throw<ArgumentNullException>().WithMessage("Value cannot be null.*Parameter name: actor");
                actNoName.Should().Throw<ArgumentNullException>().WithMessage("Value cannot be null.*Parameter name: name");
                actEmptyName.Should().Throw<ArgumentNullException>().WithMessage("Value cannot be null.*Parameter name: name");
            }
        }

        [Theory]
        [InlineData("TST")]
        [InlineData(5)]
        public void ActorSimpleMessageTest(object msgIn)
        {
            //setup
            using (var waitHandle = new AutoResetEvent(false))
            {
                var actorMock = new Mock<IActor>();
                actorMock.Setup(a => a.CanReceive).Returns(true);
                actorMock.Setup(a => a.ReceiveTarget).Returns(env =>
                {
                    output.WriteLine("Message received");
                    env.Should().NotBeNull();

                    var msg = env.Message;
                    msg.Should().BeOfType(msgIn.GetType());
                    msg.Should().Be(msgIn);
                    // ReSharper disable once AccessToDisposedClosure
                    waitHandle.Set();
                    return true;
                });

                using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
                {
                    var actorRef = actorSystem.RegisterActor(actorMock.Object, "test actor");

                    //execute
                    actorRef.Tell(msgIn, ActorRefs.Empty);

                    if (!waitHandle.WaitOne(2000, false))
                    {
                        output.WriteLine("ERR: Message receive timeout");
                        Assert.True(false, "Timeout");
                    }

                    //check
                    actorSystem.Should().NotBeNull();
                    actorRef.Should().NotBeNull();
                }
            }
        }

        [Fact]
        public void ActorSystemStartStopTest()
        {
            //setup
            using (var waitHandle = new AutoResetEvent(false))
            {

                var actorMock = new Mock<IActor>();
                actorMock.Setup(a => a.CanReceive).Returns(true);
                actorMock.Setup(a => a.ReceiveTarget).Returns(env =>
                {
                    output.WriteLine("Message received");
                    // ReSharper disable once AccessToDisposedClosure
                    waitHandle.Set();
                    return true;
                });

                using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
                {
                    var actorRef = actorSystem.RegisterActor(actorMock.Object, "test actor");

                    //execute
                    actorSystem.Stop();
                    actorRef.Tell("TST", ActorRefs.Empty);

                    if (!waitHandle.WaitOne(1000, false))
                    {
                        output.WriteLine("OK: Timeout while stopped");
                        Assert.True(true, "OK-Timeout on stop");
                    }
                    else
                    {
                        output.WriteLine("ERR: Message should not be delivered");
                        Assert.True(false, "Message should not be delivered");
                    }

                    waitHandle.Reset();
                    actorSystem.Start();

                    if (!waitHandle.WaitOne(10000, false))
                    {
                        output.WriteLine("ERR: Message receive timeout");
                        Assert.True(false, "Timeout");
                    }
                    else
                    {
                        output.WriteLine("OK: Message delivered");
                        Assert.True(true, "Message delivered");
                    }

                    //check
                    actorSystem.Should().NotBeNull();
                    actorRef.Should().NotBeNull();
                }
            }
        }

        [Fact]
        public void ActorExecutionExceptionAndDeadLetterTest()
        {
            //setup
            using (var waitHandle = new AutoResetEvent(false))
            {
                using (var actorSystem = new ActorSystem(new ActorSystemOptions
                {
                    LogDispatchMessages = true,
                    LogEnqueuedMessages = true,
                    LogNotHandledMessages = true,
                    MaxDispatchMessagesInBatch = 5
                }))
                {
                    var actorMock = new Mock<IActor>();

                    actorMock.Setup(a => a.CanReceive).Returns(true);
                    actorMock.Setup(a => a.ReceiveTarget).Returns(env =>
                    {
                        if (env.Message.ToString().StartsWith("EX"))
                        {
                            throw new ApplicationException("TST EXCEPTION");
                        }

                        if (env.Message.ToString().StartsWith("END"))
                        {
                            // ReSharper disable once AccessToDisposedClosure
                            waitHandle.Set();
                        }

                        return !env.Message.ToString().StartsWith("DL");
                    });


                    var actorRef = actorSystem.RegisterActor(actorMock.Object, "test actor");
                    //execute
                    actorRef.Tell("TST1", ActorRefs.Empty);
                    actorRef.Tell("DL1", ActorRefs.Empty);
                    actorRef.Tell("TST2", ActorRefs.Empty);
                    actorRef.Tell("TST3", ActorRefs.Empty);
                    actorRef.Tell("EX1", ActorRefs.Empty);
                    actorRef.Tell("DL2", ActorRefs.Empty);
                    actorRef.Tell("EX2", ActorRefs.Empty);
                    actorRef.Tell("TST3", ActorRefs.Empty);
                    actorRef.Tell("DL3", ActorRefs.Empty);
                    actorRef.Tell("DL4", ActorRefs.Empty);
                    actorRef.Tell("TST4", ActorRefs.Empty);
                    actorRef.Tell("TST5", ActorRefs.Empty);
                    actorRef.Tell("END", ActorRefs.Empty);

                    if (!waitHandle.WaitOne(3000, false))
                    {
                        output.WriteLine("ERR: Message receive timeout");
                        Assert.True(false, "Timeout");
                    }

                    //check
                    actorSystem.ErrorMessageQueue.Count.Should().Be(2);
                    actorSystem.DeadLetters.Count.Should().Be(4);
                }
            }
        }

        [Fact]
        public void AskOkTest()
        {
            //setup
            var actorMock = new Mock<IActor>();
            IActorRef actorRef = null;
            actorMock.Setup(a => a.CanReceive).Returns(true);
            actorMock.Setup(a => a.ReceiveTarget).Returns(env =>
            {
                if (!(env.Message is int intMessage)) return false;

                // ReSharper disable once AccessToModifiedClosure
                env.Sender.Tell(intMessage.ToString(), actorRef); //should be ignored - not int type
                Thread.Sleep(intMessage);
                // ReSharper disable once AccessToModifiedClosure
                env.Sender.Tell(intMessage * 2, actorRef);
                return true;
            });

            using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
            {
                actorRef = actorSystem.RegisterActor(actorMock.Object, "test actor");

                //execute
                var response1 = actorSystem.Ask<int>(actorRef, 20, 200);
                var response2 = (int)actorSystem.Ask(actorRef, 10, typeof(int), 200, true);

                //check
                response1.Should().Be(20 * 2);
                response2.Should().Be(10 * 2);
                actorSystem.DeRegisterActor(actorRef);
            }
        }

        [Fact]
        public void AskTimeoutTest()
        {
            //setup
            var actorMock = new Mock<IActor>();
            IActorRef actorRef = null;
            actorMock.Setup(a => a.CanReceive).Returns(true);
            actorMock.Setup(a => a.ReceiveTarget).Returns(env =>
            {
                if (!(env.Message is int intMessage)) return false;

                Thread.Sleep(intMessage);
                // ReSharper disable once AccessToModifiedClosure
                env.Sender.Tell(intMessage * 2, actorRef);
                return true;
            });

            using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
            {
                actorRef = actorSystem.RegisterActor(actorMock.Object, "test actor");

                //execute
                var response1 = actorSystem.Ask<int>(actorRef, 20, 5);
                var response2 = (int)actorSystem.Ask(actorRef, 10, typeof(int), 5);

                //check
                response1.Should().Be(0);
                response2.Should().Be(0);
                actorSystem.DeRegisterActor(actorRef);

            }
        }

        [Fact]
        public void AskTimeoutExceptionTest()
        {
            //setup
            var actorMock = new Mock<IActor>();
            IActorRef actorRef = null;
            actorMock.Setup(a => a.CanReceive).Returns(true);
            actorMock.Setup(a => a.ReceiveTarget).Returns(env =>
            {
                if (!(env.Message is int intMessage)) return false;

                Thread.Sleep(intMessage);
                // ReSharper disable once AccessToModifiedClosure
                env.Sender.Tell(intMessage * 2, actorRef);
                return true;
            });

            using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
            {
                actorRef = actorSystem.RegisterActor(actorMock.Object, "test actor");

                //execute
                // ReSharper disable AccessToDisposedClosure
                Action action1 = () => actorSystem.Ask<int>(actorRef, 20, 5, true);
                Action action2 = () => actorSystem.Ask(actorRef, 10, typeof(int), 5, true);
                // ReSharper restore AccessToDisposedClosure

                //check
                action1.Should().Throw<TimeoutException>();
                action2.Should().Throw<TimeoutException>();
            }
        }

        [Fact]
        public void AskWrongParamTest()
        {
            //setup
            IActorRef actorRef = null;

            var actorMock = new Mock<IActor>();
            actorMock.Setup(a => a.CanReceive).Returns(true);
            actorMock.Setup(a => a.ReceiveTarget).Returns(env =>
            {
                if (!(env.Message is int intMessage)) return false;

                Thread.Sleep(intMessage);
                // ReSharper disable once AccessToModifiedClosure
                env.Sender.Tell(intMessage * 2, actorRef);
                return true;
            });

            using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
            {
                actorRef = actorSystem.RegisterActor(actorMock.Object, "test actor");

                //execute

                // ReSharper disable AccessToDisposedClosure
                Action action1 = () => actorSystem.Ask<int>(null, 20, 5, true);
                Action action2 = () => actorSystem.Ask(actorRef, 10, null, 5, true);
                Action action3 = () => actorSystem.Ask<int>(actorRef, null, 0);
                // ReSharper restore AccessToDisposedClosure

                //check
                action1.Should().Throw<ArgumentNullException>().WithMessage("Value cannot be null.*Parameter name: recipient");
                action2.Should().Throw<ArgumentNullException>().WithMessage("Value cannot be null.*Parameter name: responseType");
                action3.Should().Throw<ArgumentNullException>().WithMessage("Value cannot be null.*Parameter name: message");
            }

        }

        [Fact]
        public void ActorCanReceiveTest()
        {
            var canReceive = false;
            //setup
            using (var waitHandle = new AutoResetEvent(false))
            {

                var actorMock = new Mock<IActor>();
                // ReSharper disable once AccessToModifiedClosure
                actorMock.Setup(a => a.CanReceive).Returns(() => canReceive);
                actorMock.Setup(a => a.ReceiveTarget).Returns(env =>
                {
                    output.WriteLine("Message received");
                    // ReSharper disable once AccessToDisposedClosure
                    waitHandle.Set();
                    return true;
                });

                using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
                {
                    var actorRef = actorSystem.RegisterActor(actorMock.Object, "test actor");

                    //execute
                    actorRef.Tell("TST", ActorRefs.Empty);

                    if (!waitHandle.WaitOne(500, false))
                    {
                        output.WriteLine("OK: Timeout while canreceive=false");
                        Assert.True(true, "OK-Timeout while canreceive=false");
                    }
                    else
                    {
                        output.WriteLine("ERR: Message should not be delivered");
                        Assert.True(false, "Message should not be delivered");
                    }

                    waitHandle.Reset();
                    canReceive = true;

                    if (!waitHandle.WaitOne(10000, false))
                    {
                        output.WriteLine("ERR: Message receive timeout");
                        Assert.True(false, "Timeout");
                    }
                    else
                    {
                        output.WriteLine("OK: Message delivered");
                        Assert.True(true, "Message delivered");
                    }

                }
            }
        }

        [Fact]
        public void ActorWrongTargetTest()
        {
            var actorMock = new Mock<IActor>();
            // ReSharper disable once AccessToModifiedClosure
            actorMock.Setup(a => a.CanReceive).Returns(true);
            actorMock.Setup(a => a.ReceiveTarget).Returns((Receive)null);

            using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
            {
                var actorRef = actorSystem.RegisterActor(actorMock.Object, "test actor");

                //execute
                actorRef.Tell("TST", ActorRefs.Empty);
                Thread.Sleep(200);

                //check
                actorSystem.ErrorMessageQueue.HasMessages.Should().Be(true);
                actorSystem.ErrorMessageQueue.Count.Should().Be(1);
                var err = actorSystem.ErrorMessageQueue.TryDequeue(out var errMessageEnvelope);
                err.Should().BeTrue();
                errMessageEnvelope.Should().NotBeNull();
                errMessageEnvelope.Should().BeOfType<ErrorMessage>();
                var errMessage = errMessageEnvelope as ErrorMessage;
                errMessage?.Exception.Should().BeOfType<InvalidOperationException>();
                errMessage?.Error.Should().Be("ReceiveTarget for actor test actor is not set");
            }
        }

        [Fact]
        public void ActorCanReceiveComplexTest()
        {
            var canReceive = true;
            var totalMessages = 0;
            //setup
            using (var waitHandle = new AutoResetEvent(false))
            {

                var actorMock = new Mock<IActor>();
                // ReSharper disable once AccessToModifiedClosure
                actorMock.Setup(a => a.CanReceive).Returns(() => canReceive);
                actorMock.Setup(a => a.ReceiveTarget).Returns(env =>
                {
                    output.WriteLine("Message received");
                    totalMessages++;
                    // ReSharper disable once AccessToDisposedClosure
                    if (env.Message.ToString() == "RST") waitHandle.Set();
                    return true;
                });

                using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
                {
                    var actorRef = actorSystem.RegisterActor(actorMock.Object, "test actor");

                    //execute and check
                    actorRef.Tell("RST", ActorRefs.Empty);

                    if (!waitHandle.WaitOne(10000, false))
                    {
                        output.WriteLine("ERR: Message receive timeout");
                        Assert.True(false, "Timeout");
                    }
                    else
                    {
                        output.WriteLine("OK: Message delivered");
                        Assert.True(true, "Message delivered");
                    }

                    waitHandle.Reset();
                    canReceive = false;
                    actorRef.Tell("TST", ActorRefs.Empty);
                    actorRef.Tell("TST", ActorRefs.Empty);
                    actorRef.Tell("RST", ActorRefs.Empty);

                    if (!waitHandle.WaitOne(500, false))
                    {
                        output.WriteLine("OK: Timeout while canreceive=false");
                        Assert.True(true, "OK-Timeout while canreceive=false");
                    }
                    else
                    {
                        output.WriteLine("ERR: Message should not be delivered");
                        Assert.True(false, "Message should not be delivered");
                    }

                    totalMessages.Should().Be(1); //just one processed message at this point
                    waitHandle.Reset();
                    canReceive = true;

                    if (!waitHandle.WaitOne(10000, false))
                    {
                        output.WriteLine("ERR: Message receive timeout");
                        Assert.True(false, "Timeout");
                    }
                    else
                    {
                        output.WriteLine("OK: Message delivered");
                        Assert.True(true, "Message delivered");
                    }
                    totalMessages.Should().Be(4);
                }
            }
        }

        [Fact]
        public void ActorDeregisterQueueCleanupTest()
        {

            //setup
            using (var waitHandle = new AutoResetEvent(false))
            {
                using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
                {
                    var actorMock = new Mock<IActor>();
                    actorMock.Setup(a => a.CanReceive).Returns(() => false);

                    var actorRef = actorSystem.RegisterActor(actorMock.Object, "test actor");

                    //execute
                    actorRef.Tell("TST", ActorRefs.Empty);
                    actorRef.Tell("TST", ActorRefs.Empty);
                    actorRef.Tell("TST", ActorRefs.Empty);
                    actorRef.Tell("TST", ActorRefs.Empty);

                    if (!waitHandle.WaitOne(500, false))
                    {
                        output.WriteLine("OK: Timeout while canreceive=false");
                        Assert.True(true, "OK-Timeout while canreceive=false");
                    }
                    else
                    {
                        output.WriteLine("ERR: Message should not be delivered");
                        Assert.True(false, "Message should not be delivered");
                    }

                    actorSystem.DeadLetters.Count.Should().Be(0); //no dead letters
                    actorSystem.DeRegisterActor(actorRef);

                    //check
                    actorSystem.DeadLetters.Count.Should().Be(4); //actor messages should go to dead letters

                }
            }
        }

        [Fact]
        public void ForwardTest()
        {
            //setup
            var actorRef2 = ActorRefs.Empty;
            var sender = ActorRefs.Empty;
            using (var waitHandle = new AutoResetEvent(false))
            {
                var actorMock0 = new Mock<IActor>();
                actorMock0.Setup(a => a.CanReceive).Returns(false);

                var actorMock1 = new Mock<IActor>();
                actorMock1.Setup(a => a.CanReceive).Returns(true);
                actorMock1.Setup(a => a.ReceiveTarget).Returns(env =>
                {
                    output.WriteLine("Message received 1");
                    // ReSharper disable once AccessToModifiedClosure
                    env.ForwardTo(actorRef2);
                    output.WriteLine("Message forwarded");
                    return true;
                });

                var actorMock2 = new Mock<IActor>();
                actorMock2.Setup(a => a.CanReceive).Returns(true);
                actorMock2.Setup(a => a.ReceiveTarget).Returns(env =>
                {
                    output.WriteLine("Message received 2");
                    sender = env.Sender;
                    // ReSharper disable once AccessToDisposedClosure
                    waitHandle.Set();
                    return true;
                });

                using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
                {
                    var actorRef0 = actorSystem.RegisterActor(actorMock0.Object, "test actor0");
                    var actorRef1 = actorSystem.RegisterActor(actorMock1.Object, "test actor1");
                    actorRef2 = actorSystem.RegisterActor(actorMock2.Object, "test actor2");

                    //execute and check
                    actorRef1.Tell("TST", actorRef0);

                    if (!waitHandle.WaitOne(10000, false))
                    {
                        output.WriteLine("ERR: Message receive timeout");
                        Assert.True(false, "Timeout");
                    }

                    sender.Should().Be(actorRef0);

                }
            }
        }

        [Fact]
        public void ForwardKeepRoutingKeyTest()
        {
            //setup
            var actorRef2 = ActorRefs.Empty;
            var sender = ActorRefs.Empty;
            var routingKey = "";
            using (var waitHandle = new AutoResetEvent(false))
            {
                var actorMock0 = new Mock<IActor>();
                actorMock0.Setup(a => a.CanReceive).Returns(false);

                var actorMock1 = new Mock<IActor>();
                actorMock1.Setup(a => a.CanReceive).Returns(true);
                actorMock1.Setup(a => a.ReceiveTarget).Returns(env =>
                {
                    output.WriteLine("Message received 1");
                    // ReSharper disable once AccessToModifiedClosure
                    env.ForwardTo(actorRef2);
                    output.WriteLine("Message forwarded");
                    return true;
                });

                var actorMock2 = new Mock<IActor>();
                actorMock2.Setup(a => a.CanReceive).Returns(true);
                actorMock2.Setup(a => a.ReceiveTarget).Returns(env =>
                {
                    output.WriteLine("Message received 2");
                    sender = env.Sender;
                    routingKey = env.RoutingKey;
                    // ReSharper disable once AccessToDisposedClosure
                    waitHandle.Set();
                    return true;
                });

                using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
                {
                    var actorRef0 = actorSystem.RegisterActor(actorMock0.Object, "test actor0");
                    var actorRef1 = actorSystem.RegisterActor(actorMock1.Object, "test actor1");
                    actorRef2 = actorSystem.RegisterActor(actorMock2.Object, "test actor2");

                    //execute and check
                    actorRef1.Tell("TST", actorRef0,"KEY");

                    if (!waitHandle.WaitOne(10000, false))
                    {
                        output.WriteLine("ERR: Message receive timeout");
                        Assert.True(false, "Timeout");
                    }

                    sender.Should().Be(actorRef0);
                    routingKey.Should().Be("KEY");

                }
            }
        }

        [Fact]
        public void ForwardChangeRoutingKeyTest()
        {
            //setup
            var actorRef2 = ActorRefs.Empty;
            var sender = ActorRefs.Empty;
            var routingKey = "";
            using (var waitHandle = new AutoResetEvent(false))
            {
                var actorMock0 = new Mock<IActor>();
                actorMock0.Setup(a => a.CanReceive).Returns(false);

                var actorMock1 = new Mock<IActor>();
                actorMock1.Setup(a => a.CanReceive).Returns(true);
                actorMock1.Setup(a => a.ReceiveTarget).Returns(env =>
                {
                    output.WriteLine("Message received 1");
                    // ReSharper disable once AccessToModifiedClosure
                    env.ForwardTo(actorRef2,"NEW");
                    output.WriteLine("Message forwarded");
                    return true;
                });

                var actorMock2 = new Mock<IActor>();
                actorMock2.Setup(a => a.CanReceive).Returns(true);
                actorMock2.Setup(a => a.ReceiveTarget).Returns(env =>
                {
                    output.WriteLine("Message received 2");
                    sender = env.Sender;
                    routingKey = env.RoutingKey;
                    // ReSharper disable once AccessToDisposedClosure
                    waitHandle.Set();
                    return true;
                });

                using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
                {
                    var actorRef0 = actorSystem.RegisterActor(actorMock0.Object, "test actor0");
                    var actorRef1 = actorSystem.RegisterActor(actorMock1.Object, "test actor1");
                    actorRef2 = actorSystem.RegisterActor(actorMock2.Object, "test actor2");

                    //execute and check
                    actorRef1.Tell("TST", actorRef0, "KEY");

                    if (!waitHandle.WaitOne(10000, false))
                    {
                        output.WriteLine("ERR: Message receive timeout");
                        Assert.True(false, "Timeout");
                    }

                    sender.Should().Be(actorRef0);
                    routingKey.Should().Be("NEW");

                }
            }
        }

        [Fact]
        public void ForwardExceptionTest()
        {
            //setup
            var actorMock = new Mock<IActor>();
            actorMock.Setup(a => a.CanReceive).Returns(true);
            actorMock.Setup(a => a.ReceiveTarget).Returns(env =>
            {
                output.WriteLine("Message received");
                    // ReSharper disable once AccessToModifiedClosure
                    env.ForwardTo(null);
                return true;
            });


            using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
            {
                var actorRef1 = actorSystem.RegisterActor(actorMock.Object, "test actor");

                //execute and check
                actorRef1.Tell("TST", ActorRefs.Empty);

                Thread.Sleep(100);

                //check
                actorSystem.ErrorMessageQueue.HasMessages.Should().Be(true);
                actorSystem.ErrorMessageQueue.Count.Should().Be(1);
                var err = actorSystem.ErrorMessageQueue.TryDequeue(out var errMessageEnvelope);
                err.Should().BeTrue();
                errMessageEnvelope.Should().NotBeNull();
                errMessageEnvelope.Should().BeOfType<ErrorMessage>();
                var errMessage = errMessageEnvelope as ErrorMessage;
                errMessage?.Exception.Should().BeOfType<ArgumentNullException>();
                errMessage?.Error.Should().Match("Value cannot be null.*Parameter name: recipient");

            }

        }

        [Fact]
        public void ForwardException2Test()
        {
            //setup
            var actorMock = new Mock<IActor>();
            actorMock.Setup(a => a.CanReceive).Returns(true);
            actorMock.Setup(a => a.ReceiveTarget).Returns(env =>
            {
                output.WriteLine("Message received");
                // ReSharper disable once AccessToModifiedClosure
                env.ForwardTo(null,"any");
                return true;
            });


            using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
            {
                var actorRef1 = actorSystem.RegisterActor(actorMock.Object, "test actor");

                //execute and check
                actorRef1.Tell("TST", ActorRefs.Empty);

                Thread.Sleep(100);

                //check
                actorSystem.ErrorMessageQueue.HasMessages.Should().Be(true);
                actorSystem.ErrorMessageQueue.Count.Should().Be(1);
                var err = actorSystem.ErrorMessageQueue.TryDequeue(out var errMessageEnvelope);
                err.Should().BeTrue();
                errMessageEnvelope.Should().NotBeNull();
                errMessageEnvelope.Should().BeOfType<ErrorMessage>();
                var errMessage = errMessageEnvelope as ErrorMessage;
                errMessage?.Exception.Should().BeOfType<ArgumentNullException>();
                errMessage?.Error.Should().Match("Value cannot be null.*Parameter name: recipient");

            }

        }
    }
}
