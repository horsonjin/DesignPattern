using Xunit;
using FactoryMethodPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Tests
{
    public class FactoryMethodPatternTest
    {
        [Fact()]
        public void ProductAFactoryTest()
        {
            IFactory factory = new ProductAFactory();
            Assert.Equal("ProductA", factory.Create().GetType().Name);
        }

        [Fact()]
        public void ProductBFactoryTest()
        {
            IFactory factory = new ProductBFactory();
            Assert.Equal("ProductB", factory.Create().GetType().Name);
        }
    }
}