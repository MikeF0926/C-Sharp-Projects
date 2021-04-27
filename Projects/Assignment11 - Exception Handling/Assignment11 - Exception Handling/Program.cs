using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11___Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 12, 18, 9, 10, 6, 5, 18 }; //created a int list
            
            try //telling program to try this first
            {
                Console.WriteLine("Pick a number.");
                int input1 = Convert.ToInt32(Console.ReadLine()); //collects users input

                foreach (int number in nums) 
                {
                    int total = number / input1; //divides the numbers in the list by the user inputs number
                    Console.WriteLine(number + " divided by " + input1 + " equals " + total); //writes it out in a loop through the list.
                }
            }
            catch (FormatException ex) //catches if they use string instead of int
            {
                Console.WriteLine("Number must be written as a whole number"); //message that will display
            }
            catch (DivideByZeroException ex) //catching if they try and divide by zero
            {
                Console.WriteLine("Don't divide by zero"); //message so they will know they can't divide by zero.
            }
            finally //doing a finally so that it will continue through the program even if I put a return in the sequence.
            {
                Console.ReadLine();
            }
            
        }
    }
}
