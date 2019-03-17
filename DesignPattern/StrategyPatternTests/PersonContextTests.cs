using Xunit;
using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Tests
{
    public class PersonContextTests
    {
        [Fact()]
        public void TravelTest()
        {
            ITrave travel = new BicycleTravel();
            PersonContext context = new PersonContext(travel);
            Assert.Equal("Bicycle Travel", context.Travel());

            travel = new BusTravel();
            context.SetTravel(travel);
            Assert.Equal("Bus Travel", context.Travel());
        }
    }
}