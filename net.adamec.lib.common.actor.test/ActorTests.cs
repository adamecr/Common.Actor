using System.Threading;
using FluentAssertions;
using Moq;
using Moq.Protected;
using net.adamec.lib.common.actor.actor;
using net.adamec.lib.common.actor.actorsystem;
using net.adamec.lib.common.actor.message;
using Xunit;

namespace net.adamec.lib.common.actor.test
{
    public class ActorTests
    {
      
        [Fact]
        public void DefaultActorAllUnhandledTest()
        {
            //setup
            using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
            {
                var actorMock = new Mock<Actor>(actorSystem, "Test Actor") { CallBase = true };

                using (var actor = actorMock.Object)
                {
                    //execute
                    actor.Self.Tell("TST1", ActorRefs.Empty);
                    actor.Self.Tell("TST2", ActorRefs.Empty);

                    Thread.Sleep(200);

                    //check
                    actorSystem.DeadLetters.Count.Should().Be(2);
                }
            }
        }

        [Fact]
        public void ActorOverrideReceiveToHandleAllTest()
        {
            //setup
            using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
            {
                var actorMock = new Mock<Actor>(actorSystem, "Test Actor") { CallBase = true };
                actorMock.Protected().Setup<bool>("Receive", ItExpr.IsAny<Envelope>()).Returns(true);
                using (var actor = actorMock.Object)
                {
                    //execute
                    actor.Self.Tell("TST1", ActorRefs.Empty);
                    actor.Self.Tell("TST2", ActorRefs.Empty);

                    Thread.Sleep(200);

                    //check
                    actorSystem.DeadLetters.Count.Should().Be(0);
                }
            }
        }

        public sealed class BecomeTestActor : Actor
        {
            public int HandledR;
            public int Handled1;
            public int Handled2;
            public int Handled3;

            public BecomeTestActor(IActorSystem actorSystem, string name) : base(actorSystem, name)
            {
                Become(Handler1);
            }
            protected override bool Receive(Envelope envelope)
            {
                HandledR++;
                Switch(envelope.Message as string);
                return true;
            }

            private bool Handler1(Envelope envelope)
            {
                Handled1++;
                Switch(envelope.Message as string);
                return true;
            }

            private bool Handler2(Envelope envelope)
            {
                Handled2++;
                Switch(envelope.Message as string);
                return true;
            }

            private bool Handler3(Envelope envelope)
            {
                Handled3++;
                Switch(envelope.Message as string);
                return true;
            }

            private void Switch(string msg)
            {
                switch (msg)
                {
                    case "SW1":
                        Become(Handler1);
                        break;
                    case "SW2":
                        Become(Handler2);
                        break;
                    case "SW3":
                        Become(Handler3);
                        break;
                    case "SWR":
                        BecomeDefault();
                        break;
                    case "SWD":
                        Become(null);
                        break;
                }
            }
        }

        [Fact]
        public void ActorBecomeTest()
        {
            //setup
            using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
            {
                using (var actor = new BecomeTestActor(actorSystem, "Test Actor"))
                {
                    //execute
                    actor.Self.Tell("TST0", ActorRefs.Empty); //H1
                    actor.Self.Tell("SW2", ActorRefs.Empty); //H1
                    actor.Self.Tell("TST1", ActorRefs.Empty); //H2
                    actor.Self.Tell("TST2", ActorRefs.Empty); //H2
                    actor.Self.Tell("SW1", ActorRefs.Empty); //H2
                    actor.Self.Tell("SW3", ActorRefs.Empty); //H1
                    actor.Self.Tell("TST3", ActorRefs.Empty); //H3
                    actor.Self.Tell("TST4", ActorRefs.Empty); //H3
                    actor.Self.Tell("TST5", ActorRefs.Empty); //H3
                    actor.Self.Tell("SWR", ActorRefs.Empty); //H3
                    actor.Self.Tell("TST6", ActorRefs.Empty); //Default receive
                    actor.Self.Tell("SWD", ActorRefs.Empty); //Default receive
                    actor.Self.Tell("TST7", ActorRefs.Empty); //Deadletter
                    actor.Self.Tell("TST8", ActorRefs.Empty); //Deadletter

                    Thread.Sleep(200);

                    //check
                    actor.Handled1.Should().Be(3);
                    actor.Handled2.Should().Be(3);
                    actor.Handled3.Should().Be(4);
                    actor.HandledR.Should().Be(2);
                    actorSystem.DeadLetters.Count.Should().Be(2);
                }
            }
        }

        public sealed class ActorCleanupOnDisposeTestActor : Actor
        {
           public ActorCleanupOnDisposeTestActor(IActorSystem actorSystem, string name) : base(actorSystem, name)
           {
               CanReceive = false;
           }
        }

        [Fact]
        public void ActorCleanupOnDisposeTest()
        {
            //setup
            using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
            {
                using (var actor = new ActorCleanupOnDisposeTestActor(actorSystem,"Test"))
                {
                    //execute
                    actor.Self.Tell("TST1", ActorRefs.Empty);
                    actor.Self.Tell("TST2", ActorRefs.Empty);

                    Thread.Sleep(200);

                    //check
                    actorSystem.DeadLetters.Count.Should().Be(0);
                }
                actorSystem.DeadLetters.Count.Should().Be(2); //cleanup on dispose
            }
        }
    }
}
