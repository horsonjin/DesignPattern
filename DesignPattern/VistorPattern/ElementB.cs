using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPattern
{
    public class ElementB : Element
    {
        public override string ProcessElement()
        {
            return _Visitor.ProcessElementB();
        }
    }
}
