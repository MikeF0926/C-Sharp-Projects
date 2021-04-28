using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14___Method_PartII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number"); //Telling the user to select a number
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose another one, but if not just press enter."); //Option for second number or not
            string ans = Console.ReadLine();

            MOps FirstOp = new MOps();

            Console.WriteLine("Your input(s) + 30 = " + FirstOp.Method(num1, ans)); //converted this from the other class MOps.

            Console.ReadLine();

        }
    }
}
