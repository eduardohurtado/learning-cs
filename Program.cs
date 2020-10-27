using System;

namespace learning_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.WriteLine("Welcome to the console application, please type number of the desire operation, and then press ENTER:");
            Console.WriteLine("[0]: Add two numbers.");
            Console.WriteLine("[1]: Water temperature.");
            string selection = Console.ReadLine();
            Int32 result;

            if (Int32.TryParse(selection, out result))
            {
                int selector = Int32.Parse(selection);

                switch (selector)
                {
                    case 0:
                        Console.Clear();
                        Int32 num1, num2;

                        Console.WriteLine("Please type the first number, and then press ENTER:");
                        string num1S = Console.ReadLine();

                        try
                        {
                            num1 = Int32.Parse(num1S);

                            Console.WriteLine("Please type the second number, and then press ENTER:");
                            string num2S = Console.ReadLine();

                            if (Int32.TryParse(num2S, out num2))
                            {
                                Console.WriteLine("The addition is: " + AddNumbers(num1, num2));
                            }
                            else { Console.WriteLine("ERROR: Number 2 is not valid."); }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("ERROR: Number 1 is not valid.");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("ERROR: Number 1 is too long, or too short.");
                        }
                        catch (ArgumentNullException)
                        {
                            Console.WriteLine("ERROR: There is not argument to Number 1.");
                        }
                        break;

                    case 1:
                        Console.Clear();
                        string waterNumber;

                        Console.WriteLine("Please type the water temperature, and then press ENTER:");
                        waterNumber = Console.ReadLine();
                        Console.WriteLine("The water state is: " + WaterState(waterNumber));
                        break;

                    default: break;
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
        public static string WaterState(string tempS)
        {
            Int16 temp;
            string stateWater;
            if (Int16.TryParse(tempS, out temp))
            {
                stateWater = temp > 99 ? "Gaseose" : temp <= 0 ? "Solid" : "Liquid";
            }
            else { stateWater = "The temperature isn't valid."; }

            return stateWater;
        }

        public static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
