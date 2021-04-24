using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    class Program
    {
        static void Main()
        {
            //**string array
            //Console.WriteLine("Please select an index number");
            //int result = Convert.ToInt32(Console.ReadLine());
            //string[] strArray = { "Ford", "Chevy", "Tesla", "Toyota", "Dodge" };
            //if (result < 4 && result > 0)
            //{
            //    Console.WriteLine(strArray[result]);
            //}
            //else
            //{
            //    Console.WriteLine("This is not a correct index number");
            //}

            //**integer array
            //Console.WriteLine("Please select an index number");
            //int result = Convert.ToInt32(Console.ReadLine());
            //int[] numArray = { 2, 7, 9, 8, 1, 0, 4 };
            //if (result < 6 && result > 0)
            //{
            //    Console.WriteLine(numArray[result]);
            //}
            //else
            //{
            //    Console.WriteLine("This is not a correct index number");
            //}

            //list array
            Console.WriteLine("Select a number that may be in the index");
            int answer = Convert.ToInt32(Console.ReadLine());
            List<int> intnew = new List<int>();
            intnew.Add(2);
            intnew.Add(4);
            intnew.Add(8);
            intnew.Add(5);
            intnew.Add(1);
            if (answer < 4 && answer > 0)
            {
                Console.WriteLine(intnew[answer]);
            }
            else
            {
                Console.WriteLine("That index doesn't exist");
            }


            Console.ReadLine();
        }
    }
}
