using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15___MethodIII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number");
            int numOne = Convert.ToInt32(Console.ReadLine());//giving numbers
            Console.WriteLine("Pick another number.");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            MathOp firstOp = new MathOp(); //based off my other operation this will still take the and display the last number
            firstOp.MyMethod(numOne, numTwo);

            Console.ReadLine();
        }
    }
}
