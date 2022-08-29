using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Please enter a number.");
            int userInput = Convert.ToInt32(Console.ReadLine());


            calculator.Calculate(userInput, out int result);
            Console.WriteLine(userInput + " divided by 2 equals: " + result);

            Console.WriteLine("Now, please enter another number.");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            Calculator.Calculate(userInput2, out int addResult, out int minusResult);

            Console.WriteLine(userInput2 + " plus " + 10 + " equals: " + addResult);
            Console.WriteLine(userInput2 + " minus " + 10 + " equals: " + minusResult);


            Console.ReadLine();
        }
    }
}
