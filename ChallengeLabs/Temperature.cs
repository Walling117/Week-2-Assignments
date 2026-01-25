using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeLabs
{
    internal static class Temperature
    {

        public static void StartTemperatureMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Temperature In Fahrenheit");
            Console.WriteLine("".PadLeft(100, '-'));
            Console.Write("Temperature: ");

            double userInput;
            while (!double.TryParse(Console.ReadLine(), out userInput)) ;

            switch (userInput)
            {
                case <= 10:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Freezing weather!");
                    break;
                case > 10 and <= 20:
                    Console.WriteLine("Very Cold weather");
                    break;
                case > 20 and <= 35:
                    Console.WriteLine("Cold weather");
                    break;
                case > 35 and <= 50:
                    Console.WriteLine("Normal weather");
                    break;
                case > 50 and <= 65:
                    Console.WriteLine("Its hot");
                    break;
                case > 65 and <= 80:
                    Console.WriteLine("Its very hot");
                    break;
                default:
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("WAY TOO HOT!");
                        break;
            }
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
