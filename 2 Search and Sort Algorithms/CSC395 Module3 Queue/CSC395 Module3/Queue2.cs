using System;
using System.Collections.Generic;

namespace CSC395_Module3
{
    public class Queue2
    {
        //data
        LinkedList<int> myQueueData;
        //methods
        public void Enqueue(int val)
        {
            myQueueData.AddFirst(val);
        }
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
            myQueueData = new LinkedList<int>();
        }
    }
}
