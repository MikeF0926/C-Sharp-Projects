using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    class Program
    {
        static void Main(string[] args)
        {
            //**Adding the user input to the string
            //string[] strArray = { "Mike ", "Sam ", "Joseph ", "Matt ", "Jordan " };
            //Console.WriteLine("Input some text: ");
            //string userInput = Console.ReadLine();
            //for (int i = 0; i < strArray.Length; i++ )
            //{
            //    strArray[i] += userInput;
            //}
            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    Console.WriteLine(strArray[i]);
            //}

            //Console.ReadLine();

            //**************************
            //for (int i = 0; i < countries.Length; i--)//this will add the infinite loop

            //**Adding the <= in the loop
            //string[] strArray = { "Mike ", "Sam ", "Joseph ", "Matt ", "Jordan " };
            //Console.WriteLine("Input some text: ");
            //string userInput = Console.ReadLine();
            //for (int i = 0; i <= 4; i++)
            //{
            //    strArray[i] += userInput;
            //}
            //for (int i = 0; i <= 4; i++)
            //{
            //    Console.WriteLine(strArray[i]);
            //}

            //Console.ReadLine();

            //** list of strings
            //List<string> names = new List<string>() { "Mike", "Sam", "Joseph", "Matt", "Jordan" };
            //Console.WriteLine("Enter a first name to search index");
            //string oneInput = Console.ReadLine();
            //for (int i = 0; i < names.Count; i++)
            //{
            //    if (oneInput == names[i])
            //    {
            //        Console.WriteLine(oneInput + " was found at index " + i);
            //    }
            //    else if (oneInput != names[i])
            //    {
            //        Console.WriteLine(oneInput + " was not found.");
            //    }
            //    Console.ReadLine();
            //}

            //** list of strings duplicate
            //List<string> names = new List<string>() { "Mike", "Sam", "Joseph", "Matt", "Jordan", "Mike" };
            //Console.WriteLine("Enter a first name to search index");
            //string oneInput = Console.ReadLine();
            //for (int i = 0; i < names.Count; i++)
            //{

            //    if (oneInput == names[i])
            //    {
            //        Console.WriteLine(oneInput + " was found at index " + i);

            //    }
            //    else if (oneInput != names[i])
            //    {
            //        Console.WriteLine(oneInput + " was not found.");
            //    }
            //    Console.ReadLine();
            //}

            //**foreach loop
            List<string> names = new List<string>() { "Mike", "Sam", "Joseph", "Matt", "Jordan", "Mike", };
            Console.WriteLine("Enter a first name to search index");
            string oneInput = Console.ReadLine();
            List<string> newname = new List<string>();
            
            foreach (string name in names)
            {
                if (newname.Contains(name))
                {
                    Console.WriteLine(name + " this name already exists");
                }
                else if (!newname.Contains(name))
                {
                    newname.Add(name);
                    Console.WriteLine(name);
                }
                Console.WriteLine(newname.Count);
            } Console.ReadLine();
        }
    }
}
