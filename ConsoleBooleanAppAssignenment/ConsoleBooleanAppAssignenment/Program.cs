using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBooleanAppAssignenment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number between 1 and 4.");
            int num = Convert.ToInt32(Console.ReadLine());
            bool chosenNum = num <= 4;

            if (num == 1)
            {
                Console.WriteLine("You have chosen 1. \r\n");
            }
            else if (num == 2)
            {
                Console.WriteLine("You have chosen 2. \r\n");
            }
            else if (num == 3)
            {
                Console.WriteLine("You have chosen 3. \r\n");
            }
            else if (num == 4)
            {
                Console.WriteLine("You have chosen 4. \r\n");
            }

            while (!chosenNum)
            {
                Console.WriteLine("Please input one of the given numbers.");
                Console.WriteLine("Choose a number between 1 and 4.");
                num = Convert.ToInt32(Console.ReadLine());

                chosenNum = num <= 4;
                if (chosenNum == true)
                {
                    Console.WriteLine("Thank you for typing a accepted number this time. \r\n");
                }
            }

            Console.WriteLine("Now out of these four numbers, which one is your favorite?");
            int favNum = Convert.ToInt32(Console.ReadLine());
            bool userFavNum = favNum > 4;

            do
            {
                switch (favNum)
                {
                    case 1:
                        Console.WriteLine("Your favorite number is 1.");
                        userFavNum = true;
                        break;
                    case 2:
                        Console.WriteLine("Your favorite number is 2.");
                        userFavNum = true;
                        break;
                    case 3:
                        Console.WriteLine("Your favorite number is 3.");
                        userFavNum = true;
                        break;
                    case 4:
                        Console.WriteLine("Your favorite number is 4.");
                        userFavNum = true;
                        break;
                    default:
                        Console.WriteLine("Please input one of the given numbers.");
                        Console.WriteLine("Now out of these four numbers, which one is your favorite?");
                        favNum = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!userFavNum);


            Console.ReadLine();




            //switch ()
            //{
            //    case 1:
            //        Console.WriteLine("You have chosen 1.");
            //        num = num + 10;
            //        break;
            //    case 2:
            //        Console.WriteLine("You have chosen 2.");
            //        num = num + 10;
            //        break;
            //    case 3:
            //        Console.WriteLine("You have chosen 3.");
            //        num = num + 10;
            //        break;
            //    case 4:
            //        Console.WriteLine("You have chosen 4.");
            //        num = num + 10;
            //        break;
            //    default:
            //        Console.WriteLine("Please input one of the given numbers.");
            //        break;
            //}
        }
    }
}
