using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string begin = "Hello, ";
            string middle = "how are you ";
            string end = "doing today?";

            end = end.ToUpper();
            string together = begin + middle + end;

            Console.WriteLine(together);
            Console.WriteLine("\n");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Oh, I didn't see you there.");
            sb.AppendLine("I know it has been a rough year so for,");
            sb.AppendLine("but I'm glad to see that you have pushed through");
            sb.AppendLine("and persevered, despite the unforturnate occurances.");
            sb.AppendLine("I wish you luck on the rest of the year!");

            Console.WriteLine(sb);
            Console.ReadLine();



        }
    }
}
