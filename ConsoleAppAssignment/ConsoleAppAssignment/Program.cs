using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //ITERATION THAT ADDS USER TEXT INPUT TO STRINGS IN AN ARRAY
            //Console.WriteLine("Please type something. Anything.");
            //string userInput = Console.ReadLine();
            //string[] stringArray = { "(Knock, Knock). Who is there?", "I'm sorry, could you say that again?", "Ahh, I see now, you are: " };

            //foreach (string sentence in stringArray)
            //{
            //    Console.WriteLine(sentence + " " + userInput);
            //}

            //Console.ReadLine();

            ////TAKES USER INPUT AND PRINTS USERS CHOSEN NUMBER.
            ////WAS AN INFINITE LOOP THAT WOULD PRINT ANY NUMBER ENTERED ENDLESSLY
            ////USED OR OPERATOR TO NARROW DOWN VALID INPUTS FROM USER
            //Console.WriteLine("Now choose a number between 0 and 100");
            //int userNum = Convert.ToInt32(Console.ReadLine());

            //while (userNum >= 100 || userNum < 0)
            //{
            //    Console.WriteLine("Please enter a valid number.");
            //    userNum = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("You have chosen: " + userNum);
            //Console.ReadLine();


            ////USED < OPERATOR TO ITERATE THROUGH LIST OF AGES
            ////USED <= OPERATOR TO ITERATE THROUGH LIST FOR INAPPROPRIATE DRINKING AGES
            //List<int> drinkAgesList = new List<int>();
            //drinkAgesList.Add(18);
            //drinkAgesList.Add(19);
            //drinkAgesList.Add(20);
            //drinkAgesList.Add(21);
            //drinkAgesList.Add(22);
            //drinkAgesList.Add(23);

            //for (int i = 0; i < drinkAgesList.Count; i++)
            //{
            //    Console.WriteLine("Here are our given example ages to see who can drink alcohol legally: " + drinkAgesList[i]);
            //}

            //foreach (int age in drinkAgesList)
            //{
            //    if (age <= 20)
            //    {
            //        Console.WriteLine(age + " is too young of an age to drink alcohol.");
            //    }
            //}

            //Console.ReadLine();


            //ITERATION THAT LOOPS THROUGH LIST TO FIND IF USER INPUT MATCHES A NAME ON THE LIST. 
            //List<string> NamesList = new List<string>() { "Anthony", "Jared", "Aaron", "Taylor", "Travis" };

            //Console.WriteLine("Here are a list of names:");
            //foreach (string name in NamesList)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine("Please enter one of the names to find its position in the list:");
            //string userInputName = Console.ReadLine();
            ////VARIABLE THAT ELIMINATES PRINTING OF INVALID INPUT MULTIPLE TIMES AS THE ITERATION EXECUTES
            //var matchIndex = -1;

            //for (int i = 0; i < NamesList.Count; i++)
            //{
            //    if (NamesList[i] == userInputName)
            //    {
            //        matchIndex = i;
            //        break;
            //    }
            //}
            ////USES GIVEN INDEX FROM THE FOR LOOP TO DETERMINE WHAT TO PRINT TO CONSOLE
            //if (matchIndex >= 0)
            //{
            //    Console.WriteLine("The index position of the name you have chosen is: " + NamesList.IndexOf(userInputName));
            //}
            //else
            //{
            //    Console.WriteLine("You have chosen an invalid name.");
            //}

            //Console.ReadLine();


            //APP THE ITERATES THROUGH LIST AND DISPLAYS INDICES OF CHOSEN CHARACTER THROUGH USER INPUT
            //List<string> Characters = new List<string>() { "Link", "Zelda", "Samus", "Crono", "Link" };
            //Console.WriteLine("Here are a list of video game characters. Please enter one of the names below.");

            //foreach (string character in Characters)
            //{
            //    Console.WriteLine(character);
            //}

            //string userCharacter = Console.ReadLine();
            //bool charMatch = false;

            //for (int i = 0; i < Characters.Count; i++)
            //{
            //    if (Characters[i] == userCharacter)
            //    {
            //        charMatch = true;
            //        Console.WriteLine("The indices of the characters you have chosen are: " + i);
            //    }
            //}
            //if (charMatch == false)
            //{
            //    Console.WriteLine("You have chosen an invalid character name.");
            //}
            //Console.ReadLine();


            //
            List<string> sportsTeams = new List<string>() { "Jazz", "Commanders", "Raiders", "Wizards", "Jazz" };
            List<string> dupSportsTeams = new List<string>();

            Console.WriteLine("Here is a list of sports teams:");
            foreach (string team in sportsTeams)
            {
                Console.WriteLine(team);
            }

            Console.WriteLine("Please press enter to continue");
            Console.ReadLine();

            foreach (string team in sportsTeams)
            {
                Console.WriteLine("The " + team + " is a sports team.");
                foreach (string dupSportsTeam in dupSportsTeams)
                {
                    if (team == dupSportsTeam)
                    {
                        Console.WriteLine("The " + team + " sports team has already appeared on this list.");
                    }
                }

                dupSportsTeams.Add(team);
            }
            Console.ReadLine();




        }
    }
}
