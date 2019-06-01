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
            //Test
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
        }
    }
}
