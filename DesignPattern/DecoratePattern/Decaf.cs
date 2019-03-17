using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratePattern
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            _Description = "Decaf";
        }
        public override int Cost()
        {
            return 6;
        }
    }
}
