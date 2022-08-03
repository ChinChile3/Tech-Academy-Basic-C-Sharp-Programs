using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Package Express. Please follow the instructions below.");

            Console.WriteLine("What is the weight of your package?");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());
            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("What is the width of your package?");
                int pkgWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the height of your package?");
                int pkgHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the length of your package?");
                int pkgLength = Convert.ToInt32(Console.ReadLine());

                

                if (pkgWidth + pkgHeight + pkgLength > 50)
                {
                    Console.WriteLine("Package is too big to be shipped via Package Express.");
                }
                else
                {
                    int dimensions = pkgWidth * pkgHeight * pkgLength;
                    int dimWeight = dimensions * pkgWeight;
                    decimal quote = dimWeight / 100;

                    Console.WriteLine("Your estimated total shipping is: $" + quote + ".00");
                }

            }
            

            Console.ReadLine();
        }
    }
}
