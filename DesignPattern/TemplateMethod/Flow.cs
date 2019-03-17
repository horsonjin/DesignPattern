using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Flow
    {
        protected Flow()
        {
            Records = new List<string>();
        }

        public string Start()
        {
            return "Start";
        }

        public abstract string Process();

        public string End()
        {
            return "End";
        }

        public void Create()
        {
            Records.Add(Start());
            Records.Add(Process());
            Records.Add(End());
        }

        public List<string> Records { get; private set; }

    }
}
