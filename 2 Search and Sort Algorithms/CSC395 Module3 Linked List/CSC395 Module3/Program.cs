using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Make sure to include the big-Oh for each method.
namespace CSC395_Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new node
            Node myNode = new Node(" ");

            SinglyLinkedList myList = new SinglyLinkedList();
            Console.WriteLine(myList.IsEmpty());
            myList.AddLast("Building");
            myList.AddLast("Legos");

            myList.PrintList();

            //myList.AddFirst(1);
            //myList.AddFirst(2);
            //myList.AddFirst(3);
            //myList.PrintList();

            //Console.WriteLine();
            //myList.AddLast(10);
            //myList.AddLast(20);
            //myList.AddLast(30);
            //myList.PrintList();

            ////////////////////////////////////
            //myList.Insert(-20);
            //myList.Insert(10);
            //myList.Insert(23);

            //myList.Insert(14);

            //myList.Insert(-21);
            //myList.PrintList();

            //myList.delete(10);
            //myList.PrintList();


            //Stack myStack = new Stack();
            //int[] myArr = { 1,2,3,4,5,6,7,8};

            //Console.WriteLine("display the array:");
            //foreach(int val in myArr)
            //    Console.Write(val+" ");

            //foreach (int val in myArr)
            //    myStack.Push(val);

            //for(int i=0;i<myArr.Length;i++)
            //{
            //    myArr[i] = myStack.Peek();
            //    myStack.Pop();
            //}


            //Console.WriteLine("display the array:");
            //foreach (int val in myArr)
            //    Console.Write(val + " ");
            ////while (!myStack.IsEmpty())
            ////{
            ////    Console.WriteLine(myStack.Peek());
            ////    myStack.Pop();
            ////}

            //Queue2 myQueue = new Queue2();
            //myQueue.

// Problem 3 [20 points] To the code written for Problem 1 add a new method void RemoveDuplicates() that will remove all duplicates from the linked list.Do not use an extra array, use only O(1) extra memory for this operation.What is the running time?
// Problem 4 [10 points] To the code written for Problem 1 add a new method bool IsPalindrome() that will check whether the singly linked list is a palindrome.If you don’t remember what palindrome is google the term or stop by my office. What is the running time? E.g. “church” -> “monk” -> “monk” -> “church” is a palindrome.
//Problem 5 [10 points] To the code written for Problem 2 add a new method bool IsPalindrome() that will check whether the doubly linked list is a palindrome.If you don’t remember what palindrome is google the term or stop by my office. What is the running time? E.g. 21 <->  34  <-> 6  <-> 34 <->21 is a palindrome.
        }
    }
}
