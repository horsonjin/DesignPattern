using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class MediatorA : Mediator
    {
        public MediatorA(ColleagueA colleagueA, ColleagueB colleagueB)
            : base(colleagueA, colleagueB)
        {

        }

        public override string NotifyColleagueA()
        {
            return "MediatorA ColleagueA Notify";
        }

        public override string NotifyColleagueB()
        {
            return "MediatorA ColleagueB Notify";
        }
    }
}
