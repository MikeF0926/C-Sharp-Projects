using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18___Abstract
{
    interface IQuittable //creating the interface with "I" so others know it is a interface.
    {

        void Quit() //created my void
        {
            Console.WriteLine("This employee has respectfully resigned from their position");
        }
    }
}
