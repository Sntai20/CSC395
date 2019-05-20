// Ask the user to enter a string (e.g. "Welcome to SMU!"
// The program should count and display the total number of vowels (A,E,I,O,U)
// Count both uppercase and lowercase vowels in the given input. 
// The ouput should be 9 in the example above.
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
            //string userInput = Console.ReadLine();
            string userInput = "Welcome to a Saint Martin's University!";


            // Convert userInput to lowercase.
            string lowerCase = userInput.ToLower();
            //Console.WriteLine(userInput.ToLower());

            // Covert to string to array and store in arr variable.
            char[] arr = lowerCase.ToCharArray();
            //char ch = arr[];
            //foreach (char c in arr)
            //Console.WriteLine(c);

            // Find the vowels in userInput
            string vowelString = "aeiouy";
            char[] vowels = vowelString.ToCharArray();

            int counter = 0;
            Console.WriteLine("\nSearching for vowels in this string");
            for (int i = 0; i < arr.Length; i++)
            {
                //Console.WriteLine("Array = {0}", arr[i]);
                for (int j = 0; j < vowels.Length; j++)
                {
                    // Evaluate if the userInput contains vowels.
                    if (arr[i] == vowels[j])
                    {
                        // Store the total number of vowels.
                        counter = counter + 1;
                    }
                }
            }
            Console.WriteLine("{0} vowels counted in the string", counter);
        }
    }
}
