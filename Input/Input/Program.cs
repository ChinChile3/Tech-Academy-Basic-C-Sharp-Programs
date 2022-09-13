using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string userNum = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Aaron\source\logs\InputLog.txt", userNum);
            Console.WriteLine(File.ReadAllText(@"C:\Users\Aaron\source\logs\InputLog.txt"));
            Console.ReadLine();
        }
    }
}
