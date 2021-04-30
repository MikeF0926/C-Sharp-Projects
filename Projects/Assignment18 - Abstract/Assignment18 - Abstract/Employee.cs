using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18___Abstract
{
    public class Employee : Person , IQuittable//inherited from Person class
    {
        public int Id { get; set; } // set property for id

        public override void SayName() //made an override to work with abstract class
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        public void Quit()
        {
            Console.WriteLine(firstName + lastName + "\n" +"This employee has respectfully resigned from their position.");
        }

        public static bool operator ==(Employee person1, Employee person2) // creating my overload == operator
        {
            return (person1.Id == person2.Id); //make a return if equal
        }

        public static bool operator !=(Employee person1, Employee person2)
        {
            return (person1.Id != person2.Id); //make return if not equal
        }

    }
}
