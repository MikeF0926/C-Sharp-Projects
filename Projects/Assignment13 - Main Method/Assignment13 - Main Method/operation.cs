using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13___Main_Method
{
    class operation
    {
        public int Math1(int num)
        {
            int aNum = num + 10;
            return aNum; //created class to take an integer
        }

        public decimal Math1(decimal num)
        {
            decimal aNum = num * 10;
            return aNum; //created a class to take in a decimal
        }

        public int Math1(string num1)
        {
            int conNum = Convert.ToInt32(num1);
            int aNum = conNum - 10;
            return aNum; //created with same name, but this will take a string and convert to integer
        }
    }
}
