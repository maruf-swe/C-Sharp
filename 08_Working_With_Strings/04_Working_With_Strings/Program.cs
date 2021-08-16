using System;

namespace _04_Working_With_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Examples of Special Characters
            Console.WriteLine("Hello\nWorld!"); // line break
            Console.WriteLine("It\'s World!"); // single quote
            Console.WriteLine("Hello\"s World!"); // double quote
            Console.WriteLine("\"Hello\"s World!"); // double quote
            Console.WriteLine("Hello\\World!"); // backslash

            // return boolean

            string x = "Maruf Academy";
            Console.WriteLine(x.Contains("Academy"));

            // string length
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            // string method
            string txt2 = "Hello World";
            Console.WriteLine(txt2.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt2.ToLower());   // Outputs "hello world"

            // string concetation
            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);

            // String Interpolation
            string fName = "John";
            string lName = "Doe";
            string name2 = $"My full name is: {fName} {lName}";
            Console.WriteLine(name2);

            // access string
            string a = "Hello World";
            Console.WriteLine(a[6]);
            Console.WriteLine(a.IndexOf("l"));

            // slice string
            string y = "Hello Maruf";
            Console.WriteLine(y.Substring(6));
            Console.WriteLine(y.Substring(6,2));
       


        }
    }
}
