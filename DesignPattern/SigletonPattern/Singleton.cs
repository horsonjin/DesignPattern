using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SigletonPattern
{
    public class Singleton
    {
        private static Singleton _Instance;
        private Singleton()
        { }


        //public static Singleton Instance = new Singleton();

        [MethodImpl(MethodImplOptions.Synchronized)]
        private static void CreateInstance()
        {
            if (_Instance == null)
            {
                _Instance = new Singleton();
            }
        }

        public static Singleton GetInstance()
        {
            if (_Instance == null)
            {
                CreateInstance();
            }
            return _Instance;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Singleton GetSingletonBySynchronized()
        {
            if (_Instance == null)
            {
                _Instance = new Singleton();
            }
            return _Instance;
        }

        public int Counter { get; private set; }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void Increment()
        {
            Counter++;
        }
    }
}
