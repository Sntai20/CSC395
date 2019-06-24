using System;
using System.Collections;
using System.Collections.Generic;

namespace CSC395_Module5
{
    /// <summary>
    /// To build a Graph class we need to build a node class to
    /// store the nodes of a graph. To store the adjacent neighbors we need a list in each node.
    /// Example. The Alice node stores a list of 
    /// </summary>
    public class Node<T> : IEnumerable<T>
    {
        // Two data memebers.
        // To identify the node, use the label with type T.
        public T Label { get; set; }
        // To keep track if the node was visited.
        public bool wasVisited;

        // To store an adjaceny list.
        //public Edge<T> myNeighbors = new Edge<T>();
        public List<Node<T>> Neighbors = new List<Node<T>>();
        //public List<int> Weights = new List<int>();

        // Node Constructor
        public Node(T newLbl)
        {
            Label = newLbl;
        }

        public void addNeighbor(Node<T> nodeTo)
        {
            Neighbors.Add(nodeTo);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var neighbor in Neighbors)
            {
                
                //ToString(Label);
                    yield return neighbor.Label;
            }
            //while (Neighbors.Count != 0)
            //{
            //    //Neighbors.ToString = ret;
            //    //T ret;
            //    yield return Neighbors..Label;
            //}
      
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}

//class Node
//{
//    //public string Label { get; set; }
//    public List<string> Label { get; set; }


//    public Node(string newLbl)//, List<string> newEdge)
//    {
//        //Label = newLbl;
//        //Edge = newEdge;
//    }
//    //public bool wasVisited;
//    public Node(List<string> { newLbl, new)
//    {
//        Label = newLbl;
//        Edge = newEdge;
//    }
//}