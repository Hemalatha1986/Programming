using System;

namespace polymorphism2
{
    
        class student  // Base class (parent) 
        {
            public virtual void Sinfo()
            {
                Console.WriteLine("Display student info");
            }
        }

        class SID : student  // Derived class (child) 
        {
            public override void Sinfo()
            {
                Console.WriteLine("display student ID here");
            }
        }

        class SName : student  // Derived class (child) 
        {
            public override void Sinfo()
            {
                Console.WriteLine("display student Name here");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                student mystudent = new student();  // Create a student object
                student mysid = new SID();  // Create a student id object
                student mysname = new SName();  // Create a student name object

                mystudent.Sinfo();
                mysid.Sinfo();
                mysname.Sinfo();
            }
        }
    }

