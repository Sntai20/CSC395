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

        public void AddLast(string nodeValue)
        {
            if (IsEmpty())
                AddFirst(nodeValue);
            else
            {
                Node newNode = new Node(nodeValue);

                lastNode.next = newNode;
                newNode.previous = lastNode;
                lastNode = newNode;
            }
        }

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
                firstNode.previous = newNode;
                newNode.next = firstNode;
                firstNode = newNode;
            }
        }

        public void RemoveLast()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException("you can't remove last from an emtpy list");
            else if (firstNode == lastNode)
            {
                firstNode = null;
                lastNode = null;
            }

            else
            {
                lastNode = lastNode.previous;
                lastNode.next = null;
            }
        }

        public void RemoveFirst()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException("you can't remove first from an emtpy list");
            else if (firstNode == lastNode)
            {
                firstNode = null;
                lastNode = null;
            }

            else
            {
                firstNode = firstNode.next;
                firstNode.previous = null;
            }
        }

        public void Delete(string nodeValue)
        {
            if (IsEmpty())
                throw new Exception("you can't delete from an empty list");
            else if (nodeValue == firstNode.nodeValue)
                RemoveFirst();
            else
            {
                Node current = firstNode;
                Node newCurrent = firstNode;

                while (current.next != null && current.next.nodeValue != nodeValue)
                    current = current.next;
                if (current.next == null) //we didn't find the value val in the list
                    throw new Exception("we didn't find  the element in the list");
                else
                {
                    newCurrent = current.next.next;
                    current.next = newCurrent;
                    newCurrent.previous = current;
                }
            }
        }

        public void Insert(string nodeValue)//it assumes the list is sorted!!!!
        {
            if (IsEmpty() || string.Compare(nodeValue, firstNode.nodeValue) >= 0)
            {
                AddFirst(nodeValue);
            }
            else
            {
                Node newNode = new Node(nodeValue); //create a new node
                Node curr = firstNode;
                while (curr.next != null && string.Compare(curr.next.nodeValue, nodeValue) > 0)
                    curr = curr.next;

                //link in the new node
                newNode.next = curr.next;
                newNode.previous = curr;
                curr.next = newNode;

                if (newNode.next != null) //ran to the end of the list
                {
                    newNode.next.previous = newNode;
                }

                if (newNode.next == null)
                {
                    lastNode = newNode;
                }
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

        // Problem 3: Add a new method void RemoveDuplicates() to remove 
        // all duplicates from the linked list. Do not use an extra array, use 
        // only O(1) extra memory for this operation.What is the running time?
        public void RemoveDuplicates()
        {
            // Pointer to head of the list.
            Node curr = firstNode;

            // Pointer to store the next  
            //pointer of a node to be deleted
            Node next_next;

            // Throw exception if the list is empty 
            if (IsEmpty())
                throw new Exception("you can't delete from an empty list");

            // Traverse list till the last node
            while (curr.next != null)
            {

                // Compare current node with the next node
                if (string.Compare(curr.nodeValue, curr.next.nodeValue) == 0)
                {
                    next_next = curr.next.next;
                    curr.next = null;
                    curr.next = next_next;
                }
                else // advance if no deletion 
                    curr = curr.next;
            }
        }

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
