using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Standard
{
    public class MoBikeBuilder : IBuilder
    {
        public string CreateFrame()
        {
            return "MoBike Frame";
        }

        public string CreateLight()
        {
            return "MoBike Light";
        }

        public string CreateSeat()
        {
            return "MoBike Seat";
        }

        public string CreateTyre()
        {
            return "MoBike Tyre";
        }
    }
}
