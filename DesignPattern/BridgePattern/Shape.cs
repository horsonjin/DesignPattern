using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class Shape
    {
        protected IColor _Color;
        public void SetColor(IColor color)
        {
            _Color = color;
        }

        public abstract string Draw();
    }
}
