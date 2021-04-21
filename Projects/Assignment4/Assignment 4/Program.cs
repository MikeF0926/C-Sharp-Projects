using System;


namespace Assignment_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            //salary for person 1
            Console.WriteLine("Person1");             
            Console.WriteLine("How much do you make an hour? ");
            int rate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do you work a week? ");
            int hours1 = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Person 1 your annual pay is: ");
            int total1 = (rate1 * hours1) * 52;
            Console.WriteLine(total1);
            Console.ReadLine();
            //salary for person 2
            Console.WriteLine("Person2");
            Console.WriteLine("How much do you make an hour? ");
            int rate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours do you work a week? ");
            int hours2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 1 your annual pay is: ");
            int total2 = (rate2 * hours2) * 52;
            Console.WriteLine(total2);
            Console.ReadLine();
            // boolean totals
            Console.WriteLine("Does Person 1 make more than Person 2?");
            bool onevstwo = (total1 > total2);
            Console.WriteLine(onevstwo);
            Console.ReadLine();








            Console.ReadLine();
        }
    }
}
