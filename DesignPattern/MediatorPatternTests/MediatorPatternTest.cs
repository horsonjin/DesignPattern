using Xunit;
using MediatorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Tests
{
    public class MediatorPatternTest
    {
        [Fact()]
        public void MediatorPattern_Test()
        {
            ColleagueA colleagueA = new ColleagueA();
            ColleagueB colleagueB = new ColleagueB();
            Mediator mediatorA = new MediatorA(colleagueA, colleagueB);
            colleagueA.SetMediator(mediatorA);
            colleagueB.SetMediator(mediatorA);

            var resultA = colleagueA.NotifyColleagueB();
            var resultB = colleagueB.NotifyColleagueA();
            Assert.Equal("MediatorA ColleagueB Notify", resultA);
            Assert.Equal("MediatorA ColleagueA Notify", resultB);
        }
    }
}