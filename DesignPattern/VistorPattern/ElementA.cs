using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPattern
{
    public class ElementA : Element
    {
        public override string ProcessElement()
        {
            return _Visitor.ProcessElementA();
        }
    }
}
