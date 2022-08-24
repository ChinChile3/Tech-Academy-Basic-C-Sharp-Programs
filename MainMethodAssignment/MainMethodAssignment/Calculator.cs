using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Calculator
    {
        public int Calculate(int input)
        {
            return 25 + input;
        }
        //Changed method value to int, leaving in the Convert.ToInt
        public int Calculate(decimal input)
        {
            return 25 - Convert.ToInt32(input);
        }

        public int Calculate(string input)
        {
            return 25 * Convert.ToInt32(input);
        }
    }
}
