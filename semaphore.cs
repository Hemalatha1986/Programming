using System;
using System.Threading;

namespace semaphore
{
    class Program
    {
        static Semaphore _semaphore = new Semaphore(2, 2);//intial count,maximum count..Here control how many threads has to run parallel...
        static void Main(string[] args)
        {
            for(int i=0;i<5;i++)
            {
                new Thread(write).Start();
            }
            Console.ReadKey();
        }
        public static void write()
        {
            Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId} waiting");
            _semaphore.WaitOne();
            Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId} writing");
            Thread.Sleep(2000);
            Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId} writing completed");
            _semaphore.Release();
        }
    }
}
