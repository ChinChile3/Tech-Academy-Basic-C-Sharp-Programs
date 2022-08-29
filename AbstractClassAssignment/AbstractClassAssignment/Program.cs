using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { firstName = "Travis", lastName = "Cann" };

            //employee1.firstName = "Travis";
            //employee1.lastName = "Cann";

            employee1.SayName();
            Console.ReadLine();
        }
    }
}
