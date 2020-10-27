using System;

namespace learning_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.WriteLine("What's your name?");

            int num1 = 12;
            Console.WriteLine(num1);

            string myString = "99";

            TypeSome();
            TypeSomeSpec("I'm an argument");

            Console.WriteLine(Int32.Parse(myString) + Int32.Parse(myString));
            Console.ReadKey();
        }

        // Access level - (static) - Return type - Method name (params)
        public static void TypeSome()
        {
            Console.WriteLine("Typed some from TypeSome");
        }

        public static void TypeSomeSpec(string myText)
        {
            Console.WriteLine(myText);
        }
    }
}
