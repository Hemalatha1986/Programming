using System;
using System.Threading.Tasks;

namespace concuurency1
{
    class Program
    {

        static void Main(string[] args)
        {
            Taskmethod1();
            Taskmethod2();
            Task.Delay(20000).Wait();
            Console.WriteLine("Start data input ,enter your name");
            String str = Console.ReadLine();
            Console.WriteLine(str);
            Console.Read();

        }


        private static async void Taskmethod1()
        {
            await Task.Delay(20000).Wait();
            Console.WriteLine("Task 1 ");
        }

        private static async void Taskmethod2()
        {
            await Task.Delay(20000).Wait();
            Console.WriteLine("Task 2 ");
        }


    }
}
