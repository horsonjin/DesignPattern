using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class ClassAdapter : Adaptee, IOperator
    {
        public void Add(string item)
        {
            AddItem(item);
        }

        public string Get(int index)
        {
            return GetItem(index);
        }

        public void Remove(string item)
        {
            RemoveItem(item);
        }
    }
}
