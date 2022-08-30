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

            //CHANGED employee1 and employee2 TO Employee OBJECTS. OPERATORS CAN NOW COMPARE EITHER TRUE OR FALSE.
            //BEFORE THIS CHANGE, IT AS JUST PASSING THE COMPARISON AS FALSE
            Employee employee1 = new Employee() { firstName = "Taylor", lastName = "Memmott", ID = 123 };
            Employee employee2 = new Employee() { firstName = "Travis", lastName = "Cann", ID = 123 };

            bool matchID = employee1.ID == employee2.ID;
            
            if (matchID == true)
            {
                Console.WriteLine("These employee IDs are the same. That shouldn't happen.");
            }
            else if (matchID != true)
            {
                Console.WriteLine("These employees have different ID numbers.");
            }
            Console.ReadLine();
        }
    }
}
