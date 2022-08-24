using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do some math using the number 10. \nPlease enter a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //Instantiation of new calculator object 
            Calculator calObject = new Calculator();

            //Calling the Add, Minus, and Multiply methods to do math operations on user input
            int calAddResult = calObject.Add(userInput);
            Console.WriteLine(userInput + " plus " + 10 + " equals: " + calAddResult);

            int calMinusResult = calObject.Minus(userInput);
            Console.WriteLine(userInput + " minus " + 10 + " equals: " + calMinusResult);

            int calMultiplyResult = calObject.Multiply(userInput);
            Console.WriteLine(userInput + " multiplied by " + 10 + " equals: " + calMultiplyResult);
            


            Console.ReadLine();
        }
    }
}
