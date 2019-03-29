using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class Camera
    {
        protected string _Name;
        public string GetName()
        {
            return _Name;
        }
    }
}
