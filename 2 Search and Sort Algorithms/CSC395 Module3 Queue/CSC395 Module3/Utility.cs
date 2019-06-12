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

    public class TwoStacksQueue
    {
        Stack<string> S1 = new Stack<string>();
        // Create enqueue like behavior.
        public void Enqueue(string value)
        {
            S1.Push(value);
        }

        // Create dequeue like behavior.
        public string Dequeue()
        {
            return S1.Pop();
        }

        // To instantiate the class with a generic linkedlist, use a constructor.
        public TwoStacksQueue()
        {
            S1 = new Stack<string>();
        }

        //internal static void ComplicatedQueue(string[] myQArr)
        //{

        //    ComplicatedQueueHelper(myQArr, S1);
        //}

        // Problem 3 Implement FIFO using two stacks.
        internal static void ComplicatedQueue(string[] myQArr, Stack<string> S1)
        {
            // Create StackOne.
            //TwoStacksQueue<string> S1 = new TwoStacksQueue<string>( );
            //Stack<string> S1 = new Stack<string>();
            // Create StackTwo.
            //TwoStacksQueue<string> S2 = new TwoStacksQueue<string>();

            // To store contents from myQarr into stack S1, 
            // use the push method.
            if (myQArr != null)
            {
                foreach (var value in S1)
                {
                    S1.Push(value);
                    Console.WriteLine(value);
                }

                // To reverse the order, 
                // pop S1 contents and push to stack S2.
                //while (!S1.IsEmpty())
                //{
                //    //Console.WriteLine(S.Peek());
                //    string value = S1.Dequeue();

                //    S2.Enqueue(value);
                //    Console.WriteLine();
                //}

                //foreach (string value in S1)
                //{
                //    S1.Dequeue();
                //    S2.Enqueue(value);
                //    Console.WriteLine(value);
                //}

                //// To complete the FIFO process, pop S2 contents.
                //foreach (var value in S1)
                //{
                //    S2.Dequeue();
                //    Console.WriteLine(value);
                //}
                //Console.WriteLine();
            }
        }// To implement a custom generic class the you must use
        // IEnumerable, IEnumerator, and IDisposable.
        // To walk through the contents of the file one line at a time, use IEnumerator(T).
        // Problem 3 Implement a Queue class using two stacks.
        // What is the running time for enqueue() and dequeue()? 

        // Data
        //Stack<string> myStackQueueData;
        //Stack<string> myStackTwoQueueData;
        //Stack<string> S1 = new Stack<string>();

        // Methods
        // Check if empty.
        //public bool IsEmpty()
        //{
        //    return S1.Count == 0;
        //}


        //// Constructor to initialize the first element in the linked list.
        //public SinglyLinkedList()
        //{
        //    first = null;
        //}

        

       

        //    // Must also implement IEnumerable.GetEnumerator, but implement as a private method.
        //    private IEnumerator GetEnumerator1()
        //    {
        //        return this.GetEnumerator();
        //    }

        //    IEnumerator IEnumerable.GetEnumerator()
        //    {
        //        return GetEnumerator1();
        //    }

    }
}
