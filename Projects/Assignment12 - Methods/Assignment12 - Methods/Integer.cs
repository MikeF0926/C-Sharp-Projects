using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12___Methods
{
    class Integer
    {
        public static int Add (int forOne) //setting the class to public so it can be used in programs
        {
            return forOne + 50; //adding 50 when I use this method
        }
        public static int Subtract (int forOne)
        {
            return forOne - 10; //subtracting ten
        }
        public static int Mult (int forOne)
        {
            return forOne * 10; //multiplying ten
        }
    }
}
