using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current date and time is: " + DateTime.Now);
            Console.WriteLine("Now, please enter a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("It will be " + DateTime.Now.AddHours(userNum) + " in {0} hours.", userNum);


            Console.ReadLine();
        }
    }
}
