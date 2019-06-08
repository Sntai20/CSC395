using System;
namespace CSC395_Module3
{
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
}
