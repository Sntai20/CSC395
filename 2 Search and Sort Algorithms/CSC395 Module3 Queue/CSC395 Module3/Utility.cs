using System;
using System.IO;
using System.Text;
using System.Collections.Generic;


namespace CSC395_Module3
{
    public class Utility
    {
        public static string[] ReadFromFile(string inputPath)
        {
            // Read text from text file, change to lower, and store in lowerWords.
            string[] words = System.IO.File.ReadAllLines(inputPath);

            // Create parallel array of words by calling ToLower.
            string[] lowerWords = new string[words.Length];
            for (int ctr = words.GetLowerBound(0); ctr <= words.GetUpperBound(0); ctr++)
                lowerWords[ctr] = words[ctr].ToLower();

            // Pass the file contents to main.
            return lowerWords;
        }

        internal static string[] ReverseFileContentsWithQueueAndStack(string[] myQArr)
        {
            // Problem 1 Let Q be a non - empty queue, and let S be an empty stack.
            // This C# program reverses the order of the elements in Q, using S.

            // Make a queue named Q to contents of myQArr.
            Queue2 Q = new Queue2();

            // Make a stack named S to store the contents of the Q.
            Stack S = new Stack();

            // Enqueue the numbers to the queue, then push the values into the stack.
            foreach (var val in myQArr)
            {
                Q.Enqueue(val);
                S.Push(val);
            }

            // To reverses the order of the elements in Q, pop element off of S.
            for (var i = 0; i < myQArr.Length; i++)
            {
                myQArr[i] = S.Peek();
                S.Pop();
            }
            while (!S.IsEmpty())
            {
                Console.WriteLine(S.Peek());
                S.Pop();
            }
            return myQArr;
        }

        internal static void WriteToFile(string outputPath, string[] myQArr)
        {
            // Check to see if the file already exists.
            if (!File.Exists(outputPath))
            {
                // Create a file to write to.
                File.WriteAllLines(outputPath, myQArr, Encoding.UTF8);
            }
        }
    }
}
