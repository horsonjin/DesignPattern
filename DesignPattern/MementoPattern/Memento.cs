using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Memento
    {
        private string _Name;
        private int _Age;
        public Memento() { }
        public Memento(string name, int age)
        {
            _Name = name;
            _Age = age;
        }

        public string Name { get => _Name; set => _Name = value; }
        public int Age { get => _Age; set => _Age = value; }
    }
}
