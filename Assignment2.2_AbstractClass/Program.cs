namespace Assignment2._2_AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to calculate the area for a square or press 2 to calculate the area for a circle");
            string userChoice = Console.ReadLine();
            if(userChoice == "1")
            {
                double length;
                Console.WriteLine("What is the length of one of your sides?");
                while (!double.TryParse(Console.ReadLine(), out length)) ;
                Square square1 = new Square(length);
                Console.WriteLine(square1.CalculateArea());
            }
            else if(userChoice == "2")
            {
                double radius;
                Console.WriteLine("What is the length of your radius?");
                while (!double.TryParse(Console.ReadLine(), out radius)) ;
                Circle circle1 = new Circle(radius);
                Console.WriteLine(circle1.CalculateArea());
            }
        }
    }
}
