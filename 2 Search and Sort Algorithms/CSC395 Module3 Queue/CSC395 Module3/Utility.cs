using System;
using System.IO;
using System.Text;

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

        // Problem 3 Implement FIFO using two stacks.
        public void ComplicatedQueue(string[] myQArr)
        {
            // Create StackOne.
            TwoStacksQueue S1 = new TwoStacksQueue();
            // Create StackTwo.
            TwoStacksQueue S2 = new TwoStacksQueue();

            // To store contents into stack S1, use the push method.

            // To reverse the order, pop S1 contents and push to stack S2.

            // To complete the FIFO process, pop S2 contents.

        }
    }
}
