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
            operation mather = new operation();

            Console.WriteLine("Type in a whole number.");
            int userNum = Convert.ToInt32(Console.ReadLine()); //taking user input and taking from class
            int firstAnswer = mather.Math1(userNum);
            Console.WriteLine("Your number plus ten: " + firstAnswer);

            Console.WriteLine("Give us a decimal number.");
            decimal userNum2 = Convert.ToDecimal(Console.ReadLine()); //converting the decimal from second op. Multiply by 10.
            decimal secondTry = mather.Math1(userNum2);
            int secondAnswer = Convert.ToInt32(secondTry);
            Console.WriteLine("Your number times ten: " + secondAnswer);

            Console.WriteLine("Give me one last number.");
            string userNum3 = Console.ReadLine();
            int thirdAnswer = mather.Math1(userNum3);            //convering the third operation
            Console.WriteLine("Your number minus ten: " + thirdAnswer);

            Console.ReadLine();
        }
    }
}
