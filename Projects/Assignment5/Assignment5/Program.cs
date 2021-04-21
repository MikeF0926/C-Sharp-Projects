using System;


namespace Assignment5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine()); //user enters age
            Console.WriteLine("Have you ever had a DUI?, please answer in \"true\" or \"false.\"");
            bool dui = Convert.ToBoolean(Console.ReadLine()); //user enters if they had a dwi, using true or false.
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine()); //user enters number of tickets
            bool carIns = (age > 15 && dui != true && tickets < 3); //created this to give back a boolean based on criteria.
            Console.WriteLine("Qualified for Insurance? " + carIns);
            


            Console.ReadLine();
        }
    }
}
