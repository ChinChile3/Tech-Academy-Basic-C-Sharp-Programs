using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 12;
            //int num2 = 43;
            //int addNums = num1 + num2;
            //string addResult = addNums.ToString();
            //Console.WriteLine(addNums);
            //Console.ReadLine();

            //int num3 = 45;
            //int num4 = 69;
            //int minusNums = num3 - num4;
            //string minusResult = minusNums.ToString();
            //Console.WriteLine(minusResult);
            //Console.ReadLine();

            //int num5 = 14;
            //int num6 = 9;
            //int multiNums = num5 * num6;
            //string multiResult = multiNums.ToString();
            //Console.WriteLine(multiResult);
            //Console.ReadLine();

            //int num7 = 10;
            //int num8 = 10;
            //int divNums = num7 / num8;
            //string divResult = divNums.ToString();
            //Console.WriteLine(divResult);
            //Console.ReadLine();



            //double dNum = 6.23412343;
            //int intNum = 7;
            //double sumNum = dNum + intNum;
            //string sumNumString = sumNum.ToString();
            //Console.WriteLine(sumNumString);
            //Console.ReadLine();

            //string myString = "Life is like ";
            //string myString2 = "a box of chocolates.";
            //Console.WriteLine(myString + myString2);
            //Console.ReadLine();

            //CONSOLE APP THAT MULTIPLIES USER INPUT BY 50
            //Console.Write("Please enter a number. We will multiply it by 50. \n");
            //string userInput =Console.ReadLine();
            //long multi50 = Convert.ToInt64(userInput) * 50;
            //Console.WriteLine("50 multiplied by " + userInput + " = " + multi50);
            //Console.ReadLine();

            //CONSOLE APP THAT ADDS USER INPUT BY 25
            //Console.Write("Please enter a number. We will add 25 to it. \n");
            //string userInput25 = Console.ReadLine();
            //int add25 = Convert.ToInt32(userInput25) + 25;
            //Console.WriteLine("25 added to  " + userInput25 + " = " + add25);
            //Console.ReadLine();

            //CONSOLE APP THAT DIVIDES USER INPUT BY 12.5
            //Console.Write("Please enter a number. We will divide it by 12.5. \n");
            //string userInput12 =Console.ReadLine();
            //decimal div12 = Convert.ToDecimal(userInput12) / 12.5m;
            //Console.WriteLine(userInput12 + " divided by 12.5 = " + div12);
            //Console.ReadLine();

            //CONSOLE APP THAT COMPARES USER INPUT TO SEE IF IT IS GREATER THAN 50
            //Console.Write("Please enter a number. We will compare to see if it is greater than 50. \n");
            //string userInput50 = Console.ReadLine();
            //bool greater50 = Convert.ToInt32(userInput50) > 50;
            //Console.WriteLine(userInput50 + " is greater than 50. True or False: " + greater50);
            //Console.ReadLine();

            //CONSOLE APP THAT DISPLAYS REMAINDER 
            Console.Write("Please enter a number. We will divide it by 7, then show the remainder. \n");
            string userInput7 = Console.ReadLine();
            int remainder = Convert.ToInt32(userInput7) % 7;
            Console.WriteLine(userInput7 + " divided by 7 will have a remainder of " + remainder);
            Console.ReadLine();

        }
    }
}
