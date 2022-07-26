using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 5 + 10;
            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            Console.WriteLine("Five plus Ten = " + total.ToString());
            Console.ReadLine();
            Console.WriteLine("Fifteen plus Thirty-four = " + combined.ToString());
            Console.ReadLine();

            int diff = 10 - 5;
            Console.WriteLine("Ten minus Five = " + diff.ToString());
            Console.ReadLine();

            int product = 10 * 5;
            Console.WriteLine(product);
            Console.ReadLine();

            int quotient = 100 / 5;
            Console.WriteLine(quotient);
            Console.ReadLine();

            double quotient2 = 100.0 / 17.0;
            Console.WriteLine(quotient2);
            Console.ReadLine();

            int remainder = 10 % 2;
            Console.WriteLine(remainder);
            Console.ReadLine();

            int remainder2 = 11 % 2;
            Console.WriteLine(remainder2);
            Console.ReadLine();

            bool trueOrFalse = 12 > 5;
            Console.WriteLine(trueOrFalse); //put .ToString() into Console.WriteLine
            Console.ReadLine();

            bool trueOrFalse2 = 12 < 5;
            Console.WriteLine(trueOrFalse2.ToString()); 
            Console.ReadLine();

            int roomTemp = 70;
            int currentTemp = 72;
            bool isWarm = currentTemp > roomTemp;
            Console.WriteLine(isWarm.ToString());
            Console.ReadLine();

            int roomTemp2 = 70;
            int currentTemp2 = 70;
            bool isWarm2 = currentTemp2 >= roomTemp2;
            Console.WriteLine(isWarm2.ToString());
            Console.ReadLine();

            int roomTemp3 = 70;
            int currentTemp3 = 68;
            bool isWarm3 = currentTemp3 <= roomTemp3;
            Console.WriteLine(isWarm3.ToString());
            Console.ReadLine();

            int roomTemp4 = 70;
            int currentTemp4 = 70;
            bool isWarm4 = currentTemp4 == roomTemp4;
            Console.WriteLine(isWarm4.ToString());
            Console.ReadLine();

            int roomTemp5 = 70;
            int currentTemp5 = 70;
            bool isWarm5 = currentTemp5 != roomTemp5;
            Console.WriteLine(isWarm5.ToString());
            Console.ReadLine();

        }
    }
}
