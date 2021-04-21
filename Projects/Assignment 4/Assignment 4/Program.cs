using System;


namespace Assignment_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1 \nHourly Rate? \n15 \nHours worked per week \n40");
            Console.WriteLine("Person 2 \nHourly Rate? \n20 \nHours worker per week \n40");
            //salary for person 1
            Console.WriteLine("Annual salary of Person 1:");
            int rate1 = 15;
            int hour1 = 40;
            int week1 = 52;
            int sal1 = (rate1 * hour1 * week1);
            Console.WriteLine(sal1);
            //salary for person 2
            Console.WriteLine("Annual salary of Person 2:");
            int rate2 = 20;
            int hour2 = 40;
            int week2 = 52;
            int sal2 = (rate2 * hour2 * week2);
            Console.WriteLine(sal2);
            //showing whether person 1 makes more than person 2
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(sal1 > sal2);
              

            Console.ReadLine();
        }
    }
}
