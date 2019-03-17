using Xunit;
using BridgePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Tests
{
    public class CircleTests
    {
        [Fact()]
        public void DrawTest()
        {
            Green green = new Green();
            Circle circle = new Circle();
            circle.SetColor(green);
            Assert.Equal("Green Circle", circle.Draw());

            White white = new White();
            circle.SetColor(white);
            Assert.Equal("White Circle", circle.Draw());
        }
    }
}