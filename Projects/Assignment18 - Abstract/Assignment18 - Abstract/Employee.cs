using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18___Abstract
{
    public class Employee : Person , IQuittable//inherited from Person class
    {
        public override void SayName() //made an override to work with abstract class
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        public void Quit(Person firstName, Person lastName)
        {
            throw new NotImplementedException();
        }
    }
}
