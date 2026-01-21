using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2._4
{
    internal static class LargestNumber
    {
        public static void StartLargestNumberMenu()
        {
            Console.Clear();
            Console.WriteLine("\tFind Largest Number Menu");
            Console.WriteLine("".PadLeft(60, '-'));
            Console.Write("How many numbers do you have: ");
            int arraySize = 0;
            while (!int.TryParse(Console.ReadLine(), out arraySize)) ;
            double[] userArray = new double[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Element {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out userArray[i])) ;
                Console.WriteLine();
            }

            // find largest number
            double largestNumber = userArray[0];
            foreach (var num in userArray)
            {
                if (num > largestNumber)
                {
                    largestNumber = num;
                }
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"The largest number is: {largestNumber}\nPress any key to quit... ");
            Console.ReadKey();
        }
    }
}
