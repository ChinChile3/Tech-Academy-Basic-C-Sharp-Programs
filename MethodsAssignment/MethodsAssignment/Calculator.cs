using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    public class Calculator
    {
        //Methods that do math operations
        public int Add(int input)
        {
            return input + 10;
        }

        public int Minus(int input)
        {
            return input - 10;
        }

        public int Multiply(int input)
        {
            return input * 10;
        }

        public int Number { get; set; }
    }
}
