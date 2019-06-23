using System;
namespace CSC395_Module3
{
    class Node
    {
        //data
        public string value { get; set; }
        public Node next;

        //methods

        //ctor
        public Node(string value)
        {
            this.value = value;
            this.next = null;
        }

    }
}
