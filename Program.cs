using System;

namespace learning_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.WriteLine("Welcome to the console application, please type number of the desire operation:");
            Console.WriteLine("[0]: Add two numbers.");
            string selection = Console.ReadLine();
            Int32 result;

            if (Int32.TryParse(selection, out result))
            {
                int selector = Int32.Parse(selection);

                switch (selector)
                {
                    case 0:
                        Int32 num1, num2;

                        Console.WriteLine("Please type the first number, and then press ENTER:");
                        string num1S = Console.ReadLine();

                        if (Int32.TryParse(num1S, out num1))
                        {
                            num1 = Int32.Parse(num1S);

                            Console.WriteLine("Please type the second number, and then press ENTER:");
                            string num2S = Console.ReadLine();

                            if (Int32.TryParse(num2S, out num2))
                            {
                                num2 = Int32.Parse(num2S);

                                Console.WriteLine("The addition is: " + AddNumbers(num1, num2));
                            }
                            else { Console.WriteLine("Error: Number 2 is not valid."); }
                        }
                        else { Console.WriteLine("Error: Number 1 is not valid."); }
                        break;
                }
            }
            else
            {
                Console.WriteLine("ERROR: the option was not recognized.");
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        // Access level - (static) - Return type - Method name (params)
        public static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
