using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Answer these questions to see if you qualify for car insurance.");
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? Answer \'true\' or \'false\':");
            string DUI = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();

            Console.WriteLine("Qualified?");
            Console.WriteLine(Convert.ToInt32(age) > 15 && Convert.ToBoolean(DUI) == false && Convert.ToInt32(tickets) <= 3);
            Console.ReadLine();




        }
    }
}
