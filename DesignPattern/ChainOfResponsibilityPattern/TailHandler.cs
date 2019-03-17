using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class TailHandler:CarHandler
    {
        public override void Handler()
        {
            ChainData.Instance().Add("Tail");
            DoChain();
        }
    }
}
