using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Consumer : IObserver<Message>
    {
        private IDisposable _UnSubscrible;

        public Consumer()
        {
            _Records = new List<string>();
        }
        
        public void Subscrible(IObservable<Message> provider)
        {
            if (provider != null)
            {
                _UnSubscrible = provider.Subscribe(this);
            }
        }

        public void UnSubscrible()
        {
            if (_UnSubscrible != null)
            {
                _UnSubscrible.Dispose();
            }
        }
        public void OnCompleted()
        {
            _Records.Add("Completed");
        }

        public void OnError(Exception error)
        {
            
        }

        public void OnNext(Message value)
        {
            _Records.Add(value.Text);
        }

        #region for unit test
        private List<string> _Records;

        public List<string> Records { get => _Records; set => _Records = value; }
        #endregion
    }
}
