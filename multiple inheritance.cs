using System;



namespace Abstraction

{

    public class User

    {

        public string Name;

        private string Location;

        public User()

        {

            Console.WriteLine("Base Class Constructor");

        }

        public void GetUserInfo(string loc)

        {

            Location = loc;

            Console.WriteLine("Name: {0}", Name);

            Console.WriteLine("Location: {0}", Location);

        }

    }

    public class Details : User

    {

        public int Age;

        public Details()

        {

            Console.WriteLine("Child Class Constructor");

        }

        public void GetAge()

        {

            Console.WriteLine("Age: {0}", Age);

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            Details d = new Details();

            d.Name = "Rasmus";

            // Compile Time Error

            //d.Location = "Hyderabad";

            d.Age = 32;

            d.GetUserInfo("viborg");

            d.GetAge();

            Console.WriteLine("\nPress Any Key to Exit..");

            Console.ReadLine();

        }

    }

}