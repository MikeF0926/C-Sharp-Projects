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
            
            MathOp firstOp = new MathOp(); //based off my other operation this will still take the and display the last number
            firstOp.MyMethod(numOne: 6, numTwo: 8);

            Console.ReadLine();
        }
    }
}
