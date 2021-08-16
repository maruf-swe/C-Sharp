using System;

namespace _04_Type_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Casting
            int myInt = 9;
            double myDouble = myInt; // Automatic casting: int to double
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            // Explicit Casting
            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble2;    // Manual casting: double to int

            Console.WriteLine(myDouble2);   // Outputs 9.78
            Console.WriteLine(myInt2);      // Outputs 9

            // Type Conversation Methods
            int myInt3 = 10;
            double myDouble3 = 5.25;
            bool myBool = true;
            int m = Convert.ToInt32(myDouble3);
            Console.WriteLine(Convert.ToString(myInt3));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt3));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble3));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
            Console.WriteLine(m);
        }
    }
}
