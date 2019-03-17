using Xunit;
using FlyWeightPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern.Tests
{
    public class FlyWeightFactoryTests
    {
        [Fact()]
        public void GetShapeTest()
        {
            var shape1 = FlyWeightFactory.GetShape("Circle", "Red");
            Assert.Equal("Red Circle", shape1.Draw());

            var shape2 = FlyWeightFactory.GetShape("Circle", "Red");
            Assert.Equal("Red Circle", shape1.Draw());

            var shape3 = FlyWeightFactory.GetShape("Circle", "Green");
            Assert.Equal("Red Circle", shape1.Draw());

            var shape4 = FlyWeightFactory.GetShape("Circle", "Green");
            Assert.Equal("Red Circle", shape1.Draw());

        }
    }
}