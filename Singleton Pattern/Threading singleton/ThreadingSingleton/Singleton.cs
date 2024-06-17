using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingSingleton
{
    public sealed class Singleton
    {
        private volatile static Singleton _instance;
        private static readonly object _lockThis = new Object();
        private int TimesCalled = 0;
        private Singleton() { }

        public void SomeMethod()
        {
            //Console.WriteLine("Doing something");
            //Not necessary to know, but could be useful
            TimesCalled++;
            Console.WriteLine("{0}: Doing something ({1})", System.Threading.Thread.CurrentThread.Name, TimesCalled);

        }

        public static Singleton GetSingelton()
        {
            if(_instance == null)               // double check locking slows down thread slightly so that it can hit lock and avoid object overriding
            {
               lock (_lockThis)                 // checks if object is set to null, it then creates the object of type singleton then jumps out the lock
                {
                    if(_instance == null)       // second object/thread hits null check
                    _instance = new Singleton();
                }
            }
            return _instance;

        }

    }
}
