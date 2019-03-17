using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            _Description = "Dark Roast";
        }
        public override int Cost()
        {
            return 2;
        }
    }
}
