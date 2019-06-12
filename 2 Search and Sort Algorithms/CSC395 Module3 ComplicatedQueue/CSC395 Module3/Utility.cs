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

        internal static void WriteToFile(string outputPath, string[] myQArr)
        {
            // Check to see if the file already exists.
            if (!File.Exists(outputPath))
            {
                // Create a file to write to.
                File.WriteAllLines(outputPath, myQArr, Encoding.UTF8);
            }
        }

        // Problem 3 Implement FIFO using two stacks.
        internal static void ComplicatedQueue(string[] myQArr)
        {
            // Create custom queue.
            TwoStacksQueueEnumberable<string> Q1 = new TwoStacksQueueEnumberable<string>();

            // Enqueue the values into the queue.
            foreach (var val in myQArr)
            {
                //Console.WriteLine(val); 
                Q1.Enqueue(val);
            }

            // Dequeue the values from the queue.
            while (!Q1.IsEmpty())
            {
                Console.WriteLine(Q1.Dequeue()); 
            }
        }
    }
}
