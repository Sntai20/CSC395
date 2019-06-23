using System;
namespace CSC395_Module3
{
    class Node
    {
        //data
        public string nodeValue { get; set; }
        public Node next;
        public Node previous;

        //methods

        //ctor
        public Node(string value)
        {
            this.nodeValue = value;
            this.next = null;
            this.previous = null;
        }
    }
}
