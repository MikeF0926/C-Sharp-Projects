using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            //** concatenating string
            //string name = "Mike";
            //string hobby = "video games";
            //string title = "call of duty";

            //Console.WriteLine(name + " enjoy's playing " + hobby + ", especially " + title + " online.");
            //Console.ReadLine();

            //convert string to upper case
            //string enjoy = "Strawberries";

            //enjoy = enjoy.ToUpper();
            //Console.WriteLine(enjoy);
            //Console.ReadLine();

            //using string builder
            StringBuilder me = new StringBuilder();
            me.Append(" My name is mike. \n I enjoy playing video games. \n Especially \"Call of Duty\" online.");

            Console.WriteLine(me);
            Console.ReadLine();
        }
    }
}
