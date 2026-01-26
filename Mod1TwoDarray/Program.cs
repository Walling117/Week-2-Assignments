namespace Mod1TwoDarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[][] used for jagged array
            int[,] movieRatings = new int[4, 5];//one comma in the square bracket
                                                // first number is rows and second is for columns!
            Console.WriteLine("Enter the movie ratings");
            //1st for :  is rows
            //2nd for : number of columns
            for (int i = 0; i < movieRatings.GetLength(0); i++)
            {  //just Length will give us total # elements. GetLength returns # of elements in that dimension
                for (int j = 0; j < movieRatings.GetLength(1); j++)
                {
                    Console.Write($"Movie [{i}, {j}]:");
                    movieRatings[i,j] = int.Parse(Console.ReadLine());
                } 
            }
            Console.WriteLine("Movie Ratings entered: ");
            for(int i = 0; i < movieRatings.GetLength(0); i++)
            {
                for (int j = 0; j < movieRatings.GetLength(1); j++)
                {
                    Console.Write(movieRatings[i,j] + "\t");
                }
                Console.WriteLine($"User {i+1}: ");
            }
        }
    }
}
