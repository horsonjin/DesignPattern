using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
    public abstract class Shape
    {
        protected string _Color;

        public void SetColor(string color)
        {
            _Color = color;
        }

        public abstract string Draw();
    }
}
