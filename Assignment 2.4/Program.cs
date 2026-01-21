namespace Assignment_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n1.Find the sum of all array elements" +
                                  "\n2.Find the largest number from n numbers" +
                                  "\n3.Find which quadrant a point is in");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        SumOfArrays.StartSumOfArraysMenu();
                        break;
                    case "2":
                        LargestNumber.StartLargestNumberMenu();
                        break;
                    case "3":
                        Graph.StartGraphMenu();
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
