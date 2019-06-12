using System;
using System.Collections;
using System.Collections.Generic;

namespace CSC395_Module3
{
    ////public class TwoStacksQueueEnumberable : IEnumerable<string>
    ////{
    ////    // private
    ////    // IEnumerable
    ////    private Stack<string> _myStackQueueData;
    ////    //private string _myStackQueueData;

    ////    public TwoStacksQueueEnumberable(string value)
    ////    {
    ////        _myStackQueueData.Push(value);
    ////    }

    ////    // IEnumerator
    ////    public IEnumerator<string> GetEnumerator()
    ////    {
    ////        return new TwoStacksQueueEnumerator(_myStackQueueData);
    ////    }

    ////    // Private GetEnumerator
    ////    private IEnumerator GetEnumerator1()
    ////    {
    ////        return this.GetEnumerator();
    ////    }

    ////    // IEnumerator
    ////    IEnumerator IEnumerable.GetEnumerator()
    ////    {
    ////        return GetEnumerator1();
    ////    }
    //////}

    //public class TwoStacksQueue
    //{
    //    // To implement a custom generic class the you must use
    //    // IEnumerable, IEnumerator, and IDisposable.
    //    // To walk through the contents of the file one line at a time, use IEnumerator(T).


    //    // Problem 3 Implement a Queue class using two stacks.
    //    // What is the running time for enqueue() and dequeue()? 

    //    // Data
    //    //Stack<string> myStackQueueData;
    //    //Stack<string> myStackTwoQueueData;




    //// Methods
    //// Check if empty.
    //public bool IsEmpty()
    //    {
    //        return S1.Count == 0;
    //    }


    //    //// Constructor to initialize the first element in the linked list.
    //    //public SinglyLinkedList()
    //    //{
    //    //    first = null;
    //    //}

    //    // Create enqueue like behavior.
    //    public void Enqueue(string value)
    //    {
    //        S1.Push(value);
    //    }

    //    // Create dequeue like behavior.
    //    public string Dequeue()
    //    {
    //        return S1.Pop();
    //    }

    //    // To instantiate the class with a generic linkedlist, use a constructor.
    //    public TwoStacksQueue()
    //    {
    //        S1 = new Stack<string>();
    //    }

    //    //public TwoStacksQueue(Stack<string> myStackQueueData)
    //    //{
    //    //    this.myStackQueueData<string> = myStackQueueData;
    //    //}

    //    //    // Must implement GetEnumerator, which returns a new StreamReaderEnumerator.
    //    //    public IEnumerator<string> GetEnumerator()
    //    //    {
    //    //        return new TwoStacksQueueEnumerator(myStackQueueData);
    //    //    }

    //    //    // Must also implement IEnumerable.GetEnumerator, but implement as a private method.
    //    //    private IEnumerator GetEnumerator1()
    //    //    {
    //    //        return this.GetEnumerator();
    //    //    }

    //    //    IEnumerator IEnumerable.GetEnumerator()
    //    //    {
    //    //        return GetEnumerator1();
    //    //    }

    //}
    ////public class TwoStacksQueueEnumerator : IEnumerator<string>
    ////{
    ////    private Stack<string> myStackQueueData;
    ////    private string _myStackQueueData;

    ////    public TwoStacksQueueEnumerator(Stack<string> myStackQueueData)
    ////    {
    ////        this.myStackQueueData = myStackQueueData;
    ////    }

    ////    public TwoStacksQueueEnumerator(string myStackQueueData)
    ////    {
    ////        _myStackQueueData = myStackQueueData;
    ////    }

    ////    public string Current => throw new NotImplementedException();

    ////    object IEnumerator.Current => throw new NotImplementedException();

    ////    public void Dispose()
    ////    {
    ////        throw new NotImplementedException();
    ////    }

    ////    public bool MoveNext()
    ////    {
    ////        throw new NotImplementedException();
    ////    }

    ////    public void Reset()
    ////    {
    ////        throw new NotImplementedException();
    ////    }
    ////}
}
