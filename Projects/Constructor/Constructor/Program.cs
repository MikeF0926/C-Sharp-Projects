using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Mike"; //set constant variable
            var otherName = "Matt"; //set implied variable
            Console.WriteLine(otherName); //display the variable
            Console.ReadLine();

            var theName = new Names("Mike"); //instantiate object
            Console.WriteLine(theName.onename + " " + theName.twoname); //display name
            Console.ReadLine();
        }
        public class Names
        {
            public Names(string first, string last) //constructor to set the variable
            {
                onename = first;
                twoname = last;
            }

            public Names(string last) : this(last, "Fisher")
            {

            }

            public string onename { get; set; }
            public string twoname { get; set; }
        }
    }
}
