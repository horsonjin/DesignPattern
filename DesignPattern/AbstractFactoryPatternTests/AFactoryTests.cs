using Xunit;
using AbstractFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Tests
{
    public class AFactoryTests
    {
        [Fact()]
        public void CreateTest()
        {
            Factory factory = new AFactory();
            factory.Create();
            Assert.Equal("ProductA",factory.Product.GetType().Name);
            Assert.Equal("AirConditionA", factory.AirCondition.GetType().Name);
            Assert.Equal("CameraA", factory.Camera.GetType().Name);
        }
    }
}