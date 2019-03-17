using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public abstract class FakeFile
    {
        protected string _FileType;
        public virtual string Display()
        {
            return _FileType;
        }
    }
}
