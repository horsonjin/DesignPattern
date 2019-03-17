using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public abstract class CarHandler
    {
        CarHandler _NextHandler;

        public abstract void Handler();

        public CarHandler SetNextHandler(CarHandler carHandler)
        {
            _NextHandler = carHandler;
            return _NextHandler;
        }

        public void DoChain()
        {
            if (_NextHandler != null) _NextHandler.Handler();
        }
    }
}
