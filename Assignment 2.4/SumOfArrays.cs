using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2._4
{
    internal static class SumOfArrays
    {
        public static int NumberOfElements { get; set; } = 0;


        public  static void StartSumOfArraysMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sum of Arrays Menu");
            Console.WriteLine("".PadLeft(50,'-'));
            Console.Write("Enter size of array: ");
            
            int arraySize = 0;
            while (!int.TryParse(Console.ReadLine(), out arraySize));
            NumberOfElements = arraySize;
            
            double[] userArray = new double[NumberOfElements];    
            double sum = 0;

            for (int i = 0; i <= arraySize - 1; i++)
            {
                Console.Write($"Element {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out userArray[i])) ;
                Console.WriteLine();
            }
            foreach (double element in userArray)
            {
                sum += element;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"The sum of every element in your array is: {sum}\n\nPress any key to exit...");
            Console.ReadKey();  
        }
    }
}
