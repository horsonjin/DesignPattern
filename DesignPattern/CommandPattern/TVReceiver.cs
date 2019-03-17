using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class TVReceiver : IReceiver
    {
        public string Change()
        {
            return "Change";
        }

        public string Close()
        {
            return "Close";
        }

        public string Open()
        {
            return "Open";
        }
    }
}
