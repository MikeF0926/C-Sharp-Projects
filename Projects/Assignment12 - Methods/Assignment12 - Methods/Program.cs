using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12___Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and it will be performed on three integers"); //Asking user question
            int forOne = Convert.ToInt32(Console.ReadLine()); //receiving their input

            Console.WriteLine(forOne + " plus fifty " + Integer.Add(forOne)); //this is where I'm calling methods used from the other class integrated
            Console.WriteLine(forOne + " minus ten " + Integer.Subtract(forOne));
            Console.WriteLine(forOne + " times ten " + Integer.Mult(forOne));
            Console.ReadLine();
        }
    }
}
