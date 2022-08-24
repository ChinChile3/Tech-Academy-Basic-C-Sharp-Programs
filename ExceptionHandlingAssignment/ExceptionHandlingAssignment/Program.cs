using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> myNums = new List<int>() { 12, 4, 7, 28, 9, 13 };
                Console.WriteLine("Here is a list of numbers: " + myNums);
                Console.WriteLine("Please choose a number. That number will used to to divide each number in the list by.");
                int userNum = Convert.ToInt32(Console.ReadLine());

                foreach (int num in myNums) //Loop to divide each int in list by a user input number
                {
                    Console.WriteLine(num + " divided by " + userNum + " equals: " + num / userNum);
                    //Console.ReadLine(); //Here was where it would take user input after every loop for each int in the list
                }
            }
            catch (DivideByZeroException ex) //Will catch if user inputs 0 as their chosen number
            {
                Console.WriteLine("Please do not choose the number 0. It is impossible to divide by 0.");
                return;
            }
            catch (FormatException ex)//Will catch if user inputs strings instead of integers
            {
                Console.WriteLine("Please do not enter in letters or words. Only enter whole numbers.");
                return;
            }
            finally //Will display a message and keep the message on the console once the program has been executed all the way through
            {
                Console.WriteLine("You are now out of the try/catch block of code, and have moved on through the rest of the program");
                Console.ReadLine();
            }


            





        }
    }
}
