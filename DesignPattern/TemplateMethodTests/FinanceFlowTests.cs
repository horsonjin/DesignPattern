using Xunit;
using TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Tests
{
    public class FinanceFlowTests
    {
        [Fact()]
        public void FinanceFlowTest()
        {
            Flow flow = new FinanceFlow();
            flow.Create();
            Assert.True(flow.Records.FirstOrDefault(p => p == "Start") != null
                && flow.Records.FirstOrDefault(p => p == "Finance") != null
                && flow.Records.FirstOrDefault(p => p == "End") != null);

        }
    }
}