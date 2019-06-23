using System;
using System.Collections;
using System.Collections.Generic;

namespace CSC395_Module3
{
    public class TwoStacksQueueEnumberable<T> : IEnumerable<T>
    {
        // Problem 3 Implement a Queue class using two stacks.
        // What is the running time for enqueue() and dequeue()? 

        // O(1) Data
        Stack<T> S1 = new Stack<T>();
        Stack<T> S2 = new Stack<T>();

        // To instantiate the class with generic stacks, use a constructor.
        public TwoStacksQueueEnumberable()
        {
            Stack<T> stack1 = new Stack<T>();
            Stack<T> stack2 = new Stack<T>();
        }

        // Methods
        // Check if empty.
        public bool IsEmpty()
        {
            return S1.Count == 0;
        }

        // Create enqueue like behavior. O(1)
        // To store contents from myQarr into stack S1, use the push method.
        public void Enqueue(T value)
        {
            S1.Push(value);
        }

        // Create dequeue like behavior. O(n)
        // To reverse the order, 
        // pop S1 contents and push to stack S2.
        public T Dequeue()
        {
            while (S1.Count != 0) 
                S2.Push(S1.Pop()); 

            T ret = S2.Pop();

            // To complete the FIFO process, pop S2 contents.
            while (S2.Count != 0)  
                S1.Push(S2.Pop()); 

            return ret; 
        }

        // To implement a custom generic class the you must use
        // IEnumerable, IEnumerator, and IDisposable.
        // To walk through the contents of the file one line at a time, use IEnumerator(T).

        // IEnumerator O(n)
        public IEnumerator<T> GetEnumerator()
        {
            while (S1.Count != 0)
                S2.Push(S1.Pop());

            T ret;

            while (S2.Count != 0)
            {
                ret = S2.Peek(); 
                S1.Push(S2.Pop());
                yield return ret;
            }
        }

        // Private GetEnumerator
        // IEnumerator
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}


