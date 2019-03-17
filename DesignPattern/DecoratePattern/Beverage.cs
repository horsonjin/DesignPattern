using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern
{
    public abstract class Beverage
    {
        protected string _Description="Unknown Description";

        public abstract int Cost();

        public virtual string GetDescription()
        {
            return _Description;
        }
    }
}
