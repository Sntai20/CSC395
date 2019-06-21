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
            myList.AddFirst("Tomorrow's");
            myList.AddFirst("Building");
            myList.AddLast("Legos");
            myList.AddLast("Today");
            myList.PrintList();

            //bool PalindromeTest = myList.IsPalindrome();
            //Console.WriteLine("\n");
            //Console.WriteLine($"Palindrome test results: {PalindromeTest}");
            
        }
    }
}
