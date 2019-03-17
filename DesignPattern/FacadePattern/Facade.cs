using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Facade
    {
        private BusinessA _BusinessA;
        private BusinessB _BusinessB;
        private BusinessC _BusinessC;

        public Facade()
        {
            _BusinessA = new BusinessA();
            _BusinessB = new BusinessB();
            _BusinessC = new BusinessC();
        }

        public string VisitAll()
        {
            return _BusinessA.VisitAreaA() + ", " +
                _BusinessB.VisitAreaB() + ", " +
                _BusinessC.VisitAreaC();
        }
    }
}
