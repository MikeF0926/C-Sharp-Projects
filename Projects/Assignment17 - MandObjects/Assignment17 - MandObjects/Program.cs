using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17___MandObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Person = new Employee(); //instantiate from Employee
            Person.FirstName = "Sample";
            Person.LastName = "Student";
            Person.SayName(); //using the superclass from person
            Console.ReadLine();
        }
    }
}
