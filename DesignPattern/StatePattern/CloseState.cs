using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class CloseState : State
    {
        public override string Close()
        {
            return "";
        }

        public override string Open()
        {
            _context.SetState(Context.OpenState);
            return "Open";
        }

        public override string Run()
        {
            _context.SetState(Context.RunningState);
            return "Running";
        }

        public override string Stop()
        {
            return "";
        }
    }
}
