using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Standard
{
    public class OfOBikeBuilder : IBuilder
    {
        public string CreateFrame()
        {
            return "ofo Frame";
        }

        public string CreateLight()
        {
            return "ofo Light";
        }

        public string CreateSeat()
        {
            return "ofo Seat";
        }

        public string CreateTyre()
        {
            return "ofo Tyre";
        }
    }
}
