using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public abstract class Mediator
    {
        public Colleague ColleagueA { get; private set; }
        public Colleague ColleagueB { get; private set; }
        public Mediator(ColleagueA colleagueA, ColleagueB colleagueB)
        {
            this.ColleagueA = colleagueA;
            this.ColleagueB = colleagueB;
        }

        public abstract string NotifyColleagueA();
        public abstract string NotifyColleagueB();
    }
}
