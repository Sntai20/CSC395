using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC395_Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read user input.
            //string path = @"input.txt";

            // Problem 1 Let Q be a non - empty queue, and let S be an empty stack.
            // This C# program reverses the order of the elements in Q, using S.

            // Make a queue named Q with numbers 1-8.
            Queue2 Q = new Queue2();

            // Read the entries from input.txt (one line per entry) and store them into an array.
            // Each copy call bubbleReverseSort, selectionReverseSort, mergeReverseSort, quickReverseSort. 
            //string[] myQArr = Utility.ReadFromFile(path);



            string[] myQArr = { "1","2","3","4","5","6","7","8" };

            // Display the contents of myQArr.
            Console.Write("Array contents before: ");
            foreach (var val in myQArr)
                Console.Write(val + " ");

            // Make a stack named S.
            Stack S = new Stack();

            // Enqueue the numbers to the queue, then push the values into the stack.
            Console.WriteLine();
            foreach (var val in myQArr)
            {
                Q.Enqueue(val);
                Console.Write($"Enqueue {val} into the queue, then "); 
                Console.WriteLine($"Push {val} on to the stack ");
                S.Push(val);
            }

            // To reverses the order of the elements in Q, pop element off of S.
            for (var i = 0; i < myQArr.Length; i++)
            {
                myQArr[i] = S.Peek();
                S.Pop();
            }

            // Display the contents of myQArr.
            Console.Write("Array contents after: ");
            foreach (var val in myQArr)
                Console.Write(val + " ");
            while (!S.IsEmpty())
            {
                Console.WriteLine(S.Peek());
                S.Pop();
            }
        }
    }
}
