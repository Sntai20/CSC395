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
            // Create a new node.
            Node myNode = new Node(" ");

            DoublyLinkedList myList = new DoublyLinkedList();
            //Console.WriteLine(myList.IsEmpty());
            myList.AddFirst("Legos"); 
            myList.AddFirst("Building"); 

            myList.AddLast("Legos");
            myList.AddLast("Today");
            //myList.AddFirst(2);
            //myList.AddFirst(3);
            myList.PrintList();

            //myList.Insert(-20);
            //myList.Insert(10);
            //myList.Insert(23);
            //myList.Insert(-21);
            //myList.PrintList();

            //myList.delete(10);
            myList.RemoveDuplicates();
            //myList.IsPalidrome();
            myList.PrintList();
        }
    }
}
