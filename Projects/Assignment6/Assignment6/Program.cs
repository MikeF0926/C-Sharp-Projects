using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("How much does your package weigh?");
            int weight = Convert.ToInt32(Console.ReadLine());
            //created if/else statment to close if too big or continue
            if (weight > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter package width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter package height:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter package length:");
                int length = Convert.ToInt32(Console.ReadLine());
                //calculation for final price
                decimal price = (width * length * height) * (weight) / 100;
                //writing out come with price variable included.
                Console.WriteLine("Your estimated total for shipping this package is: $" + price + "\nThank You!");
            }
            
            
                       
            

            
            
            Console.ReadLine();
        }
    }
}
