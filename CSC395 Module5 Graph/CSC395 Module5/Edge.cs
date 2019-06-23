using System;
using System.Collections;
using System.Collections.Generic;

namespace CSC395_Module5
{
    public class Edge<T> : IEnumerable<T>
    {
        public Node<T> From { get; set; }
        public Node<T> To { get; set; }
        public List<Node<T>> Neighbors = new List<Node<T>>();
        //public int Weight { get; set; }

        //public override string ToString()
        //{
        //    return $"Edge: {From.Data} -> {To.Data},  
        //        weight: { Weight}
        //    "; 
        //}

        public Edge()
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var neighbor in Neighbors)
            {

                //ToString(Label);
                yield return neighbor.Label;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
