using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Producer : IObservable<Message>
    {
        private List<IObserver<Message>> _ObserverList;


        public Producer()
        {
            _ObserverList = new List<IObserver<Message>>();
        }

        public IDisposable Subscribe(IObserver<Message> observer)
        {
            if (!_ObserverList.Contains(observer))
            {
                _ObserverList.Add(observer);
            }
            return new Unsubscriber(_ObserverList, observer);
        }

        public void SendMessage(string text)
        {
            var message = new Message(text);
            foreach (var observer in _ObserverList)
            {
                observer.OnNext(message);
            }
            foreach (var observer in _ObserverList)
            {
                observer.OnCompleted();
            }
        }
    }
}
