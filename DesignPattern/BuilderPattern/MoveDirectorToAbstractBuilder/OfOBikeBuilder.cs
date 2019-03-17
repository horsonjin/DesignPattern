using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.MoveDirectorToAbstractBuilder
{
    public class OfOBikeBuilder:Builder
    {
        public override string CreateFrame()
        {
            return "ofo Frame";
        }

        public override string CreateLight()
        {
            return "ofo Light";
        }

        public override string CreateSeat()
        {
            return "ofo Seat";
        }

        public override string CreateTyre()
        {
            return "ofo Tyre";
        }
    }
}
