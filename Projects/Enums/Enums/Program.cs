using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        public enum DaysOfTheWeek //creating my enum with each day
        {
            Monday, monday,
            tuesday, Tuesday,
            wednesday, Wednesday,
            thursday, Thursday,
            friday, Friday,
            saturday, Saturday,
            sunday, Sunday
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please type the current day of the week.");
            string currentDay = Console.ReadLine();
            try
            {
               DaysOfTheWeek Day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), currentDay);
                Console.Write("You've entered " + currentDay);
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }
        
    }
}
