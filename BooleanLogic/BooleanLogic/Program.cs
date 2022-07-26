using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);

            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || false);

            Console.WriteLine(true == true);
            Console.WriteLine(true == false);
            Console.WriteLine(false == false);

            Console.WriteLine(true != true);
            Console.WriteLine(true != false);
            Console.WriteLine(false != false);

            // the '^' symbol compare two things, and result in true if one of the things is true, BUT NOT BOTH
            Console.WriteLine(true ^ true);
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ false);

            //Will result in false
            Console.WriteLine(true && true && true && false);

            //Will result in true
            Console.WriteLine(true && true && true || false);


            Console.ReadLine();




        }
    }
}
