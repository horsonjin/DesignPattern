using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public abstract class Command
    {
        protected IReceiver _Receiver;

        public Command()
        {
            _Receiver = new TVReceiver();
        }

        public void SetReceiver(IReceiver receiver)
        {
            _Receiver = receiver;
        }

        public abstract string Execute(); 
    }
}
