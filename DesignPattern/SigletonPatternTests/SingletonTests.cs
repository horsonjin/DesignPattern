using Xunit;
using SigletonPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigletonPattern.Tests
{
    public class SingletonTests
    {
        [Fact()]
        public void IncrementTest()
        {
            Singleton instance1 = Singleton.GetInstance();
            instance1.Increment();
            Singleton instance2 = Singleton.GetInstance();
            instance2.Increment();

            Assert.Equal(2, Singleton.GetInstance().Counter);
        }
    }
}