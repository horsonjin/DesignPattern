using Xunit;
using TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Tests
{
    public class ContractFlowTests
    {
        [Fact()]
        public void ContractFlowTest()
        {
            Flow flow = new ContractFlow();
            flow.Create();
            Assert.True(flow.Records.FirstOrDefault(p=>p=="Start")!=null
                && flow.Records.FirstOrDefault(p => p == "Contract") != null
                && flow.Records.FirstOrDefault(p => p == "End") != null);
        }
    }
}