using System;

namespace _12_While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 5);

            // break statement

            int k = 0;

            while (true)
            {
                Console.WriteLine("k = {0}", k);

                k++;

                if (k > 10)
                    break;
            }


            // nested while loop
            int n = 0, m = 1;

            while (n < 2)
            {
                Console.WriteLine("n = {0}", n);
                n++;

                while (m < 2)
                {
                    Console.WriteLine("m = {0}", m);
                    m++;
                }
            }
        }
    }
}
