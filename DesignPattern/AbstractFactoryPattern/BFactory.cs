using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class BFactory : Factory
    {
        public override void Create()
        {
            Product = new ProductB();
            AirCondition = new AirConditionB();
            Camera = new CameraB();
        }
    }
}
