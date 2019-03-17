using Xunit;
using StatePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Tests
{
    public class ContextTests
    {
        [Fact()]
        public void ContextTest()
        {
            Context context = new Context();
            context.SetState(Context.CloseState);
            Assert.True(string.IsNullOrEmpty(context.Close()));
            Assert.Equal("Open",context.Open());
            Assert.True(string.IsNullOrEmpty(context.Open()));
            Assert.Equal("Close", context.Close());
            Assert.Equal("Running", context.Run());
        }
    }
}