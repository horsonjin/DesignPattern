using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Subject : IRequest
    {
        public string Request()
        {
            return "Subject Request";
        }
    }
}
