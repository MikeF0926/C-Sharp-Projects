using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15___MethodIII
{
    class MathOp
    {
        public void MyMethod(int numOne, int numTwo)
        {
            int result = numOne + 100;
            Console.WriteLine(numTwo); //no matter what the first number is it will still write the second.
        }
    }
}
