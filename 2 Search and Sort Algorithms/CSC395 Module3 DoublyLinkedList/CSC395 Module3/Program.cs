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
            //Node myNode = new Node(" ");

            DoublyLinkedList myList = new DoublyLinkedList();
            //Console.WriteLine(myList.IsEmpty());
            myList.AddFirst("Legos");
            myList.AddFirst("Building");

            myList.AddLast("Legos");
            myList.AddLast("Tomorrow's");
            myList.AddLast("Legos");
            myList.PrintList();

            myList.RemoveDuplicates();
            //myList.Insert(10);
            //myList.Insert(23);
            myList.Insert("Today");
            //myList.PrintList();
            myList.Delete("Legos");
            myList.PrintList();

            bool PalindromeTest = myList.IsPalindrome();
            Console.WriteLine("\n");
            Console.WriteLine($"Palindrome test results: {PalindromeTest}");
            
        }
    }
}
