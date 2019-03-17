using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Person
    {
        private string _Name;
        private int _Age;

        public Person(string name, int age)
        {
            this._Name = name;
            this._Age = age;
        }

        public string Name { get => _Name; set => _Name = value; }
        public int Age { get => _Age; set => _Age = value; }

        public Memento CreateMemento()
        {
            Memento memento = new Memento(_Name, _Age);
            return memento;
        }

        public void RestoreMemento(Memento memento)
        {
            if (memento == null) throw new ArgumentNullException(nameof(memento));
            this._Name = memento.Name;
            this._Age = memento.Age;
        }

    }
}
