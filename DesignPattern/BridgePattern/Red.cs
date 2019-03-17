using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Red : IColor
    {
        public string BePaint(string shape)
        {
            return "Red " + shape;
        }
    }
}
