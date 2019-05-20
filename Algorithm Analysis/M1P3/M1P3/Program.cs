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
            // Ask the user to enter a string (e.g. "Welcome to SMU!"
            Console.Write("Please enter a string: ");

            // Store user input in a variable.
            //string userInput = Console.ReadLine();
            string userInput = "Welcome to Saint Martin’s U!";
            ReadFromFile();
            Console.WriteLine(CountVowels(userInput));

          
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

        public static int CountVowels(string userInput)
        {
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
            return counter;
        }
    }
}

