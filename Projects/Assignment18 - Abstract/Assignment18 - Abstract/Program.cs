using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18___Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee Person = new Employee(); //instantiate from Employee
            //Person.firstName = "Sample";
            //Person.lastName = "Student";
            //Person.SayName(); 
            //Console.ReadLine();

            IQuittable quittable = new Employee() {firstName = "Jack", lastName = " Miller" };       
            quittable.Quit();             
            Console.ReadLine();

        }
    }
}
