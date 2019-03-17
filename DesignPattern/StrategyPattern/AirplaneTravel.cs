using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class AirplaneTravel : ITrave
    {
        public string Travel()
        {
            return "Airplane Travel";
        }
    }
}
