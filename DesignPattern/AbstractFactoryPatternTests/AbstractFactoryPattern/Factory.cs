using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class Factory
    {
        public Product Product { get; protected set; }
        public  AirCondition AirCondition { get; protected set; }
        public  Camera Camera { get; protected set; }

        public abstract void Create();
    }
}
