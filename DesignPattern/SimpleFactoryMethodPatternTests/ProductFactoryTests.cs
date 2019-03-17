using Xunit;
using SimpleFactoryMethodPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryMethodPattern.Tests
{
    public class ProductFactoryTests
    {
        [Fact()]
        public void CreateTest()
        {
            Product product = ProductFactory.Create("A");
            Assert.Equal("ProductA",product.GetType().Name);
        }

        [Fact()]
        public void CreateTest_Null_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(()=>ProductFactory.Create(string.Empty));
        }

        [Fact()]
        public void CreateTest_NoExistedProduct_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ProductFactory.Create("E"));
        }

    }
}