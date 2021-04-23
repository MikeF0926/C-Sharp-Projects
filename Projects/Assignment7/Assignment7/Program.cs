using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a color from the rainbow?");
            string color = Console.ReadLine();
            bool rColor = color == "red";
            //this one is the while loop
            while (!rColor)
            {

                switch (color)
                {
                    case "blue":
                        Console.WriteLine("You guessed blue. Try again.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "orange":
                        Console.WriteLine("You guessed orange. Try again.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "yellow":
                        Console.WriteLine("You guessed yellow. Try again.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "red":
                        Console.WriteLine("You guessed red. This is correct.");
                        rColor = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                }


            }
                //this one below is the do/while loop
            
            //do
            //{
            //    switch (color)
            //    {
            //        case "blue":
            //            Console.WriteLine("You guessed blue. Try again.");
            //            Console.WriteLine("Guess a color?");
            //            color = Console.ReadLine();
            //            break;
            //        case "orange":
            //            Console.WriteLine("You guessed orange. Try again.");
            //            Console.WriteLine("Guess a color?");
            //            color = Console.ReadLine();
            //            break;
            //        case "yellow":
            //            Console.WriteLine("You guessed yellow. Try again.");
            //            Console.WriteLine("Guess a color?");
            //            color = Console.ReadLine();
            //            break;
            //        case "red":
            //            Console.WriteLine("You guessed red. This is correct.");
            //            rColor = true;
            //            break;
            //        default:
            //            Console.WriteLine("You are wrong.");
            //            Console.WriteLine("Guess a color?");
            //            color = Console.ReadLine();
            //            break;
            //    }
            //}

            //while (!rColor);
            
            Console.ReadLine();
        }
    }
}
