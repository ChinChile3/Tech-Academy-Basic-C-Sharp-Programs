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

            Console.WriteLine("Please enter a number.");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number.");
            int userInput2 = Convert.ToInt32(Console.ReadLine());



            Calculator.Calculate(userInput1, userInput2);
            Console.WriteLine("I have already chosen the next numbers to appear.");
            Calculator.Calculate(input1: 23, input2: 33);


            Console.ReadLine();
        }
    }
}
