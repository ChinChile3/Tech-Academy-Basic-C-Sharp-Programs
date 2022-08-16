using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "You have chosen 0.", "You have chosen 1.", "You have chosen 2." };

            Console.WriteLine("Please choose a number between 0 and 2");

            int userInput = Convert.ToInt32(Console.ReadLine());
            while (userInput >= stringArray.Length || userInput < 0)
            {
                Console.WriteLine("Please enter a valid number. Your given options are 0, 1 and 2.");
                userInput = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(stringArray[userInput]);
            Console.ReadLine();

            int[] intArray = { 4, 7, 14, 47 };

            Console.WriteLine("Now, please choose a number between 0 and 3");

            int userInputInt = Convert.ToInt32(Console.ReadLine());
            while (userInputInt >= intArray.Length || userInput < 0)
            {
                Console.WriteLine("Please enter a valid number. Your given options are 0, 1, 2 and 3.");
                userInputInt = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(intArray[userInputInt]);
            Console.ReadLine();



            List<string> stringList = new List<string>();
            stringList.Add("You have chosen 0");
            stringList.Add("You have chosen 1");
            stringList.Add("You have chosen 2");

            Console.WriteLine("Now, again, please choose a number between 0 and 2");
            int userInputList = Convert.ToInt32(Console.ReadLine());
            while (userInputList >= stringList.Count || userInputList < 0)
            {
                Console.WriteLine("Please enter a valid number. Your given options are 0, 1 and 2.");
                userInputList = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(stringList[userInputList]);
            Console.ReadLine();




        }
    }
}
