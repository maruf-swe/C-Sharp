using System;

namespace _13_ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello World!");
            }
            for (int i = 0; i < 50; i = i + 2)
            {
                Console.WriteLine("Hello World!");
                if (i == 30)
                {
                    break;
                }
            }
        }
    }
}
