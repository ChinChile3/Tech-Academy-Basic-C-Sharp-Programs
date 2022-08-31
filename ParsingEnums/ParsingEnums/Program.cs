using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the day of the week.");

            try
            {
                string day = Console.ReadLine();
                DayOfWeek userDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day);

                Console.WriteLine(userDay + " is the day you have chosen.");
            }

            catch 
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }
    }
}
