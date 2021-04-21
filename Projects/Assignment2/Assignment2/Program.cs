using System;


namespace Assignment2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("What page are you on?");
            string pageNumber = Console.ReadLine(); //had to convert this to int because it's supposed to be a int typed in.
            int pageNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string needHelp = Console.ReadLine();
            bool forHelp = Convert.ToBoolean(needHelp); //because of this only being a true/false I had to convert to boolean since readline only does string.
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string postiveExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string anyFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string howMany = Console.ReadLine(); //had to convert again to an integer from the string.
            int manyHours = Convert.ToInt32(howMany);
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly.Have a great day!");




            Console.ReadLine();
        }
    }
}
