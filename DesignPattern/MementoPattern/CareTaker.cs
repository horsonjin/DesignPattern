using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class CareTaker
    {
        private Memento _Memento;

        public CareTaker()
        { }

        public Memento Memento { get => _Memento; set => _Memento = value; }
    }
}
