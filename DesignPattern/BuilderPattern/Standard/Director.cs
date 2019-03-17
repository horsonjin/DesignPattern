using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Standard
{
    public class Director
    {
        /// <summary>
        /// 如果总装过程是不稳定的，该如何处理，我相信我们需要改造这个模式
        /// </summary>
        /// <param name="builder"></param>
        public void Create(IBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            _Frame = builder.CreateFrame();
            _Seat = builder.CreateSeat();
            _Tyre = builder.CreateTyre();
            _Light = builder.CreateLight();
        }

        #region for unit test
        private string _Frame;
        private string _Seat;
        private string _Tyre;
        private string _Light;

        public string Frame { get { return _Frame; } }
        public string Seat { get { return _Seat; } }
        public string Tyre { get { return _Tyre; } }
        public string Light { get { return _Light; } }
        #endregion
    }
}
