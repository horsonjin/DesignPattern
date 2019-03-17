using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class OpenCommand : Command
    {
        public OpenCommand():base()
        {

        }

        public override string Execute()
        {
            return _Receiver.Open();
        }
    }
}
