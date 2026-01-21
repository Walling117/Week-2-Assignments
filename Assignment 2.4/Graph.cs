using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Assignment_2._4
{
    internal static class Graph
    {
        public static void StartGraphMenu()
        {
            int[] points = new int[4];
            string[] strPoints = { "x1", "y1", "x2", "y2" };
            Console.Clear();
            Console.WriteLine("Find which quadrant your two points are in");
            Console.WriteLine("".PadLeft(60,'-'));
            
            for(int i = 0; i < 4; i++)
            {
                Console.Write($"{strPoints[i]}: ");
                while(!int.TryParse(Console.ReadLine(), out points[i]));
                Console.WriteLine();
            }
            PrintPoints(x1: points[0], y1: points[1], x2: points[2], y2: points[3]);
            Console.WriteLine($"\nPoint ({points[0]}, {points[1]}) is in {GetQuadrant(points[0], points[1])}");
            Console.WriteLine($"\nPoint ({points[2]}, {points[3]}) is in {GetQuadrant(points[2], points[3])}");
            Console.ReadKey();



        }

        private static string GetQuadrant(int x1, int y1)
        {
            if (x1 > 0 && y1 > 0)
            {
                return "Quadrant I";
            }
            else if (x1 < 0 && y1 > 0)
                return "Quadrant II";
            else if (x1 < 0 && y1 < 0)
                return "Quadrant III";
            else return "Quadrant IV";
        }

        private static void PrintPoints(int x1, int x2, int y1, int y2)
        {

            // find highest and lows
            int highestYValue = int.Abs(y1) > int.Abs(y2) ? int.Abs(y1) : int.Abs(y2);
            int highestXValue = int.Abs(x1) > int.Abs(x2) ? int.Abs(x1) : int.Abs(x2);

            int highestValue = highestXValue > highestYValue ? highestXValue : highestYValue;

            Console.ForegroundColor = ConsoleColor.Blue;
            for (int y = highestValue; y > 0; y--) //Top
            {
                for (int x = -highestValue; x <= highestValue; x++)
                {
                    if ((x == x1 && y == y1) || (x == x2 && y == y2))
                    {
                        if (x == x1 && y == y1) //If point1 found, print p1
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" 1 ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else // else print p2
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" 2 ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                    }
                    else if (x == 0)
                        Console.Write(" * ");
                    else
                        Console.Write("   ");
                }
                Console.WriteLine();
            }

            for (int x = -highestValue; x <= highestValue; x++) //Middle
            {
                if ((x == x1 && y1 == 0) || (x == x2 && y2 == 0))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" X");
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (x == 0)
                    Console.Write(" 0 ");
                else
                    Console.Write(" * ");
            }

            Console.WriteLine();
            for (int y = -1; y >= -highestValue; y--) //Bottom
            {
                for (int x = -highestValue; x < highestValue; x++)
                {
                    if ((x == x1 && y == y1) || (x == x2 && y == y2))
                    {
                        if (x == x1 && y == y1) //If point1 found, print p1
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" 1 ");
                        }
                        else //else print p2
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" 2 ");
                        }
                        Console.ForegroundColor = ConsoleColor.Blue;

                    }
                    else if (x == 0)
                        Console.Write(" * ");
                    else
                        Console.Write("   ");
                }
                Console.WriteLine();
            }
        }
    }
}
