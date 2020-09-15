using System;
using System.Threading;
//Manual reset event :situation:where one thread needs to work while other thread has to waits.  
namespace threadsyncWriteRead
{
    class Program
    {
        static ManualResetEvent _mre = new ManualResetEvent(false);//SIGNAL IS SET TO FALSE STATE MEANS NOSIGNAL HERE
        static void Main(string[] args)
        {
            new Thread(write).Start();

            for (int i=0;i<5;i++)
            {
                new Thread(read).Start();
            }
            Console.ReadKey();
        }
        public static void write()

        {
            Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId} WRITING...");
            _mre.Reset();//NO SIGNAL
            Thread.Sleep(5000);//WRITING for 5 sec
            Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId} WRITING is completed...");
            _mre.Set();//READY NOW
        }
        public static void read()
        {
            Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId} WAITING...");
            _mre.WaitOne();
            //Thread.Sleep(5000);//READING for 5 sec
            Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId} READING ...");

        }
    }
}
