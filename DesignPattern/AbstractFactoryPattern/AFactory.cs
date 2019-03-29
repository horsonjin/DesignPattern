using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class AFactory : Factory
    {
        public override void Create()
        {
            Product = new ProductA();
            AirCondition = new AirConditionA();
            Camera = new CameraA();
        }
    }
}
