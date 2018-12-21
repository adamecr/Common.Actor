using Moq;
using net.adamec.lib.common.actor.actor;
using net.adamec.lib.common.actor.actorsystem;
using System;
using System.Threading;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace net.adamec.lib.common.actor.test
{
    public class ScheduledMessagesTests
    {
        private readonly ITestOutputHelper output;

        public ScheduledMessagesTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void WrongScheduledMessageTest()
        {
            //setup
            using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
            {
                //execute
                // ReSharper disable ObjectCreationAsStatement
                // ReSharper disable AccessToDisposedClosure
                Action action1 = () => actorSystem.ScheduleMessage(null,ActorRefs.Empty,TimeSpan.FromMilliseconds(1), "TST");
                Action action2 = () => actorSystem.ScheduleMessage(ActorRefs.Empty,null, TimeSpan.FromMilliseconds(1), "TST");
                Action action3 = () => actorSystem.ScheduleMessage(ActorRefs.Empty, ActorRefs.Empty, TimeSpan.FromMilliseconds(1), null);

                Action action4 = () => actorSystem.ScheduleMessage(null, ActorRefs.Empty, DateTime.Now, "TST");
                Action action5 = () => actorSystem.ScheduleMessage(ActorRefs.Empty, null, DateTime.Now, "TST");
                Action action6 = () => actorSystem.ScheduleMessage(ActorRefs.Empty, ActorRefs.Empty, DateTime.Now, null);
                // ReSharper restore AccessToDisposedClosure         
                // ReSharper restore ObjectCreationAsStatement

                //check
                action1.Should().NotThrow();
                action2.Should().Throw<ArgumentNullException>().WithMessage("Value cannot be null.*Parameter name: recipient");
                action3.Should().Throw<ArgumentNullException>().WithMessage("Value cannot be null.*Parameter name: message");

                action4.Should().NotThrow();
                action5.Should().Throw<ArgumentNullException>().WithMessage("Value cannot be null.*Parameter name: recipient");
                action6.Should().Throw<ArgumentNullException>().WithMessage("Value cannot be null.*Parameter name: message");
            }
        }

        [Theory]
        [InlineData(30, 10)]
        [InlineData(20, 15)]
        public void PeriodicScheduledMessageTest(int delayMs, int count)
        {
            //setup
            const double tolerancePerc = 0.1;
            var messageCounter = 0;
            var lastRun = DateTime.MinValue;
            string messageId = null;
            var isErrTolerance = false;
            Timer t = null;
            using (var waitHandle = new AutoResetEvent(false))
            {
                using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
                {
                    var actorMock = new Mock<IActor>();
                    actorMock.Setup(a => a.CanReceive).Returns(true);

                    actorMock.Setup(a => a.ReceiveTarget).Returns(env =>
                    {
                        output.WriteLine($"{DateTime.Now:mm:ss.fff} Message received");
                        if (messageCounter > 1) //heat time
                            {
                            if (Math.Abs((DateTime.Now - lastRun).Milliseconds - delayMs) > delayMs * tolerancePerc)
                            {
                                output.WriteLine("ERR: Delay higher than tolerance");
                                isErrTolerance = true;
                            }
                        }

                        lastRun = DateTime.Now;
                        messageCounter++;
                        if (messageCounter == count)
                        {
                            // ReSharper disable once AccessToDisposedClosure
                            // ReSharper disable once AccessToModifiedClosure
                            actorSystem.CancelScheduledMessage(messageId);

                            output.WriteLine($"{DateTime.Now:mm:ss.fff} Init stop timer");
                                //wait a bit to check no more messages coming and stop the test
                                t = new Timer(x =>
                                {
                                    output.WriteLine($"{DateTime.Now:mm:ss.fff} Stopping the test");
                                    // ReSharper disable once AccessToDisposedClosure
                                    waitHandle.Set(); //stop the test
                                    }, null, TimeSpan.FromMilliseconds(delayMs * 2), TimeSpan.FromMilliseconds(-1));
                        }

                        return true;
                    });

                    //schedule message
                    var actorRef = actorSystem.RegisterActor(actorMock.Object, "test actor");
                    messageId = actorSystem.ScheduleMessage(ActorRefs.Empty, actorRef,
                        TimeSpan.FromMilliseconds(delayMs), "TST");

                    //keep the test alive while processing the messages
                    if (!waitHandle.WaitOne(delayMs * (count + 5) + 3000, false))
                    {
                        output.WriteLine($"{DateTime.Now:mm:ss.fff} ERR: Message receive timeout");
                        Assert.True(false, "Timeout");
                    }

                    //check
                    Assert.Equal(count, messageCounter); //check the counter
                    if (isErrTolerance) //check the timeout
                    {
                        Assert.True(false, "Error - schedule tolerance");
                    }
                }
            }
            t?.Dispose();
        }

        [Theory]
        [InlineData(30, 5, 10)]
        [InlineData(30, 10, 5)]
        public void CancelScheduledMessagesTest(int delayMs, int countStrMessage, int countIntMessages)
        {
            //helper vars
            var messageCounterStr = 0;
            var messageCounterInt = 0;
            var messageCounterTotal = 0;
            string err = null;
            Timer t = null;
            using (var waitHandle = new AutoResetEvent(false))
            {
                //setup
                using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
                {

                    var actorMock = new Mock<IActor>();
                    actorMock.Setup(a => a.CanReceive).Returns(true);

                    actorMock.Setup(a => a.ReceiveTarget).Returns(env =>
                    {
                        output.WriteLine($"{DateTime.Now:mm:ss.fff} Message received: {env.Message}");


                        // ReSharper disable AccessToDisposedClosure
                        actorSystem.CancelScheduledMessages(env.Sender,typeof(string)); //should have no impact to test - check that it will not cancel wrong messages
                        actorSystem.CancelScheduledMessage("1234567"); //should have no impact to test - check that it will not cancel wrong messages
                        // ReSharper restore AccessToDisposedClosure


                        if (env.Message is string) messageCounterStr++;
                        if (env.Message is int) messageCounterInt++;
                        messageCounterTotal++;

                        if (messageCounterStr == countStrMessage && env.Message is string)
                        {
                            // ReSharper disable once AccessToDisposedClosure
                            actorSystem.CancelScheduledMessages(env.Recipient, typeof(string)); //cancel string message after  {count} messages
                            output.WriteLine($"{DateTime.Now:mm:ss.fff} No more STR messages after this point");
                        }

                        if (messageCounterStr > countStrMessage)
                        {
                            err = "didn't cancel string"; //should not get string message
                        }

                        if (messageCounterInt == countIntMessages && env.Message is int)
                        {
                            // ReSharper disable once AccessToDisposedClosure
                            actorSystem.CancelScheduledMessages(env.Recipient, typeof(int)); //cancel int message
                            output.WriteLine($"{DateTime.Now:mm:ss.fff} No more INT messages after this point");
                        }

                        if (messageCounterInt > countIntMessages)
                        {
                            err = "didn't cancel int"; //should not get int message
                        }

                        if (messageCounterTotal == countStrMessage + countIntMessages)
                        {
                            output.WriteLine($"{DateTime.Now:mm:ss.fff} Init stop timer");
                            //wait a bit to check no more messages coming and stop the test
                            t = new Timer(x =>
                        {
                            output.WriteLine($"{DateTime.Now:mm:ss.fff} Stopping the test");
                            // ReSharper disable once AccessToDisposedClosure
                            waitHandle.Set(); //stop the test
                            }, null, TimeSpan.FromMilliseconds(delayMs * 2), TimeSpan.FromMilliseconds(-1));
                        }

                        return true;
                    });

                    //schedule messages
                    var actorRef = actorSystem.RegisterActor(actorMock.Object, "test actor");
                    actorSystem.ScheduleMessage(ActorRefs.Empty, actorRef, TimeSpan.FromMilliseconds(delayMs),"TST");
                    actorSystem.ScheduleMessage(ActorRefs.Empty, actorRef, TimeSpan.FromMilliseconds(delayMs), 5);

                    //keep the test alive while processing the messages
                    if (!waitHandle.WaitOne(delayMs * (countStrMessage + countIntMessages + 5) + 3000, false))
                    {
                        output.WriteLine($"{DateTime.Now:mm:ss.fff} ERR: Message receive timeout");
                        Assert.True(false, "Timeout");
                    }

                    if (err != null)
                    {
                        Assert.True(false, $"Error - {err}");
                    }
                }
            }
            t?.Dispose();
        }

        [Theory]
        [InlineData(200, 5)]
        [InlineData(40, 15)]
        public void FixScheduleMessageTest(int delayMs, int count)
        {
            //helper vars
            const double tolerancePerc = 0.15;
            var messageCounter = 0;
            var expectedRuns = new DateTime[count];
            var isErrTolerance = false;
            Timer t = null;
            using (var waitHandle = new AutoResetEvent(false))
            {
                //setup
                using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
                {
                    var actorMock = new Mock<IActor>();
                    actorMock.Setup(a => a.CanReceive).Returns(true);

                    actorMock.Setup(a => a.ReceiveTarget).Returns(env =>
                    {
                        output.WriteLine($"{DateTime.Now:mm:ss.fff} Message received");
                        if (messageCounter > 1) //heat time
                        {
                            if (Math.Abs((DateTime.Now - expectedRuns[messageCounter]).Milliseconds) >
                                delayMs * tolerancePerc)
                            {
                                output.WriteLine("ERR: Delay higher than tolerance");
                                isErrTolerance = true;
                            }
                        }

                        messageCounter++;
                        if (messageCounter == count)
                        {
                            output.WriteLine($"{DateTime.Now:mm:ss.fff} Init stop timer");
                            //wait a bit to check no more messages coming and stop the test
                            t = new Timer(x =>
                        {
                            output.WriteLine($"{DateTime.Now:mm:ss.fff} Stopping the test");
                            // ReSharper disable once AccessToDisposedClosure
                            waitHandle.Set(); //stop the test
                        }, null, TimeSpan.FromMilliseconds(delayMs * 2), TimeSpan.FromMilliseconds(-1));
                        }

                        return true;
                    });

                    //schedule messages
                    var actorRef = actorSystem.RegisterActor(actorMock.Object, "test actor");
                    for (var i = 0; i < count; i++)
                    {
                        expectedRuns[i] = DateTime.Now + TimeSpan.FromMilliseconds(100 + delayMs * (i + 1));
                        actorSystem.ScheduleMessage(ActorRefs.Empty, actorRef, expectedRuns[i], $"TST{i}");
                    }

                    //keep the test alive while processing the messages
                    if (!waitHandle.WaitOne(delayMs * (count + 5) + 3000, false))
                    {
                        output.WriteLine($"{DateTime.Now:mm:ss.fff} ERR: Message receive timeout");
                        Assert.True(false, "Timeout");
                    }

                    Assert.Equal(count, messageCounter); //check the counter
                    if (isErrTolerance) //check the timeout
                    {
                        Assert.True(false, "Error - schedule tolerance");
                    }
                }
            }
            t?.Dispose();
        }

        [Theory]
        [InlineData(200, 10, 10, 3, 2)]
        [InlineData(30, 15, 20, 10, 15)]
        public void CancelFixScheduleMessageTest(
            int delayMs,
            int countStrMessage, int countIntMessages,
            int cancelAfterStrMessage, int cancelAfterIntMessages)
        {
            //helper vars
            var messageCounterInt = 0;
            var messageCounterStr = 0;
            var messageCounterTotal = 0;
            Timer t = null;
            using (var waitHandle = new AutoResetEvent(false))
            {

                //setup
                using (var actorSystem = new ActorSystem(ActorSystemOptions.Default))
                {
                    var actorMock = new Mock<IActor>();
                    actorMock.Setup(a => a.CanReceive).Returns(true);

                    actorMock.Setup(a => a.ReceiveTarget).Returns(env =>
                    {
                        output.WriteLine($"{DateTime.Now:mm:ss.fff} Message received {env.Message}");

                        if (env.Message is string)
                        {
                            messageCounterStr++;
                            if (messageCounterStr == cancelAfterStrMessage)
                            {
                                // ReSharper disable once AccessToDisposedClosure
                                actorSystem.CancelScheduledMessages(env.Recipient, typeof(string));
                                output.WriteLine($"{DateTime.Now:mm:ss.fff} No more STR messages after this");
                            }
                        }

                        if (env.Message is int)
                        {
                            messageCounterInt++;
                            if (messageCounterInt == cancelAfterIntMessages)
                            {
                                // ReSharper disable once AccessToDisposedClosure
                                actorSystem.CancelScheduledMessages(env.Recipient, typeof(int));
                                output.WriteLine($"{DateTime.Now:mm:ss.fff} No more INT messages after this");
                            }
                        }

                        messageCounterTotal++;
                        output.WriteLine($"T:{messageCounterTotal}");
                        if (messageCounterTotal == cancelAfterIntMessages + cancelAfterStrMessage)
                        {
                            output.WriteLine($"{DateTime.Now:mm:ss.fff} Init stop timer");
                            //wait a bit to check no more messages coming and stop the test
                            t = new Timer(x =>
                        {
                            output.WriteLine($"{DateTime.Now:mm:ss.fff} Stopping the test");
                            // ReSharper disable once AccessToDisposedClosure
                            waitHandle.Set(); //stop the test
                        }, null, TimeSpan.FromMilliseconds(delayMs * 2), TimeSpan.FromMilliseconds(-1));
                        }

                        return true;
                    });

                    //schedule messages
                    var actorRef = actorSystem.RegisterActor(actorMock.Object, "test actor");
                    for (var i = 0; i < Math.Max(countIntMessages, countStrMessage); i++)
                    {
                        var expectedRun = DateTime.Now + TimeSpan.FromMilliseconds(100 + delayMs * (i + 1));
                        if (i < countStrMessage)
                        {
                            actorSystem.ScheduleMessage(ActorRefs.Empty, actorRef, expectedRun, $"TST{i}");
                        }

                        // ReSharper disable once InvertIf
                        if (i < countIntMessages)
                        {
                            actorSystem.ScheduleMessage(ActorRefs.Empty, actorRef, expectedRun, i);
                        }
                    }

                    //keep the test alive while processing the messages
                    if (!waitHandle.WaitOne(delayMs * (Math.Max(countIntMessages, countStrMessage) + 5) + 3000,
                        false))
                    {
                        output.WriteLine($"{DateTime.Now:mm:ss.fff} ERR: Message receive timeout");
                        Assert.True(false, "Timeout");
                    }

                    Assert.Equal(cancelAfterIntMessages, messageCounterInt); //check the counter - INT
                    Assert.Equal(cancelAfterStrMessage, messageCounterStr); //check the counter - INT
                }
            }
            t?.Dispose();
        }
    }
}
