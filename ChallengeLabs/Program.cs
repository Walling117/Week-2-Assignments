namespace ChallengeLabs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.WriteLine("1.Temperature\n2.Authenticate\n3.Triangle\n4.Grades");
                string userInput = string.Empty;
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Temperature.StartTemperatureMenu();
                        break;
                    case "2":
                        Authenticate.StartAuthenticateMenu();
                        break;
                    case "3":
                        Triangle.StartTriangleMenu();
                        break;
                    case "4":
                        Grades.StartGradesMenu();
                        break;
                    default:
                        return;
                }                           
            }
        }
    }
}
