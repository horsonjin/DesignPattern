using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class OpenState : State
    {
        public override string Close()
        {
            _context.SetState(Context.CloseState);
            return "Close";
        }

        public override string Open()
        {
            return "";
        }

        public override string Run()
        {
            return "";
        }

        public override string Stop()
        {
            return "";
        }
    }
}
