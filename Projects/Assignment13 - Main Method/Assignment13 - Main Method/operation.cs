using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13___Main_Method
{
    class operation
    {
        public int Math1(int num1)
        {
            int ans1Result = num1 + 5; //created class to take an integer
            return ans1Result;
        }

        public int Math1(int num1, decimal num2)
        {
            decimal ans2Result = num2 * 5; //created a class to take in a decimal
            return Convert.ToInt32(ans2Result);
        }

        public int Math1(int num1, decimal num2, string num3)
        {
            int num4 = Convert.ToInt32(num3); //created with same name, but this will take a string and convert
            int ans3Result = num4 - 5;
            return ans3Result;
        }
    }
}
