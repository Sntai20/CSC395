// Ask the user to enter a positive integer b.
// Validate the input(throw an exception if the input is not positive).
// Then output whether or not the number b is divisible by 3.
using System;

namespace M1P2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Ask the user to enter a positive integer b.
            Console.Write("Please enter a positive number: ");

            // Store user input in a variable.
            string userInput = Console.ReadLine();
            //string userInput = "b";
            int result = 0;

            // Validate user input can be parsed and store value in result variable.
            // (throw an exception if the input is not positive).
            // Positive number could not be parsed.
            try
            {
                result = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Positive number could not be parsed.'{userInput}'");
            }

            // Then output whether or not the number b is divisible by 3.
            if (result > 0)
            {
                Console.WriteLine(result / 3);
            }

            else
            {
                throw new FormatException($"Number could not be divided by 3.'{userInput}'");
            }
        }
    }
}
