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

            //IQuittable quittable = new Employee() {firstName = "Jack", lastName = " Miller" };       
            //quittable.Quit();             
            //Console.ReadLine();

            Employee person1 = new Employee(); //instantiate
            Employee person2 = new Employee();

            person1.Id = 5; //setting id's for both to the same
            person2.Id = 5;

            bool result = person1 == person2; //using the overloaded operator created, for them to match.
            Console.WriteLine(result); 
            Console.ReadLine();
        }
    }
}
