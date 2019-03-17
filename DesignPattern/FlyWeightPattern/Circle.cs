using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
    public class Circle: Shape
    {
        public override string Draw()
        {
            return _Color + " " + "Circle";
        }
    }
}
