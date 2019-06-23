using System;
using System.Collections.Generic;

namespace CSC395_Module3
{
    public class Queue2
    {
        // Data
        // O(1)
        LinkedList<string> myQueueData;

        // Methods
        // O(1)
        public void Enqueue(string val)
        {
            myQueueData.AddFirst(val);
        }

        // O(1)
        public void Dequeue()
        {
            myQueueData.RemoveLast();
        }
        //public int Peek()
        //{
        //    return myQueueData.Last();
        //}
        public bool IsEmpty()
        {
            return myQueueData.Count == 0;
        }

        //ctor
        public Queue2()
        {
            myQueueData = new LinkedList<string>();
        }
    }
}
