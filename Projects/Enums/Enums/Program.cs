using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week: "); 
            string dayOfTheWeek = Console.ReadLine(); //User input to question.

            try //using a try and catch just in case they don't enter something correct.
            {
                if (dayOfTheWeek == "Monday" || dayOfTheWeek == "monday")
                {
                    Enums1.DaysOfTheWeek.Monday.ToString();
                    Console.WriteLine("Today is " + dayOfTheWeek);                    
                }
                else if (dayOfTheWeek == "Tuesday" || dayOfTheWeek == "tuesday")
                {
                    Enums1.DaysOfTheWeek.Tuesday.ToString();
                    Console.WriteLine("Today is " + dayOfTheWeek);                    
                }
                else if (dayOfTheWeek == "Wednesday" || dayOfTheWeek == "wednesday")
                {
                    Enums1.DaysOfTheWeek.Wednesday.ToString();
                    Console.WriteLine("Today is " + dayOfTheWeek);                    
                }
                else if (dayOfTheWeek == "Thursday" || dayOfTheWeek == "thursday")
                {
                    Enums1.DaysOfTheWeek.Thursday.ToString();
                    Console.WriteLine("Today is " + dayOfTheWeek);                    
                }
                else if (dayOfTheWeek == "Friday" || dayOfTheWeek == "friday")
                {
                    Enums1.DaysOfTheWeek.Friday.ToString();
                    Console.WriteLine("Today is " + dayOfTheWeek);                    
                }
                else if (dayOfTheWeek == "Saturday" || dayOfTheWeek == "saturday")
                {
                    Enums1.DaysOfTheWeek.Saturday.ToString();
                    Console.WriteLine("Today is " + dayOfTheWeek);                    
                }
                else if (dayOfTheWeek == "Sunday" || dayOfTheWeek == "sunday")
                {
                    Enums1.DaysOfTheWeek.Sunday.ToString();
                    Console.WriteLine("Today is " + dayOfTheWeek);                    
                }
                else
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                
            }
            finally
            {
                Console.ReadLine();
            }           
        }
    }
}
