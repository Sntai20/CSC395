using System;
namespace CSC395_Module3
{
    public class Stack
    {
        //data - we'll base our stack on a linked list
        SinglyLinkedList myStackData;

        //
        public bool IsEmpty()
        {
            return myStackData.IsEmpty();
        }

        public void Push(string val)
        {
            myStackData.AddFirst(val);
        }

        public void Pop()
        {
            myStackData.RemoveFirst();
        }


        public string Peek()
        {
            return myStackData.first.value;
        }


        //ctor  
        public Stack()
        {
            myStackData = new SinglyLinkedList();
        }

    }
}
