using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2._2_Overloading
{
    internal class Maths
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2, decimal num3) {
            return num1 + num2 + num3;
                }

        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }
        public static float Multiply(float num1, float num2, float num3)
        {
            return num1 * num2 * num3;
        }

        public static void StartMathMenu()
        {
            string userChoice = string.Empty;
            Console.WriteLine("Would you like to add or multiply?\nPress 1 for add\nPress 2 for multiply");
            userChoice = Console.ReadLine();

            if(userChoice == "1")
            {
                decimal num1, num2, num3;
                Console.WriteLine("Please enter two or three numbers to be added: ");
                while(!decimal.TryParse(Console.ReadLine(), out num1));
                while (!decimal.TryParse(Console.ReadLine(), out num2)) ;

                Console.WriteLine($"\nYour two numbers are {num1} and {num2}\nWould you like to add a third? If so, press 'y'");
                if(Console.ReadLine() == "y")
                {
                    while (!decimal.TryParse(Console.ReadLine(), out num3)) ;
                    Console.WriteLine($"{num1} + {num2} + {num3} = {Add(num1, num2, num3)}");
                }
                else
                {
                    Console.WriteLine($"{num1} + {num2} = {Add((int)num1, (int)num2)}");
                }


            }
            else if(userChoice == "2")
            {
                float num1, num2, num3;
                Console.WriteLine("Please enter two or three numbers to be multiplied: ");
                while (!float.TryParse(Console.ReadLine(), out num1)) ;
                while (!float.TryParse(Console.ReadLine(), out num2)) ;

                Console.WriteLine($"\nYour two numbers are {num1} and {num2}\nWould you like to add a third? If so, press 'y'");
                if (Console.ReadLine() == "y")
                {
                    while (!float.TryParse(Console.ReadLine(), out num3)) ;
                    Console.WriteLine($"{num1} * {num2} * {num3} = {Multiply(num1, num2, num3)}");
                }
                else
                {
                    Console.WriteLine($"{num1} * {num2} = {Multiply((int)num1, (int)num2)}");
                }

            }
        }

    }
}
