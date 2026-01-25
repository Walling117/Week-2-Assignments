using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace ChallengeLabs
{
    internal static class Authenticate
    {
        public static void StartAuthenticateMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue; ;
            Console.Clear();
            string password = "123456789";
            string userInput = string.Empty;
            bool sucessfullLogin = false;
            for (int i = 0; i < 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Please enter the password to continue: ");
                userInput = Console.ReadLine();
                if (userInput == password)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Login successful!");
                    sucessfullLogin = true;
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine($"Failed login! You have {3 - (i + 1)} attempts left");
                }
            }
            if (!sucessfullLogin)
            {
                Console.WriteLine("You have been locked out!");
                Console.ReadKey();  
            }
        }
    }
}