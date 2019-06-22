﻿using System;
using System.Collections.Generic;

namespace CSC395_Module5
{
    public class Node<T>
    {
        //public int Index { get; set; }
        public T Data { get; set; }
        public List<Node<T>> Neighbors { get; set; } = new List<Node<T>>();
        //public List<int> Weights { get; set; } = new List<int>();

        //public override string ToString()
        //{
        //    return $"Node with index {Index}: {Data}, 
        //        neighbors: { Neighbors.Count}
        //    "; 
        //}

        public Node(T newLbl)
        {
            Data = newLbl;
        }
    }
}
/// <summary>
/// To store the adjacent neighbors we need a list in each node.
/// Example. The Alice node stores a list of 
/// </summary>
//class Node
//{
//    //public string Label { get; set; }
//    public List<string> Label { get; set; }

//    //public bool wasVisited;
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