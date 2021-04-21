using System;


namespace Assignment_3
{
    class Program
    {
        static void Main()
        {
            //multiplies by 50
            int a;
            int mult;
            Console.WriteLine("Enter a number:");
            a = Convert.ToInt32(Console.ReadLine());
            mult = a * 50;
            Console.WriteLine("Your number times 50: " + mult);

            //adds 25
            int b;
            int add;
            Console.WriteLine("Enter a number:");
            b = Convert.ToInt32(Console.ReadLine());
            add = b + 25;
            Console.WriteLine("Your number plus 20: " + add);

            //divide by 12.5
            int c;
            double div;
            Console.WriteLine("Enter a number:");
            c = Convert.ToInt32(Console.ReadLine());
            div = c / 12.5;
            Console.WriteLine("Your number divided by 12.5: " + div);

            //greater than 50
            int d;
            bool great;
            Console.WriteLine("Enter a number:");
            d = Convert.ToInt32(Console.ReadLine());
            great = d > 50;
            Console.WriteLine("Is your number is greater than 50?: " + great);

            //divides by 7 and gives remainder
            int e;
            int rem;
            Console.WriteLine("Enter a number:");
            e = Convert.ToInt32(Console.ReadLine());
            rem = e % 7;
            Console.WriteLine("This is the remainder of your number divided by 7: " + rem);


            Console.ReadLine();
        }
    }
}
