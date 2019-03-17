using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryMethodPattern
{
    public static class ProductFactory
    {
        public static Product Create(string productType)
        {
            if (string.IsNullOrEmpty(productType))
            {
                throw new ArgumentNullException(nameof(productType));
            }
            if (productType.Equals("a", StringComparison.OrdinalIgnoreCase))
            {
                return new ProductA();
            }
            else if (productType.Equals("b", StringComparison.OrdinalIgnoreCase))
            {
                return new ProductB();
            }
            else
            {
                throw new ArgumentException(nameof(productType));
            }
        }

        public static Product CreateProductA()
        {
            return new ProductA();
        }

        public static Product CreateProductB()
        {
            return new ProductB();
        }
    }
}
