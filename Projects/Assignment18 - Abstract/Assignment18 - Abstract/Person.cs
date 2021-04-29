using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18___Abstract
{
    public abstract class Person
    {
        public string firstName { get; set; } //creating two public properties
        public string lastName { get; set; }

        public virtual void SayName() //had to make this virtual to work with the override in this abstract class
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
