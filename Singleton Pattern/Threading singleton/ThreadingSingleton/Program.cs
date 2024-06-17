using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread tempThread1 = new Thread(ManageSingleton);
            tempThread1.Name = "First thread"; //not necessary
            tempThread1.Start();

            Thread tempThread2 = new Thread(ManageSingleton);
            tempThread2.Name = "Second thread";
            tempThread2.Start();

            Thread.CurrentThread.Name = "Main thread:";     //existing main thread that the main program is running
            Singleton ss1 = Singleton.GetSingelton();
            ss1.SomeMethod();                   //we somemethod
                                                // all processes share sameshare same single singleton instance
            tempThread1.Join();                 
            tempThread2.Join();                 // main program cannot exit until both these two threads finish their execution

            Console.ReadLine();
        }

        public static void ManageSingleton()
        {
            Singleton ss1 = Singleton.GetSingelton();
            ss1.SomeMethod();
        }
    }
}
