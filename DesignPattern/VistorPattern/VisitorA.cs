using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPattern
{
    public class VisitorA : IVisitor
    {
        public string ProcessElementA()
        {
            return "Visitor A For Element A";
        }

        public string ProcessElementB()
        {
            return "Visitor A For Element B";
        }
    }
}
