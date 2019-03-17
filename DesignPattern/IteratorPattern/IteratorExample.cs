using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class IteratorExample : IEnumerator<string>
    {
        private List<string> _Data;
        private int _Position;

        public IteratorExample()
        {
            _Data = new List<string>();
            _Position = 0;
        }

        public string Current => _Data[_Position];

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {
            _Data = null;            
        }

        public bool MoveNext()
        {
            if (_Position == _Data.Count - 1) return false;
            _Position++;
            return true;
        }

        public void Reset()
        {
            _Position = 0;
        }
    }
}
