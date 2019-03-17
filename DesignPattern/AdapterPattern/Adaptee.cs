using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Adaptee
    {
        private List<string> _DataStore;
        public Adaptee()
        {
            _DataStore = new List<string>();
        }

        public void AddItem(string item)
        {
            _DataStore.Add(item);
        }

        public string GetItem(int index)
        {
            return _DataStore[index];
        }

        public void RemoveItem(string item)
        {
            _DataStore.Remove(item);
        }
    }
}
