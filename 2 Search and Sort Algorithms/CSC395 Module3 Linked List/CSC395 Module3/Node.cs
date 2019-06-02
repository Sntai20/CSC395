using System;
namespace CSC395_Module3
{
    public class Node<T>
    {
        // data
        public T value { get; set; }
        public Node<T> next;

        //methods

        // Constructor to initialize the value in the node and point to null.
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }

    }
}
