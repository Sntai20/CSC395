using System;
namespace CSC395_Module3
{
    /// Summary SinglyLinkedList Data and Methods.
    /// 
    /// Data: SinglyLinkedList can implement the Node class as the first node
    /// in the LinkedList.
    /// 
    /// Methods: SinglyLinkedList can perform the following methods
    /// AddFirst, AddLast, Delete, Insert, RemoveFirst, RemoveLast, PrintList.
    public class SinglyLinkedList
    {
        /// Summary Data: SinglyLinkedList can implement a Node class
        /// as the first node in the LinkedList.
        public Node first;

        // TODO Problem 1: Modify the code in class so it works with strings instead of integers.
        // TODO Implement all methods shown in the Course Notes (appendNode, insertNode, deleteNode, displayList, ...)
        /// Summary Methods: SinglyLinkedList can perform the following methods
        /// AddFirst, AddLast, Delete, Insert, RemoveFirst, RemoveLast, PrintList.
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

        public void Delete(string val)
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

        //public void Insert(string val)//it assumes the list is sorted!!!!
        //{
        //    if (IsEmpty() || val <= first.value)
        //        AddFirst(val);
        //    else
        //    {
        //        Node newNode = new Node(val); //create a new node
        //        Node curr = first;
        //        while (curr.next != null && curr.next.value < val)
        //            curr = curr.next;
        //        //if (curr.next == null) //ran to the end of the list
        //        //   curr.next = newNode ;
        //        //else
        //        //{
        //        //    //link in the new node
        //        //    newNode.next = curr.next;
        //        //    curr.next = newNode;
        //        //}
        //        //link in the new node
        //        newNode.next = curr.next;
        //        curr.next = newNode;
        //    }

        //}

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
        // Constructor to initialize the first element in the linked list.
        public SinglyLinkedList()
        {
            first = null;
        }
    }
}
