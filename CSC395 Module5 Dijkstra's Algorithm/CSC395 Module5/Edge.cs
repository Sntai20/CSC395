﻿using System;
namespace CSC395_Module5
{
    public class Edge<T>
    {
        public Node<T> From { get; set; }
        public Node<T> To { get; set; }
        public int Weight { get; set; }

        public override string ToString()
        {
            return $"Edge: {From.Data} -> {To.Data},  weight: { Weight}"; 
        }
    }
}
