﻿using System;
using Priority_Queue;
using System.Collections.Generic;

namespace CSC395_Module5
{
    // Graph = {Vertices, Edges}
    public class Graph<T>
    {
        // Data
        private bool _isDirected = false;
        private bool _isWeighted = false;
        public List<Node<T>> Verticies { get; set; } = new List<Node<T>>();

        // Graph Constructor
        public Graph(bool isDirected, bool isWeighted)
        {
            _isDirected = isDirected;
            _isWeighted = isWeighted;
        }

        // Methods
        public Edge<T> this[int from, int to]
        {
            get
            {
                Node<T> nodeFrom = Verticies[from];
                Node<T> nodeTo = Verticies[to];
                int i = nodeFrom.Neighbors.IndexOf(nodeTo);
                if (i >= 0)
                {
                    Edge<T> edge = new Edge<T>()
                    {
                        From = nodeFrom,
                        To = nodeTo,
                        Weight = i < nodeFrom.Weights.Count
                            ? nodeFrom.Weights[i] : 0
                    };
                    return edge;
                }

                return null;
            }
        }

        public Node<T> AddVertex(T value)
        {
            Node<T> node = new Node<T>() { Data = value };
            Verticies.Add(node);
            UpdateIndices();
            return node;
        }

        public void RemoveVertex(Node<T> nodeToRemove)
        {
            Verticies.Remove(nodeToRemove);
            UpdateIndices();
            foreach (Node<T> node in Verticies)
            {
                RemoveEdge(node, nodeToRemove);
            }
        }

        public void AddEdge(Node<T> from, Node<T> to, int weight = 0)
        {
            from.Neighbors.Add(to);
            if (_isWeighted)
            {
                from.Weights.Add(weight);
            }

            if (!_isDirected)
            {
                to.Neighbors.Add(from);
                if (_isWeighted)
                {
                    to.Weights.Add(weight);
                }
            }
        }

        public void RemoveEdge(Node<T> from, Node<T> to)
        {
            int index = from.Neighbors.FindIndex(n => n == to);
            if (index >= 0)
            {
                from.Neighbors.RemoveAt(index);
                if (_isWeighted)
                {
                    from.Weights.RemoveAt(index);
                }
            }
        }

        public List<Edge<T>> GetEdges()
        {
            List<Edge<T>> edges = new List<Edge<T>>();
            foreach (Node<T> from in Verticies)
            {
                for (int i = 0; i < from.Neighbors.Count; i++)
                {
                    Edge<T> edge = new Edge<T>()
                    {
                        From = from,
                        To = from.Neighbors[i],
                        Weight = i < from.Weights.Count
                            ? from.Weights[i] : 0
                    };
                    edges.Add(edge);
                }
            }
            return edges;
        }

        private void UpdateIndices()
        {
            int i = 0;
            Verticies.ForEach(n => n.Index = i++);
        }

        private void Fill<Q>(Q[] array, Q value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }
        }

        public List<Edge<T>> GetShortestPathDijkstra(Node<T> source, Node<T> target)
        {
            int[] previous = new int[Verticies.Count];
            Fill(previous, -1);

            int[] distances = new int[Verticies.Count];
            Fill(distances, int.MaxValue);
            distances[source.Index] = 0;

            SimplePriorityQueue<Node<T>> nodes = new SimplePriorityQueue<Node<T>>();
            for (int i = 0; i < Verticies.Count; i++)
            {
                nodes.Enqueue(Verticies[i], distances[i]);
            }

            while (nodes.Count != 0)
            {
                Node<T> node = nodes.Dequeue();
                for (int i = 0; i < node.Neighbors.Count; i++)
                {
                    Node<T> neighbor = node.Neighbors[i];
                    int weight = i < node.Weights.Count
                        ? node.Weights[i] : 0;
                    int weightTotal = distances[node.Index] + weight;

                    if (distances[neighbor.Index] > weightTotal)
                    {
                        distances[neighbor.Index] = weightTotal;
                        previous[neighbor.Index] = node.Index;
                        nodes.UpdatePriority(neighbor,
                            distances[neighbor.Index]);
                    }
                }
            }

            List<int> indices = new List<int>();
            int index = target.Index;
            while (index >= 0)
            {
                indices.Add(index);
                index = previous[index];
            }

            indices.Reverse();
            List<Edge<T>> result = new List<Edge<T>>();
            for (int i = 0; i < indices.Count - 1; i++)
            {
                Edge<T> edge = this[indices[i], indices[i + 1]];
                result.Add(edge);
            }
            return result;
        }
    }
}
