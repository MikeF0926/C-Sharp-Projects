using System;


namespace Assignment5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?, please answer in \"true\" or \"false.\"");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            bool carIns = (age > 15 && dui != true && tickets < 3);
            Console.WriteLine("Qualified for Insurance? " + carIns);
            


            Console.ReadLine();
        }
    }
}
