﻿using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //can be used with other data types
        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);


        Console.WriteLine(intList[0]);
        Console.ReadLine();





        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        ////This does the exact same thing as the code just above this comment
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };


        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        ////target, and change value at specified index, in this case, index 5
        //numArray2[5] = 650;




        //Console.WriteLine(numArray[3]);
        //Console.WriteLine(numArray1[3]);
        //Console.WriteLine(numArray2[3]);
        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();

    }
}

