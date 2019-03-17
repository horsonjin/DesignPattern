using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPattern
{
    public class VisitorB: IVisitor
    {
        public string ProcessElementA()
        {
            return "Visitor B For Element A";
        }

        public string ProcessElementB()
        {
            return "Visitor B For Element B";
        }

    }
}
