using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class ContractFlow : Flow
    {
        public ContractFlow() : base()
        {

        }

        public override string Process()
        {
            return "Contract";
        }
    }
}
