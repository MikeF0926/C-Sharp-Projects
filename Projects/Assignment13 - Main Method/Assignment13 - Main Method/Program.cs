using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13___Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5; //gave value to each of these
            decimal num2 = 18.33m;
            string myStr = "20";
            int num3 = Int32.Parse(myStr);

            operation firstTry = new operation(); //performed each operation to link with the operation class
            operation secondTry = new operation();
            operation thirdTry = new operation();
            Console.WriteLine(firstTry.Math1(num1));
            Console.WriteLine(secondTry.Math1(Convert.ToInt32(num2))); //taking the formula from both this class and operations, and linked to make answers.
            Console.WriteLine(thirdTry.Math1(num3));
            Console.ReadLine();
        }
    }
}
