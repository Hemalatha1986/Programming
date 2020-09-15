using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace TaskvsThread
{
    class taskandthread
    {
        int count = 4;
        public void test1()
        {
            var sw = new Stopwatch();
            sw.Start();
            for(int i=0;i<count;i++)
            {
                Task.Factory.StartNew(() => { });//Scheduling a task
            }
            sw.Stop();
            Console.WriteLine("Task ms" +sw.ElapsedMilliseconds);
        }
        
        public void test2()
        {
            var sw = new Stopwatch();
            sw.Start();
            for (int i =0;i<count;i++)
            {
                new Thread(() => { }).Start();//creating new Thread.
            }
            sw.Stop();
            Console.WriteLine("Thread ms" + sw.ElapsedMilliseconds);
        }
        static void Main(string[] args)
        {
            var test = new taskandthread();
            test.test1();
            test.test2();
            Console.ReadLine();
        }
    }
}
