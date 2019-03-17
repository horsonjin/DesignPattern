using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern
{
    public abstract class CondimentDecorator_AbstractGetDescriptionMethod : Beverage
    {
        //This is not a good way
        public abstract string GetDescription();
    }
}
