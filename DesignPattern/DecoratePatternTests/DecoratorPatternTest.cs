using Xunit;
using DecoratePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern.Tests
{
    public class WhipTests
    {
        [Fact()]
        public void Test()
        {
            DarkRoast darkRoast = new DarkRoast();
            Milk milk = new Milk(darkRoast);
            Mocha mocha = new Mocha(milk);
            Soy soy = new Soy(mocha);
            Whip whip = new Whip(soy);
            Assert.Equal("Dark Roast, Milk, Mocha, Soy, Whip",
                whip.GetDescription());
        }
    }
}