using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Calculator
    {
        public void Calculate(int input1, out int result)
        {
            result = input1 / 2;
        }


        public static void Calculate(int input1, out int addResult, out int minusResult)
        {
            addResult = input1 + 10;
            minusResult = input1 - 10;
        }

    }
}
