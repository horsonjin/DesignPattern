using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public abstract class Colleague
    {
        protected Mediator _Mediator;

        public void SetMediator(Mediator mediator)
        {
            _Mediator = mediator;
        }

        public abstract string Operation();
    }
}
