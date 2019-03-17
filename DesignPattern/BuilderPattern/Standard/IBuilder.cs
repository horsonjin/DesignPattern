using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Standard
{
    public interface IBuilder
    {
        string CreateFrame();
        string CreateSeat();
        string CreateTyre();
        string CreateLight();
    }
}
