using System;
using System.Threading;
 
namespace Mutexx
{
    class Program
    {
        static Mutex _mutex = new Mutex();
        static void Main(string[] args)
        {
        
            for (int i = 0; i < 5; i++)
            {
                new Thread(write).Start();
            }
            Console.ReadKey();
        }
        public static void write()

        {
            Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId} WAITING...");
            _mutex.WaitOne();
            Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId} WRITING...");
            Thread.Sleep(2000);//WRITING for 5 sec
            Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId} WRITING is completed...");
            _mutex.ReleaseMutex();//READY NOW
        }
        
    }
}
