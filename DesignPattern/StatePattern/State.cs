using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public abstract class State
    {
        protected Context _context;
        public void SetContext(Context context)
        {
            _context = context;
        }
        public abstract string Open();

        public abstract string Close();

        public abstract string Run();

        public abstract string Stop();

    }
}
