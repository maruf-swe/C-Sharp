using System;

namespace _10_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 30;
            if (x > y)
            {
                Console.WriteLine("X is greater than Y");
            }
            else
            {
                Console.WriteLine("Y is greater than X");
            }

            // else if
            int p = 20;
            int q = 30;
            int s = 10;
            if (p > q)
            {
                Console.WriteLine("P is greater than q");
            }
            else if (q>s)
            {
                Console.WriteLine("Q is greater than s");
            }
            else
            {
                Console.WriteLine("S is bigger");
            }

            // Short Hand If...Else (Ternary Operator)
            int time = 20;
            string result = (time < 18) ? "Good Evening" : "Good night";
            Console.WriteLine(result);


        }
    }
}
