using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPattern
{
    public abstract class Element
    {
        protected IVisitor _Visitor;
        public void Accept(IVisitor visitor)
        {
            if (visitor == null) throw new ArgumentException(nameof(visitor));
            _Visitor = visitor;
        }

        public abstract string ProcessElement();
    }
}
