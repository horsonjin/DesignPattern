using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class PersonContext
    {
        ITrave _Travel;

        public PersonContext(ITrave travel)
        {
            _Travel = travel;
        }

        public void SetTravel(ITrave travel)
        {
            if (travel == null) throw new ArgumentNullException(nameof(travel));
            _Travel = travel;
        }

        public string Travel()
        {
            return _Travel.Travel();
        }
    }
}
