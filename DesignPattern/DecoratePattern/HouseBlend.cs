using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            _Description = "House Blend";
        }
        public override int Cost()
        {
            return 5;
        }
    }
}
