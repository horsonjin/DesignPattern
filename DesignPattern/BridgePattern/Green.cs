using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Green : IColor
    {
        public string BePaint(string shape)
        {
            return "Green " + shape;
        }
    }
}
