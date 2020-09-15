using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace Threadsyncdemo
//Thread synchronization using Lock
{
    class Program
    {
        private static object _locker = new object();

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(Dowork).Start();
            }
            Console.ReadKey();
        }

        public static void Dowork()
        {
            lock(_locker)
            {
            //In real time application,In this section,you would do file downloading or some networking application
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} starts now..");
            Thread.Sleep(2000);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} finishes now..");
            }
        }


    }
}
