using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class MediatorB:Mediator
    {
        public MediatorB(ColleagueA colleagueA, ColleagueB colleagueB)
            : base(colleagueA, colleagueB)
        {

        }

        public override string NotifyColleagueA()
        {
            return "MediatorB ColleagueA Operation";
        }

        public override string NotifyColleagueB()
        {
            return "MediatorB ColleagueB Operation";
        }
    }
}
