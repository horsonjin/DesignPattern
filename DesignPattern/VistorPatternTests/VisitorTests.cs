using Xunit;
using VistorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistorPattern.Tests
{
    public class VisitorATests
    {
        [Fact()]
        public void VisitorsTest()
        {
            IVisitor visitorA = new VisitorA();
            IVisitor visitorB = new VisitorB();

            Element elementA = new ElementA();
            Element elementB = new ElementB();

            elementA.Accept(visitorA);
            Assert.Equal("Visitor A For Element A", elementA.ProcessElement());

            elementA.Accept(visitorB);
            Assert.Equal("Visitor B For Element A", elementA.ProcessElement());

            elementB.Accept(visitorA);
            Assert.Equal("Visitor A For Element B", elementB.ProcessElement());

            elementB.Accept(visitorB);
            Assert.Equal("Visitor B For Element B", elementB.ProcessElement());

        }
    }
}