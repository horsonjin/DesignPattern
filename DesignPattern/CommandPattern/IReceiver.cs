using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public interface IReceiver
    {
        string Open();
        string Close();
        string Change();
    }
}
