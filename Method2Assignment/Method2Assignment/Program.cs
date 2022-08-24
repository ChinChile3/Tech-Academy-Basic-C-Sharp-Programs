using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Please enter a number.");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You may enter a number if you wish. It is not necessary. \nJust press enter if you do not wish to enter a number.");

            int input2;
            int result;

            if (int.TryParse(Console.ReadLine(), out input2))
            {
                result = calculator.Calculate(input, input2);
                Console.WriteLine(input + " multiplied by " + input2 + " equals: " + result);
            }
            else
            {
                Console.WriteLine("The default number for the second input, if none was chosen, is 5");
                result = calculator.Calculate(input);
                Console.WriteLine(input + " multiplied by 5 is: " + result);
            }

            
            Console.ReadLine();
        }
    }
}
