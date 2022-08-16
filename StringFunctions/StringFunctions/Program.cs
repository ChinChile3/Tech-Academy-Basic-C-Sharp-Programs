using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \"Hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab. \n Here is a backslash \\";

            //string fileName = "C:\\Users\\Anthony";
            ////the @ symbol is used to make all characters between quotes part of the string, there are no escpae characters
            //string fileName2 = @"C:\Users\Anthony";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();
            //name = name.ToLower();



            //Console.WriteLine(name);
            //Console.ReadLine();

            //strings do not actually change value when you "reassign" them. It actually adds a new string to memory instead
            //of changing the orignal string variable, which could lead to memory slow down in bigger apps
            string name = "Jesse";
            name = "Joe";

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Anthony");




            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
