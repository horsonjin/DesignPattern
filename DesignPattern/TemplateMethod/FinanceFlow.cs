using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class FinanceFlow : Flow
    {
        public FinanceFlow():base()
        {
            
        }

        public override string Process()
        {
            return "Finance";
        }
    }
}
