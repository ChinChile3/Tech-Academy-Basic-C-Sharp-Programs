using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //COMMENTED CODE USED FOR POLYMORPHISM ASSIGNMENT
            //IQuittable quitEmployee = new Employee() { firstName = "Taylor", lastName = "Memmott" };

            //quitEmployee.Quit();
            //Console.ReadLine();

            Person employee1 = new Employee() { firstName = "Taylor", lastName = "Memmott", ID = 123 };
            Person employee2 = new Employee() { firstName = "Travis", lastName = "Cann", ID = 321 };

            bool matchID = employee1 == employee2;
            
            if (matchID == true)
            {
                Console.WriteLine("These employee IDs are the same. That shouldn't happen");
            }
            else if (matchID != true)
            {
                Console.WriteLine("These employees have different ID numbers.");
            }
            Console.ReadLine();
        }
    }
}
