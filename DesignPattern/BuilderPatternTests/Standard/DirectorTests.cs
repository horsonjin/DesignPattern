using Xunit;
using BuilderPattern.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Standard.Tests
{
    public class DirectorTests
    {
        [Fact()]
        public void CreateTest_OfOBike()
        {
            Director director = new Director();
            OfOBikeBuilder builder = new OfOBikeBuilder();
            director.Create(builder);
            Assert.True(director.Frame== "ofo Frame"
                && director.Light == "ofo Light"
                && director.Seat == "ofo Seat"
                && director.Tyre == "ofo Tyre");
        }

        [Fact()]
        public void CreateTest_MoBike()
        {
            Director director = new Director();
            MoBikeBuilder builder = new MoBikeBuilder();
            director.Create(builder);
            Assert.True(director.Frame == "MoBike Frame"
                && director.Light == "MoBike Light"
                && director.Seat == "MoBike Seat"
                && director.Tyre == "MoBike Tyre");
        }

        [Fact]
        public void CreateTest_Null()
        {
            Director director = new Director();
            Assert.Throws<ArgumentNullException>(()=> { director.Create(null); });
        }
    }
}