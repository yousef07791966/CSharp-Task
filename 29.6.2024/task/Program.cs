
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //  1 - Correct the syntax error:

            int[] ARR = { 1, 7, 9, 45 };

            string[] arr2 = { "Str", "alex", "moh" };

            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };



            //   2 - What the index of "Banana","Tomato" ?

            string[] fruits = { "Tomato", "Banana", "Watermelon" };


            int indexBanana = Array.IndexOf(fruits, "Banana");
            int indexTomato = Array.IndexOf(fruits, "Tomato");

            Console.WriteLine("Index of Banana: " + indexBanana);
            Console.WriteLine("Index of Tomato: " + indexTomato);



            //   3 - Create an multiple arrays that represents your:
            //	Favorite Food(5 item)
            //	Favorite Sport(3 item)
            //	Favorite Movie(4 item)
            //Then, print each array using foreach, and Loop Through an Array


            string[] foods = { "Pizza", "Sushi", "Pasta", "Ice Cream", "Steak" };
            string[] sports = { "Soccer", "Basketball", "Tennis" };
            string[] movies = { "red 2", "The Matrix", "iron fist", "black list" };

            Console.WriteLine($"My favorite foods are :");
            foreach (string food in foods)
            {
                Console.WriteLine(food);
            }
            Console.WriteLine("-------------------------"); // just a break


            Console.WriteLine($"My favorite sports are :");
            foreach (string sport in sports)
            {
                Console.WriteLine(sport);
            }

            Console.WriteLine("-------------------------");  // just a break


            Console.WriteLine($"My favorite movies are :");
            foreach (string movie in movies)
            {
                Console.WriteLine(movie);
            }


            // 4-	Write a program in C# to calculate the sum of three numbers with getting input in one line separated by a comma
            // Expected Output:
            //	Input three numbers separated by comma: 5,10,15
            //The sum of three numbers: 30.


            //Console.WriteLine("Please enter three numbers : ");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());
            //int secondNumber = Convert.ToInt32(Console.ReadLine());
            //int thirdNumber = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int[] numbers = { firstNumber, secondNumber, thirdNumber };

            //foreach (int number in numbers)
            //{
            //    sum += number;
            //}
            //Console.WriteLine($"The numbers you enterd are : {firstNumber} , {secondNumber} , {thirdNumber}");
            //Console.WriteLine($"The sum of the three numbers is {sum}");



            //5 - Write a program in C# to display the n terms of odd number and their sum from [1- 100 ]

            int summ2 = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                    summ2 += i;
                }
            }
            Console.WriteLine("\n summ2");


            // 6 -	Write a program in C## to display the pattern like right angle triangle
            // using an asterisk. Go to the editor


            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // 6 - Write a program in C# to make such a pattern like right angle triangle
            // with number increased by 1. Go to the editor

            int currentNumber = 1;

            for (int i = 1; i <= 4; i++)
            {
                // for spaces
                for (int j = 4; j > i; j--)
                {
                    Console.Write(" ");
                }

                // for numbers
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(currentNumber + " ");
                    currentNumber++;
                }

                // Move to the next line
                Console.WriteLine();
            }

            }
    }
}
