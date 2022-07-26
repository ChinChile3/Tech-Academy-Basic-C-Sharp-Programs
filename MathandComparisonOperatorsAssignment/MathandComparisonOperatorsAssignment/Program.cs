using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anonymous Income Comparison Program");
            
            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter your Hourly Rate:");
            string p1Rate = Console.ReadLine();
            Console.WriteLine("Please enter the amount of hours you worked this week:");
            string p1Hours = Console.ReadLine();
            int p1Salary = (Convert.ToInt32(p1Rate) * Convert.ToInt32(p1Hours)) * 52;


            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your Hourly Rate:");
            string p2Rate = Console.ReadLine();
            Console.WriteLine("Please enter the amount of hours you worked this week:");
            string p2Hours = Console.ReadLine();
            int p2Salary = (Convert.ToInt32(p2Rate) * Convert.ToInt32(p2Hours)) * 52;


            Console.WriteLine("Annual salary of Person 1: " + p1Salary);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2: " + p2Salary);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(p1Salary > p2Salary);
            Console.ReadLine();
        }
    }
}
