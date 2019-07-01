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
    public class Node<T> //: IEnumerable<T>
    {
        // Node memebers.
        // To access the node in a graph using an index
        // number, store the index number in a property.
        public int Index { get; set; }

        // To store data of type T, use a property named Data.
        public T Data { get; set; }

        // To store the references to the adjacent nodes,
        // use the property named Neighbors as an adjaceny list for a specifc node.
        public List<Node<T>> Neighbors { get; set; } = new List<Node<T>>();

        // To store the weight of the edges, use the property
        // named Weights as a list.
        public List<int> Weights { get; set; } = new List<int>();

        // To return the textual representation of an object,
        // use the ToString method.
        public override string ToString()
        {
            return $"Index {Index}: {Data} Node is connected to {Neighbors.Count} neighbors.";
        }

        // To identify if the nodes has been visited, 
        // use the wasVisited flag.
        //public bool wasVisited;
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

//    public Node(List<string> { newLbl, new)
//    {
//        Label = newLbl;
//        Edge = newEdge;
//    }
//}