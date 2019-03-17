using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.MoveDirectorToAbstractBuilder
{
    /// <summary>
    /// This becomes template method pattern
    /// </summary>
    public abstract class Builder
    {
        public abstract string CreateFrame();
        public abstract string CreateSeat();
        public abstract string CreateTyre();
        public abstract string CreateLight();

        public void CreateBuilder()
        {
            _Frame = this.CreateFrame();
            _Seat = this.CreateSeat();
            _Tyre = this.CreateTyre();
            _Light = this.CreateLight();
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
