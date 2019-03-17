using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Unsubscriber : IDisposable
    {
        private List<IObserver<Message>> _ObserverList;
        private IObserver<Message> _Observer;

        public Unsubscriber(List<IObserver<Message>> observerList, IObserver<Message> observer)
        {
            _ObserverList = observerList;
            _Observer = observer;
        }
        public void Dispose()
        {
            if (_Observer != null && _ObserverList.Contains(_Observer))
            {
                _ObserverList.Remove(_Observer);
            }
        }
    }
}
