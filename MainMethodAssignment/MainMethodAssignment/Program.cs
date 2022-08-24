using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do some math with the number 25. \nPlease enter a number:");
            int userInt = Convert.ToInt32(Console.ReadLine());

            Calculator calculator = new Calculator();
            int addResult = calculator.Calculate(userInt);
            Console.WriteLine(25 + " plus " + userInt + " equals: " + addResult);


            Console.WriteLine("Now, still using 25, please enter a decimal number:");
            decimal userDecimal = Convert.ToDecimal(Console.ReadLine());
            decimal minusResult = calculator.Calculate(userDecimal);
            Console.WriteLine(25 + " minus " + userDecimal + " equals: " + minusResult);


            Console.WriteLine("Now let's try to do some math with a string. Maybe. No need to enter a number this time");
            int multiplyResult = calculator.Calculate("45");
            Console.WriteLine(25 + " multiplied by " + "45" + " equals: " + multiplyResult);
            



            Console.ReadLine();
        }
    }
}
