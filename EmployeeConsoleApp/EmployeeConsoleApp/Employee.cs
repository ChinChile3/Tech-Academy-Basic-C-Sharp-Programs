using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleApp
{
    //Class with generic parameters
    public class Employee<T> : Person, IQuittable
    {
        public int ID { get; set; }
        //Things property with generic list
        public List<T> Things { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Full Name: " + firstName + " " + lastName);
        }
        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + " has quit the company.");
        }


        //OVERLOADED OPERATORS
        public static bool operator ==(Employee<T> employee1, Employee<T> employee2)
        {
            return employee1.ID == employee2.ID;
        }
        public static bool operator !=(Employee<T> employee1, Employee<T> employee2)
        {
            return employee1.ID != employee2.ID;
        }



        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}