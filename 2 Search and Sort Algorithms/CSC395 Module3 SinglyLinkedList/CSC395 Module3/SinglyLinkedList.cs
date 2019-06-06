using System;
namespace CSC395_Module3
{
    /// Summary SinglyLinkedList Data and Methods.
    /// Problem 1: Code works with strings instead of integers.
    class SinglyLinkedList
    {
        /// Data: SinglyLinkedList can implement the Node class as the first node
        /// in the LinkedList.
        public Node first;

        // Constructor to initialize the first element in the linked list.
        public SinglyLinkedList()
        {
            first = null;
        }

        /// Methods: SinglyLinkedList can perform the following methods
        /// AddFirst, AddLast, RemoveFirst, RemoveLast, Delete, Insert, PrintList.
        public bool IsEmpty()
        {
            //if (first == null)
            //    return true;
            //else
            //    return false;
            return first == null;
        }

        public void AddFirst(string value)
        {
            Node newNode = new Node(value);
            newNode.next = first;
            first = newNode;
        }

        public void AddLast(string val)
        {
            if (IsEmpty())
                AddFirst(val);
            else
            {
                Node newNode = new Node(val);

                Node current = first;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = newNode;
            }
        }

        public void RemoveFirst()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException("you can't remove first from an emtpy list");
            else
                first = first.next;

        }

        public void RemoveLast()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException("you can't remove last from an emtpy list");
            else if (first.next == null)//we have only one element in the list
            {
                first = null; //empty the list
            }
            else
            {
                Node current = first;
                while (current.next.next != null)
                    current = current.next;
                current.next = null;//remove the last node by making the next to last node point to null 
            }
        }

        public void delete(string val)
        {
            if (IsEmpty())
                throw new Exception("you can't delete from an empty list");
            else if (val == first.value)
                RemoveFirst();
            else
            {
                Node curr = first;

                while (curr.next != null && curr.next.value != val)
                    curr = curr.next;
                if (curr.next == null) //we didn't find the value val in the list
                    throw new Exception("we didn't find  the element in the list");
                else
                    curr.next = curr.next.next;
            }
        }

        public void Insert(string val)//it assumes the list is sorted!!!!
        {
            if (IsEmpty() || string.Compare(val, first.value) >= 0)
            {
                AddFirst(val);
            }
            else
            {
                Node newNode = new Node(val); //create a new node
                Node curr = first;
                while (curr.next != null && string.Compare(curr.next.value, val) < 0)
                    curr = curr.next;
                //if (curr.next == null) //ran to the end of the list
                //   curr.next = newNode ;
                //else
                //{
                //    //link in the new node
                //    newNode.next = curr.next;
                //    curr.next = newNode;
                //}
                //link in the new node
                newNode.next = curr.next;
                curr.next = newNode;
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
                Node current = first;
                while (current != null)
                {
                    Console.Write(current.value + "  ");
                    current = current.next;
                }
            }
        }

        // TODO Problem 3: Add a new method void RemoveDuplicates() to remove 
        // all duplicates from the linked list. Do not use an extra array, use 
        // only O(1) extra memory for this operation.What is the running time?
        public void RemoveDuplicates()
        {
            // Pointer to head of the list.
            Node curr = first;

            // Pointer to store the next  
            //pointer of a node to be deleted*/
            Node next_next;

            // Throw exception if the list is empty 
            if (IsEmpty())
                throw new Exception("you can't delete from an empty list");

            // Traverse list till the last node
            while (curr.next != null)
            {

                // Compare current node with the next node
                if (string.Compare(curr.value, curr.next.value) == 0)
                {
                    next_next = curr.next.next;
                    curr.next = null;
                    curr.next = next_next;
                }
                else // advance if no deletion 
                    curr = curr.next;
            }
        }

        // TODO Problem 4: Add a new method bool IsPalindrome() to check whether 
        // the singly linked list is a palindrome. What is the running time?
    }
}
