using System;
namespace CSC395_Module3
{
    public class Node
    {
        // data
        public string value { get; set; }
        public Node next;

        //methods

        // Constructor to initialize the value in the node and point to null.
        public Node(string value)
        {
            this.value = value;
            this.next = null;
        }

    }
}
