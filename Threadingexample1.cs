using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main()
        {
            Thread t = new Thread(new ThreadStart(MyThreadMethod));
            t.Start();
            Console.Read();
        }
        static void MyThreadMethod()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
