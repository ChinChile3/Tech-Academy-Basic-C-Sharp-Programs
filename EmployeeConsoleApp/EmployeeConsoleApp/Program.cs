using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic List of things that are data type string
            Employee<string> employees = new Employee<string>();
            employees.Things = new List<string>() { "Bob", "George", "Guy", "Stue" };

            //Generic List of things that are data type int
            Employee<int> employeeIDs = new Employee<int>();
            employeeIDs.Things = new List<int>() { 1, 2, 47, 135 };


            foreach (string thing in employees.Things)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in employeeIDs.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
