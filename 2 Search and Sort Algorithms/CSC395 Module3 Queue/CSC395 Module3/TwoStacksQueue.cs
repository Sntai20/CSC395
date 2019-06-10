using System;
using System.Collections.Generic;

namespace CSC395_Module3
{
    public class TwoStacksQueue
    {
        // Problem 3 Implement a Queue class using two stacks.
        // What is the running time for enqueue() and dequeue()? 

        // Data
        Stack<string> myStackQueueData;
        //Stack<string> myStackTwoQueueData;

        // Methods
        // Check if empty.
        public bool IsEmpty()
        {
            return myStackQueueData.Count == 0;
        }

        // Create enqueue like behavior.
        public void Enqueue(string value)
        {
            myStackQueueData.Push(value);
        }

        // Create dequeue like behavior.
        public void Dequeue()
        {
            myStackQueueData.Pop();
        }

        // To instantiate the class with a generic linkedlist, use a constructor.
        public TwoStacksQueue()
        {
            myStackQueueData = new Stack<string>();
            //myStackTwoQueueData = new Stack<string>();
        }
    }
}
