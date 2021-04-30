using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number(); //instantiate
            number.Amount = 15.5m; //created object with amount

            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
