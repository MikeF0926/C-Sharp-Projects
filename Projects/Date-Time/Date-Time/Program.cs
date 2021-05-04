using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now; //variable for current date and time
            Console.WriteLine("The current date and time is: " + current); //prints current
            Console.WriteLine("Give a number to add to the current time."); //request a variable
            int input = Convert.ToInt32(Console.ReadLine()); //collecting variable from user input
            DateTime result = current.AddHours(input); //take users input plus current time and combine for a result
            Console.WriteLine("The result is: " + result); //display the result
            Console.ReadLine();
        }
    }
}
