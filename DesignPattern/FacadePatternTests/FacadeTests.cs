using Xunit;
using FacadePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Tests
{
    public class FacadeTests
    {
        [Fact()]
        public void VisitAllTest()
        {
            Facade facade = new Facade();
            string expected = "AreaA, AreaB, AreaC";
            Assert.Equal(expected, facade.VisitAll());
        }
    }
}