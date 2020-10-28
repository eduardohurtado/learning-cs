using System;

namespace learning_cs
{
    class Human
    {
        // Variable member
        private string firstName = "Undefined";
        private string lastName = "Undefined";

        // Not parameterized constructor member
        public Human()
        {
            Console.Clear();
            Console.WriteLine("Not parameterized constructor called.");
            Console.WriteLine("\nPress any key to proceed...");
            Console.ReadKey();
        }

        // Parameterized constructor member
        public Human(string myFirstName, string lastName)
        {
            firstName = myFirstName;
            this.lastName = lastName;
        }

        // Parameterized but no complete constructor member
        public Human(string myFirstName)
        {
            firstName = myFirstName;
        }

        // Method member
        public void greet()
        {
            if (lastName.Equals("Undefined"))
            {
                Console.Clear();
                Console.WriteLine("Hello world! My name is {0}", firstName);
                Console.WriteLine("\nPress any key to proceed...");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Hello world! I'm {0} {1}", firstName, lastName);
                Console.WriteLine("\nPress any key to proceed...");
                Console.ReadKey();
            }
        }
    }
}