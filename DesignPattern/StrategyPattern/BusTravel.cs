using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class BusTravel:ITrave
    {
        public string Travel()
        {
            return "Bus Travel";
        }

    }
}
