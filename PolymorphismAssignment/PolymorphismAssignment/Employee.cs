using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public class Employee : Person, IQuittable
    {
        public int ID { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Full Name: " + firstName + " " + lastName);
        }
        public void Quit()
        {
            Console.WriteLine(firstName + " " + lastName + " has quit the company.");
        }
        public static bool operator== (Employee employee1, Employee employee2)
        {
            return employee1.ID == employee2.ID;
        }
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            return employee1.ID != employee2.ID;
        }
    }
}
