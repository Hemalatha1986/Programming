using System;

namespace Encapsulation
{
    // C# program to illustrate encapsulation 
    using System;

    public class studentinfo
    {

        // private variables declared 
        // these can only be accessed by 
        // public methods of class 
        private String studentName;
        private int studentAge;

        // using accessors to get and  
        // set the value of studentName 
        public String Name
        {

            get
            {
                return studentName;
            }

            set
            {
                studentName = value;
            }

        }

        // using accessors to get and  
        // set the value of studentAge 
        public int Age
        {

            get
            {
                return studentAge;
            }

            set
            {
                studentAge = value;
            }

        }


    }

    // Driver Class 
    class GFG
    {

        // Main Method 
        static public void Main()
        {

            // creating object 
            studentinfo si = new studentinfo();

            // calls set accessor of the property Name,  
            // and pass "Ankita" as value of the  
            // standard field 'value' 
            si.Name = "Rasmus";

            // calls set accessor of the property Age,  
            // and pass "21" as value of the  
            // standard field 'value' 
            si.Age = 21;

            // Displaying values of the variables 
            Console.WriteLine("Name: " + si.Name);
            Console.WriteLine("Age: " + si.Age);
        }
    }

}
