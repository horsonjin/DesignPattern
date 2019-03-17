using Xunit;
using ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Tests
{
    public class ConsumerTests
    {
        [Fact()]
        public void ConsumerTest_Subscrible()
        {
            Producer provider = new Producer();
            Consumer consumer1 = new Consumer();
            consumer1.Subscrible(provider);
            Consumer consumer2 = new Consumer();
            consumer2.Subscrible(provider);
            provider.SendMessage("message");

            Assert.Equal("message", consumer1.Records[0]);
            Assert.Equal("message", consumer2.Records[0]);
            Assert.Equal("Completed", consumer1.Records[1]);
            Assert.Equal("Completed", consumer2.Records[1]);
        }

        [Fact()]
        public void ConsumerTest_UnSubscrible()
        {
            Producer provider = new Producer();
            Consumer consumer1 = new Consumer();
            consumer1.Subscrible(provider);
            Consumer consumer2 = new Consumer();
            consumer2.Subscrible(provider);

            consumer1.UnSubscrible();
            consumer2.UnSubscrible();

            provider.SendMessage("message");

            Assert.Empty(consumer1.Records);
            Assert.Empty(consumer2.Records);
        }
    }
}