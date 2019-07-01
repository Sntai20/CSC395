using System;
using System.Collections;
using System.Collections.Generic;

namespace CSC395_Module5
{
    public class Edge<T> //: IEnumerable<T>
    {
        // To store the nodes adjacent from the edge, use the property name From.
        public Node<T> From { get; set; }

        // To store the nodes adjacent to the edge, use the property name To.
        public Node<T> To { get; set; }

        // To store the weight of the edge, use the property named Weight.
        public int Weight { get; set; }

        // To present the basic information about the edge, use the ToString method.
        public override string ToString()
        {
            return $"Edge: {From.Data} -> {To.Data}, weight: { Weight}"; 
        }
    }
}
