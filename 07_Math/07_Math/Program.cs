using System;

namespace _07_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            // Max method can return max value
            int x = 10;
            int y = 20;
            int d = Math.Max(x, y);
            Console.WriteLine(d);
            // or
            int x1 = 10;
            int y1 = 20;
            Console.WriteLine(Math.Max(x1, y1));

            //or
            Console.WriteLine(Math.Max(10, 5));

            // Min method can return minimum value
            Console.WriteLine(Math.Min(100, 110));

            // Sqrt method
            Console.WriteLine(Math.Sqrt(64));

            // Abs method return possitive value
            Console.WriteLine(Math.Abs(-4.7));

            // Round method
            Console.WriteLine(Math.Round(9.99));


        }
    }
}
