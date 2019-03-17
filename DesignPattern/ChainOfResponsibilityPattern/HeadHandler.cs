using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class HeadHandler:CarHandler
    {
        public override void Handler()
        {
            ChainData.Instance().Add("Head");
            DoChain();
        }
    }
}
