using Xunit;
using AbstractFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Tests
{
    public class BFactoryTests
    {
        [Fact()]
        public void CreateTest()
        {
            Factory factory = new BFactory();
            factory.Create();
            Assert.Equal("ProductB", factory.Product.GetType().Name);
            Assert.Equal("AirConditionB", factory.AirCondition.GetType().Name);
            Assert.Equal("CameraB", factory.Camera.GetType().Name);

        }
    }
}