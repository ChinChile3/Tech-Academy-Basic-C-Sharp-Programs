using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Calculator.Calculate(4, 17);
            Calculator.Calculate(input1: 23, input2: 33);


            Console.ReadLine();
        }
    }
}
