﻿using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 , 4 , 5 , 6 , 7 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception T )
            {
                Console.WriteLine( T.Message);
            }
        }
    }
}