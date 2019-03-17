using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Context
    {
        public static State OpenState;
        public static State CloseState;
        public static State RunningState;
        public static State StoppingState;

        public Context()
        {
            OpenState = new OpenState();
            CloseState = new CloseState();
            RunningState = new RunningState();
            StoppingState = new StoppingState();
        }

        private State _State;

        public void SetState(State state)
        {
            _State = state;
            _State.SetContext(this);
        }

        public string GetState()
        {
            return _State.GetType().Name;
        }

        public string Open()
        {
            return _State.Open();
        }

        public string Close()
        {
            return _State.Close();
        }

        public string Run()
        {
            return _State.Run();
        }

        public string Stop()
        {
            return _State.Stop();
        }
    }
}
