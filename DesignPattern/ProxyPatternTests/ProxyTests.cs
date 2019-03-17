using Xunit;
using ProxyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Tests
{
    public class ProxyTests
    {
        [Fact()]
        public void RequestTest()
        {
            string expected = "Subject Request";
            Proxy proxy = new Proxy();
            var actual = proxy.Request();
            Assert.Equal(expected, actual);
        }
    }
}