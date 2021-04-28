using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16_OuputParameters
{
    static class mathop2
    {
        static int num1 = 8;
        static int num2 = 4;

        public static void number1()
        {
            int result = num1 / 2; //dividing the different methods by two
            int result2 = num2 / 2;                     
            Console.WriteLine("Static one divided by 2 = " + result);
            Console.WriteLine("Static two divided by 2 = " + result2);
            Console.ReadLine();
        }

    }
}
