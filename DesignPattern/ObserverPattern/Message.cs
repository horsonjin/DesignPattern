using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Message
    {
        public Message(string message)
        {
            Text = message;
        }
        public string Text { get; private set; }
    }
}
