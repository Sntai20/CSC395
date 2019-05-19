// Ask the user to enter a string (e.g. "Welcome to SMU!"
// The program should count and display the total number of vowels (A,E,I,O,U)
// Count both uppercase and lowercase vowels in the given input. 
// The ouput should be 9 in the example aboce.
using System;

namespace M1P1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Ask the user to enter a string (e.g. "Welcome to SMU!"
            Console.Write("Please enter a string: ");

            // Store user input in a variable.
            string userInput = Console.ReadLine();

            // Convert userInput to lowercase.
            //userInput.ToLower();
            Console.WriteLine(userInput.ToLower());

            // Count total number of vowels in userInput.


        }
    }
}
