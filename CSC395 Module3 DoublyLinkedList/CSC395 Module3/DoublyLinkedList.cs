using System;
namespace CSC395_Module3
{
    /// Summary DoublyLinkedList Data and Methods.
    /// Problem 1: Code works with strings instead of integers.
    class DoublyLinkedList
    {
        /// Data: DoublyLinkedList can implement the Node class as the first node
        /// in the LinkedList.
        public Node firstNode;
        public Node lastNode;

        // Constructor to initialize the first element in the linked list.
        public DoublyLinkedList()
        {
            firstNode = null;
            lastNode = null;
        }

        /// Methods: DoublyLinkedList can perform the following methods
        /// AddFirst, AddLast, RemoveFirst, RemoveLast, Delete, Insert, PrintList.
        public bool IsEmpty()
        {
            //if (first == null)
            //    return true;
            //else
            //    return false;
            return firstNode == null;
        }

        // O(n)
        public void AddLast(string nodeValue)
        {
            if (IsEmpty())
                AddFirst(nodeValue);
            else
            {
                Node current = lastNode;
                lastNode = new Node(nodeValue);
                current.next = lastNode;
                lastNode.previous = current;
            }
        }

        // O(n)
        public void AddFirst(string nodeValue)
        {
            Node newNode = new Node(nodeValue);
            if (IsEmpty())
            {
                firstNode = newNode;
                lastNode = newNode;
            }
            else
            {
                Node current = firstNode;
                firstNode = newNode;
                current.previous = firstNode;
                firstNode.next = current;
            }
        }

        public void PrintList()
        {
            Console.WriteLine();
            Console.WriteLine();
            if (IsEmpty())
                Console.WriteLine("the list is empty!!!");
            else
            {
                Node current = firstNode;
                while (current != null)
                {
                    Console.Write(current.nodeValue + "  ");
                    current = current.next;
                }
            }
        }

        // This part really confuses me.
        // I remember there being two pointers to the first node, but
        // I don't remember enough to implement this method for a doubly linked list.
        public bool IsPalindrome() // O(n)
        {
            if (IsEmpty())
                Console.WriteLine("the list is empty!!!");

            bool PalindromeTest = true;

            Node comparer1 = firstNode;
            Node comparer2 = lastNode;

            while (comparer1 != comparer2 && comparer1.previous != comparer2) // O(n)
            {
                if (comparer1.nodeValue != comparer2.nodeValue)
                {
                    PalindromeTest = false;
                    break;
                }
                comparer1 = comparer1.next;
                comparer2 = comparer2.previous;
            }
            return PalindromeTest;
        }
    }
}
