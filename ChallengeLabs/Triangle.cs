using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeLabs
{
    internal class Triangle
    {
        public static void StartTriangleMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Please enter an integer: ");
            int userTarget = 0;

            while (!int.TryParse(Console.ReadLine(), out userTarget)) ;

            for (int j = userTarget; j > 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    Console.Write(userTarget);
                }
                Console.WriteLine();
            }
            Console.ReadKey(); 
        }
    }
}
