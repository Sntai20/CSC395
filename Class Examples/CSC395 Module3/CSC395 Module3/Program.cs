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
            //create a new node
            Node myNode = new Node(0);

            SinglyLinkedList myList = new SinglyLinkedList();
            Console.WriteLine(myList.IsEmpty());
            myList.AddLast(7);

            myList.PrintList();

            myList.AddFirst(1);
            myList.AddFirst(2);
            myList.AddFirst(3);
            myList.PrintList();

            Console.WriteLine();
            myList.AddLast(10);
            myList.AddLast(20);
            myList.AddLast(30);
            myList.PrintList();
        }
    }

    class Node
    {
        //data
        public int value { get; set; }
        public Node next;

        //methods

        //ctor
        public Node(int value)
        {
            this.value = value;
            this.next = null;
        }

    }

    class SinglyLinkedList
    {
        //data
        Node first;

        //methods
        public bool IsEmpty()
        {
            //if (first == null)
            //    return true;
            //else
            //    return false;
            return first == null;
        }

        public void AddLast(int val)
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


        public void AddFirst(int value)
        {
            Node newNode = new Node(value);
            newNode.next = first;
            first = newNode;
        }

        public void PrintList()
        {
            Console.WriteLine();
            Console.WriteLine();
            if(IsEmpty())
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
        //ctor
        public SinglyLinkedList()
        {
            first = null;
        }
    }
}
