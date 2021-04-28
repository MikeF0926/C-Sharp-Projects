using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14___Method_PartII
{
    class MOps
    {
        public int Method(int num1, string ans)
        {
            int result = 0;
            if (ans == "") //this gives the option of using a second input or not
            {
                result = num1 + 30;

            }
            else
            {
                int num2 = Convert.ToInt32(ans); //if they do chose a second number.
                result = num1 + num2 + 30;
            }
            return result;

        }

    }
}
