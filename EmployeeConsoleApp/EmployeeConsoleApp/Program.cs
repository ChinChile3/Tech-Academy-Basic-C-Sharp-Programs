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
            ////Generic List of things that are data type string
            //Employee<string> employees = new Employee<string>();
            //employees.Things = new List<string>() { "Bob", "George", "Guy", "Stue" };

            ////Generic List of things that are data type int
            //Employee<int> employeeIDs = new Employee<int>();
            //employeeIDs.Things = new List<int>() { 1, 2, 47, 135 };


            //foreach (string thing in employees.Things)
            //{
            //    Console.WriteLine(thing);
            //}
            //foreach (int thing in employeeIDs.Things)
            //{
            //    Console.WriteLine(thing);
            //}

            //List of 10 employees for Foreach and Lambda Expression
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { firstName = "Anthony", lastName = "Velarde", ID = 123 });
            employees.Add(new Employee() { firstName = "Taylor", lastName = "Memmott", ID = 124 });
            employees.Add(new Employee() { firstName = "Jared", lastName = "Ramos", ID = 125 });
            employees.Add(new Employee() { firstName = "Aaron", lastName = "Yang", ID = 126 });
            employees.Add(new Employee() { firstName = "Travis", lastName = "Cann", ID = 127 });
            employees.Add(new Employee() { firstName = "Edward", lastName = "Parra", ID = 128 });
            employees.Add(new Employee() { firstName = "Max", lastName = "Boyden", ID = 129 });
            employees.Add(new Employee() { firstName = "Alex", lastName = "Mendoza", ID = 130 });
            employees.Add(new Employee() { firstName = "Joe", lastName = "Lopez", ID = 131 });
            employees.Add(new Employee() { firstName = "Joe", lastName = "Henry", ID = 132 });

            //Foreach loop of adding employees with the name "Joe" to a separate list
            List<Employee> joeEmployees = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    joeEmployees.Add(employee);
                }
            }
            foreach (Employee joeEmployee in joeEmployees)
            {
                Console.WriteLine(joeEmployee.firstName + " " + joeEmployee.lastName + " " + joeEmployee.ID);
            }

            //Lambda expression to make list with employees that have the name "Joe"
            List<Employee> employeesJoe = employees.Where(x => x.firstName == "Joe").ToList();
            foreach (Employee employee in employeesJoe)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.ID);
            }
            //Lambda expression that checks what employee IDs are higher than the number 5
            List<Employee> highID = employees.Where(x => x.ID > 5).ToList();
            foreach (Employee employeeID in highID)
            {
                Console.WriteLine("The employee ID " + employeeID.ID + " is higher than 5.");
            }





            Console.ReadLine();
        }
    }
}
