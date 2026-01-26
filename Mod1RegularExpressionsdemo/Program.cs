using System.Text.RegularExpressions;
namespace Mod1RegularExpressionsdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            // Regular Expressions
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            if (ContainsDigits(name))
            {
                Console.WriteLine("Name must not contain digits!");
                goto start;
            }
            else
            {
            emailStart:
                Console.Write($"{0}, what is your email: ", name);
                string email = Console.ReadLine();
                if (ValidEmail(email))
                {
                    Console.WriteLine($"{name}, you are registered!");
                }
                else
                {
                    goto emailStart;
                }
            }

        }

        // helper functions
        static bool ContainsDigits(string s)
        {
            return Regex.IsMatch(s, "\\d"); // returns true if match is found
        }
        static bool ValidEmail(string s)
        {
            return Regex.IsMatch(s, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
