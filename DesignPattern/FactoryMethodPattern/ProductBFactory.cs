using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class ProductBFactory : IFactory
    {
        public Product Create()
        {
            return new ProductB();
        }
    }
}
