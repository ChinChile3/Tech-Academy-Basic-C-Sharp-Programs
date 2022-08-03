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

            //DISPLAYS TO CONSOLE DEPENDING ON USER INPUT
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

            //IF USER INPUTS A INVALID NUMBER, IT WILL HAVE THE USER INPUT A NUMBER AGAIN
            while (!chosenNum)
            {
                Console.WriteLine("Please input one of the given numbers.");
                Console.WriteLine("Choose a number between 1 and 4.");
                num = Convert.ToInt32(Console.ReadLine());

                //WILL GIVE DIFFERENT RESPONSE AFTER A INCORRECT INPUT
                chosenNum = num <= 4;
                if (chosenNum == true)
                {
                    Console.WriteLine("Thank you for typing a accepted number this time. \r\n");
                }
            }

            //ASKS TO CHOOSE ONE OF THE PREVIOUS VALID OPTIONS AS THE USERS FAVORITE NUMBER
            Console.WriteLine("Now out of these four numbers, which one is your favorite?");
            int favNum = Convert.ToInt32(Console.ReadLine());
            bool userFavNum = favNum > 4;

            //DO WHILE LOOP THAT DISPLAYS DIFFERENT RESPONSES BASED ON USER INPUT
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
                    //RESPONSE IF USER INPUT IS AN INVALID CHOICE
                    default:
                        Console.WriteLine("Please input one of the given numbers.");
                        Console.WriteLine("Now out of these four numbers, which one is your favorite?");
                        favNum = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!userFavNum);


            Console.ReadLine();


        }
    }
}
