using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ColleagueB : Colleague
    {
        public string NotifyColleagueA()
        {
            return _Mediator.NotifyColleagueA();
        }

        public override string Operation()
        {
            return _Mediator.ColleagueA.Operation();
        }
    }
}
