using System.Text;

namespace Assignment3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Even numbers between 0 and 100");
            Console.WriteLine("".PadLeft(100, '-'));
            Console.WriteLine(ReturnEvenNumbers());
            Console.ReadKey();

            // Leap year
            Console.Write("Check if your year is a leap year: ");
            int x = 0;
            while (!int.TryParse(Console.ReadLine(), out x)) ;
            if (IsLeapYear(x))
                Console.WriteLine($"{x} is a leap year!");
            else
                Console.WriteLine($"{x} is not a leap year");

            Console.ReadKey();
            Console.Clear();

            // Count Spaces
            Console.WriteLine("Please enter your string to count the spaces");
            string s = Console.ReadLine();
            Console.WriteLine($" Your string has {CountSpaces(s)} spaces");
            Console.ReadKey();

            // Find first pairs of one
            Console.Clear();
            Console.WriteLine("Before function: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            int[] i = { 0, 1, 2, 5, 1, 7, 1, 1, 0, 0, 1, 1 };
            foreach (int num in i)
               Console.Write(num + " ");
         
            ClearFirst1sPair(i);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nAfter applying function: ");
            foreach(int num in i)
                Console.Write(num + " ");
            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            

        }

        //Returns string of even numbers
        static StringBuilder ReturnEvenNumbers()
        {
            StringBuilder sb= new StringBuilder();
            for(int i = 2; i <100; i = i + 2)
            {
                sb.Append(i); 
                sb.Append(' ');
            }
            return sb;
        }

        //Leap year
        static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 400 != 0) || (year % 4 == 0 && year % 100 == 0 && year % 400 == 0))
                return true;
            else
                return false;
        }

        //Count spaces in string
        static int CountSpaces(string s)
        {
          return s.Length - s.Replace(" ", "").Length;
        }

        // Finds first pair of 1's
        static void ClearFirst1sPair(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i = i + 1)
            {
                if (array[i] == 1 && array[i + 1] == 1)
                {
                    array[i] = 0;
                    array[i + 1] = 0;
                }
            }
        }
    }
}
