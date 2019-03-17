using Xunit;
using BuilderPattern.MoveDirectorToAbstractBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.MoveDirectorToAbstractBuilder.Tests
{
    public class BuilderTests
    {
        [Fact()]
        public void CreateBuilderTest_MoBikeBuilder()
        {
            Builder builder = new MoBikeBuilder();
            builder.CreateBuilder();
            Assert.True(builder.Frame == "MoBike Frame"
                && builder.Light == "MoBike Light"
                && builder.Seat == "MoBike Seat"
                && builder.Tyre == "MoBike Tyre");
        }

        [Fact()]
        public void CreateBuilderTest_OfOBikeBuilder()
        {
            Builder builder = new OfOBikeBuilder();
            builder.CreateBuilder();
            Assert.True(builder.Frame == "ofo Frame"
                && builder.Light == "ofo Light"
                && builder.Seat == "ofo Seat"
                && builder.Tyre == "ofo Tyre");
        }

    }
}