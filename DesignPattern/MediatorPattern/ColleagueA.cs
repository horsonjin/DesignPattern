using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ColleagueA : Colleague
    {
        public string NotifyColleagueB()
        {
            return _Mediator.NotifyColleagueB();
        }

        public override string Operation()
        {
            return "ColleagueA Operation";
        }
    }
}
