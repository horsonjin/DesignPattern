using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface IOperator
    {
        void Add(string item);
        string Get(int index);
        void Remove(string item);
    }
}
