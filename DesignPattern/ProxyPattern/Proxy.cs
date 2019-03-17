using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Proxy : IRequest
    {
        private IRequest _Request;

        public Proxy()
        {
            _Request = new Subject();
        }

        public string Request()
        {
            return _Request.Request();
        }
    }
}
