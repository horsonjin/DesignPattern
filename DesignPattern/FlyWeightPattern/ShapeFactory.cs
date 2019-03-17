using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
    public static class ShapeFactory
    {
        public static Shape Create(string shapeName)
        {
            if (string.IsNullOrEmpty(shapeName))
            {
                throw new ArgumentNullException(shapeName);
            }

            if (shapeName.Equals("circle",StringComparison.OrdinalIgnoreCase))
            {
                return new Circle();
            }
            else
            {
                throw new ArgumentException(shapeName);
            }
        }
    }
}
