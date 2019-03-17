using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.MoveDirectorToAbstractBuilder
{
    public class MoBikeBuilder : Builder
    {
        public override string CreateFrame()
        {
            return "MoBike Frame";
        }

        public override string CreateLight()
        {
            return "MoBike Light";
        }

        public override string CreateSeat()
        {
            return "MoBike Seat";
        }

        public override string CreateTyre()
        {
            return "MoBike Tyre";
        }
    }
}
