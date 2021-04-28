using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16_OuputParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number."); //user will input number
            int num2 = Convert.ToInt32(Console.ReadLine()); //this number will call from a diff class.
            int num1 = 10;
            int test1 = 100;
            int test2 = 7;

            mathop1 FirstOp = new mathop1(); //trying different methods
            FirstOp.myMethod1(num1, num2);
            FirstOp.myMethod2(test1, test2);

            Console.ReadLine();
        }
    }
}
