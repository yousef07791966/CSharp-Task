using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //////////////////////////////////////////////////////////// task day  2

            // 1  Write a C# program that accept two integers and display the smaller.

            //Console.Write("The smallest number: ");
            //int[] numbers = { 14, 5 };
            //Array.Sort(numbers);
            //Console.WriteLine(numbers[0])                // = 5


            ////  2   Write a C# conditional statement to find the sign  of input  number. Display sign.

            //Console.Write("Enter a number:");
            //int numberSign = Convert.ToInt32(Console.ReadLine());
            //int sign = Math.Sign(numberSign);
            //Console.WriteLine($"The sign of number: {sign}");            // = 0


            ////  3  Write a C# conditional statement to sort three numbers ascending. Use console to display the result.
            ///
            //int[] numbers1 = { 0, -1, 4 };
            //Array.Sort(numbers1);
            //Console.WriteLine($"Sort three numbers ascending: {numbers1[0]} {numbers1[1]} {numbers1[2]} ");    // = { -1 , 0 , 4 }


            ////  4  Write a C# conditional statement to find the max of five numbers. Use console to display the result

            //int[] numbers = { 4, 9, -7, 15, 25 };
            //int maxNum = numbers.Max();
            //Console.WriteLine($"The max number is : {maxNum}");


            ////  5   Write a C# program that converts kilometers per hour to miles per hour

            //Console.Write("kilometers per hour: ");
            //int Kilometer = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"miles per hour: {Kilometer * 0.621371192}");

            ////  6  Write a C# program that takes hours and minutes as input and calculates the total number of minutes.

            //Console.WriteLine("Please enter the hours : ");
            //int int8 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the minutes : ");
            //int int9 = Convert.ToInt32(Console.ReadLine());
            //int8 = int8 * 60;
            //int sum = int8 + int9;
            //Console.WriteLine($"The total minutes equal : {sum} ");


            //// 7  Write a program in C# that takes minutes as input and display the total number of hours and minutes. 

            //Console.WriteLine("Please enter the minutes : ");
            //int int10= Convert.ToInt32(Console.ReadLine());
            //int total = int10 / 60;
            //int minutes = int10 % 60;
            //Console.WriteLine($" {total} hours , {minutes} minutes ");


            //  8  Create string of array that contains 5 element of different sentence with different length .Print all elements with fixed length for each sentence.

            //string[] strings = { "Hello world!", "The life is nice", "How are you?", "Im here waiting for the lunch", "is the lunch ready? " };
            //Console.WriteLine(strings[0] + "\n" +"The length is : " +  strings[0].Length);
            //Console.WriteLine(strings[1] + "\n" + "The length is : " + strings[1].Length);
            //Console.WriteLine(strings[2] + "\n" + "The length is : " + strings[2].Length);
            //Console.WriteLine(strings[3] + "\n" + "The length is : " + strings[3].Length);
            //Console.WriteLine(strings[4] + "\n" + "The length is : " + strings[4].Length);

            ///////////////
            ///

            int i = 0;
            while (i < 5) 
            {
                Console.WriteLine(i);
                i++;
            }

            /////////

            int k = 2;
            do
            {
                Console.WriteLine(k);
                k++;
            }
            while (k < 8);
        }
        
    
    }
    }

