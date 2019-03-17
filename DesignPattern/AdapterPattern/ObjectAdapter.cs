using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class ObjectAdapter:IOperator
    {
        private Adaptee _Adaptee;
        public ObjectAdapter()
        {
            _Adaptee = new Adaptee();
        }

        public void Add(string item)
        {
            _Adaptee.AddItem(item);
        }

        public string Get(int index)
        {
            return _Adaptee.GetItem(index);
        }

        public void Remove(string item)
        {
            _Adaptee.RemoveItem(item);
        }
    }
}
