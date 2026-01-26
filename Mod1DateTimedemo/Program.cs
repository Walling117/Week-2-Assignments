namespace Mod1DateTimedemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Today is: { DateTime.Now.ToShortDateString()}");
            Console.WriteLine($"Time is {DateTime.Now.ToShortTimeString()}");


            Console.Write("Enter date of birth yyyy/mm/dd: ");
            var dob = DateTime.Parse(Console.ReadLine());
            // or Convert.ToDateTime(Console.ReadLine());

            var age = CalculateAge(dob);
            Console.WriteLine($"you are : {age} years old");

            var months= ((DateTime.Now.Year)*12 + DateTime.Now.Month) - (dob.Year*12) + dob.Month;
            float preciseAge = months / 12.0f;
            Console.WriteLine($"Precise age : {preciseAge}");
        }

        static int CalculateAge(DateTime dob)
        {
            return DateTime.Now.Year - dob.Year;
        }
    }
}
