using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class RunningState : State
    {
        public override string Close()
        {
            return "";
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
            _context.SetState(Context.StoppingState);
            return "Stopping";
        }
    }
}
