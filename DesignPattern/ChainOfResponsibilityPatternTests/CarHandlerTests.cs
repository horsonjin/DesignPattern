using Xunit;
using ChainOfResponsibilityPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Tests
{
    public class CarHandlerTests
    {
        [Fact]
        public void CarHandlerTest()
        {
            CarHandler headHandler = new HeadHandler();
            CarHandler bodyHandler = new BodyHandler();
            CarHandler tailHandler = new TailHandler();

            headHandler.SetNextHandler(bodyHandler).SetNextHandler(tailHandler);
            headHandler.Handler();
            var chainList = ChainData.Instance().GetChainList();
            Assert.True(chainList[0]=="Head"
                &&chainList[1]=="Body"
                &&chainList[2]=="Tail");
        }
    }
}