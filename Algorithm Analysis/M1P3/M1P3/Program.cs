// Ask the user to enter a positive integer b.
// Validate the input(throw an exception if the input is not positive).
// Then output whether or not the number b is divisible by 3.

using System;

namespace M1P3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Ask the user to enter a positive integer b.
            Console.Write("Please enter a positive number: ");

            ReadFromFile();
            //// Store user input in a variable.
            //string userInput = Console.ReadLine();
            ////string userInput = "b";
            //int result = 0;

            //// Validate user input can be parsed and store value in result variable.
            //// (throw an exception if the input is not positive).
            //// Positive number could not be parsed.
            //try
            //{
            //    result = int.Parse(userInput);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine($"Positive number could not be parsed.'{userInput}'");
            //}

            //// Then output whether or not the number b is divisible by 3.
            //if (result > 0)
            //{
            //    Console.WriteLine(result / 3);
            //}

            //else
            //{
            //    throw new FormatException($"Number could not be divided by 3.'{userInput}'");
            //}

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }

        private static void ReadFromFile()
        {
            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Antonio\Documents\GitHub\CSC395\M1P3\M1P3.txt ");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of M1P3.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }
        }
    }
}

