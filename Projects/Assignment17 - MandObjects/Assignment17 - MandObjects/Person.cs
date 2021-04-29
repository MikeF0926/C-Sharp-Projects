using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17___MandObjects
{
    public class Person
    {
        public string FirstName { get; set; } //creating two properties
        public string LastName { get; set; }

        public void SayName() //void method with no parameters
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
