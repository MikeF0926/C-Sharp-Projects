using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employees = new List<Employees>(); //instantiate //creating a list
            employees.Add(new Employees() { first = "Matt", last = "Johnson", Id = 1 });
            employees.Add(new Employees() { first = "Bebe", last = "Rexa", Id = 2 });
            employees.Add(new Employees() { first = "John", last = "Wayne", Id = 3 });
            employees.Add(new Employees() { first = "Joe", last = "Lewis", Id = 4 });
            employees.Add(new Employees() { first = "Mark", last = "David", Id = 5 });
            employees.Add(new Employees() { first = "Aaron", last = "Rodgers", Id = 6 });
            employees.Add(new Employees() { first = "Paul", last = "Blart", Id = 7 });
            employees.Add(new Employees() { first = "Joe", last = "Rogan", Id = 8 });
            employees.Add(new Employees() { first = "Thad", last = "Lewis", Id = 9 });
            employees.Add(new Employees() { first = "Denzel", last = "Washington", Id = 10 });

            //foreach (Employees x in employees) //creating a foreach loop
            //{
            //    if (x.first == "Joe")
            //    {
            //        Console.WriteLine(x.first + " " + x.last + " " + x.Id); //displaying both names equal to Joe
            //    }
            //}
            //Console.ReadLine();

            //List<Employees> newList = employees.Where(x => x.first == "Joe").ToList(); //creating a lambda name equal to Joe.
            //foreach (Employees x in newList) //looping through
            //{
            //    Console.WriteLine(x.first + " " + x.last + " " + x.Id);
            //}
            //Console.ReadLine();

            List<Employees> newList1 = employees.Where(x => x.Id > 5).ToList(); //creating a lambda Id greater than 5.
            foreach (Employees x in newList1) //looping through
            {
                Console.WriteLine(x.first + " " + x.last + " " + x.Id);
            }
            Console.ReadLine();
        }
    }
}
