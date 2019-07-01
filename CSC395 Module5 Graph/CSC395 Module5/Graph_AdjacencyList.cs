using System;
using System.Collections.Generic;

namespace CSC395_Module5
{
    /// <summary>
    /// To create a graph we need to have vertices and edges.
    /// Node is another name for a vertex.
    /// Edges represent connections to neighbors.
    /// </summary>
    public class Graph_AdjacencyList<T>
    {
        // Data
        private bool _isDirected = false;
        private bool _isWeighted = false;

        /// <summary>
        /// Graphs contain a collection of vertices and associated edges.
        /// Graph = {Vertices, Edges}
        /// </summary>
        List<Node<T>> Verticies { get; set; } = new List<Node<T>>();

        // Graph Constructor
        public Graph_AdjacencyList(bool isDirected, bool isWeighted)
        {
            _isDirected = isDirected;
            _isWeighted = isWeighted;
        }

        /// <summary>
        /// Edge Indexer: To return an instance of the generic Edge class,
        /// use the indexer member.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
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

        /// <summary>
        /// To add a vertex to the graph, pass the value of type T that will be stored.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node<T> AddVertex(T value)
        {
            Node<T> node = new Node<T>() { Data = value };
            Verticies.Add(node);
            UpdateIndices();
            return node;
        }

        //add vertex
        //public void AddVertex(T newLabel)
        //{
        //    //if (vertices.Count < MAX_SIZE)
        //    //{
        //    Node<T> newNode = new Node<T>(newLabel);
        //    vertices.Add(newNode);
        //    //vertices.Add(new Node(newLabel));

        //    //you may want to make sure to add 0s in row = vertices.count-1 and col  = vertices.count-1
        //    //}
        //}

        ////add vertex
        //public void AddVertex(string newLabel, List<string> newEdge)
        //{
        //    //if (vertices.Count < MAX_SIZE)
        //    //{
        //    Node newNode = new Node(newLabel,newEdge);
        //    vertices.Add(newNode);
        //    //vertices.Add(new Node(newLabel));

        //    //you may want to make sure to add 0s in row = vertices.count-1 and col  = vertices.count-1
        //    //}
        //}

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

        //add edge
        //public void AddEdge(string A, string B, int weight = 1) //adds an edge between A and B
        //{
        //    int i = -1;
        //    for (int k = 0; k < vertices.Count; k++)
        //        if (vertices[k].Label.Equals(A))
        //        {
        //            i = k;
        //            break;
        //        }

        //    int j = -1;
        //    for (int k = 0; k < vertices.Count; k++)
        //        if (vertices[k].Label.Equals(B))
        //        {
        //            j = k;
        //            break;
        //        }

        //    //sanity check
        //    if (i == -1 || j == -1)
        //        return;

        //    edges[i, j] = weight;

        //    edges[j, i] = weight; //for undirected:
        //}

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

        /// <summary>
        /// To get each vertex from the graph.
        /// </summary>
        /// <returns></returns>
        public void GetEachVertex()
        {
            if (Verticies.Count < 0)
            {
                Console.WriteLine("Verticies not found.");
            }
            if (Verticies.Count > 0)
            {
                foreach (var vertex in Verticies)
                    Console.WriteLine(vertex.ToString());
            }
            Console.WriteLine();
        }

        /// <summary>
        /// To get each edge from a vertex in the graph.
        /// </summary>
        /// <returns></returns>
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


        // To store the adjacent neighbors we need a list in each node.
        //methods
        //print vertices
        //public void PrintVertices()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("Printing the vertices ...");
        //    foreach (var node in Verticies)
        //    {
        //        Console.Write(node.Data + " ");
        //        //node.Neighbors.ToString;
        //        //foreach (var neighbor in node)
        //        //{
        //        //    Console.WriteLine(neighbor);
        //        //    //foreach (var match in neighbor)
        //        //    //{
        //        //    //    Console.WriteLine(match);
        //        //    //}
                    
        //        //}
        //    }
        //}

        ////print edges
        //public void PrintEdges()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("Printing the edges ...");
        //    for (int i = 0; i < vertices.Count; i++)
        //    {
        //        for (int j = 0; j < vertices.Count; j++)
        //        {
        //            Console.WriteLine();
        //        }
        //    }
        //    //for (int i = 0; i < vertices.Count; i++)
        //    //{
        //    //    //print all rows
        //    //    Console.WriteLine();//start on a new line
        //    //    for (int j = 0; j < vertices.Count; j++)
        //    //    {
        //    //        Console.Write(edges[i, j] + "\t");
        //    //    }
        //    //}
        //}

        ////print edges
        //public void PrintEdges2()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("Printing the edges ...");

        //    Console.Write("\t");
        //    foreach (var node in vertices)
        //        Console.Write(node.Label + "\t");
        //    Console.WriteLine();
        //    Console.Write("\t");
        //    foreach (var node in vertices)
        //        Console.Write("----\t");

        //    for (int i = 0; i < vertices.Count; i++)
        //    {
        //        //print all rows
        //        Console.WriteLine();//start on a new line
        //        Console.Write(vertices[i].Label + "\t|");
        //        for (int j = 0; j < vertices.Count; j++)
        //        {
        //            Console.Write(edges[i, j] + "\t");
        //        }
        //    }
        //}

        
        ////remove edge
        //public void RemoveEdge(string A, string B)
        //{
        //    AddEdge(A, B, 0);
        //}

        ////remove vertex
        //public void RemoveVertex(string labelA)
        //{
        //    //find the position of labelA in vertices
        //    int i = -1;
        //    for (int k = 0; k < vertices.Count; k++)
        //        if (vertices[k].Label.Equals(labelA))
        //        {
        //            i = k;//found it
        //            break;
        //        }

        //    if (i == -1)//labelA not found
        //        return;


        //    //remove the node in the ith position in the list vertices
        //    vertices.RemoveAt(i);

        //    //remove column i from the adjacency matrix: edges
        //    for (int col = i + 1; col <= vertices.Count; col++)
        //    {
        //        for (int row = 0; row <= vertices.Count; row++)
        //            //shift edges[col,row] to the left one position
        //            edges[col - 1, row] = edges[col, row];
        //    }

        //    //remove row i from the adjacency matrix: edges
        //    for (int row = i + 1; row <= vertices.Count; row++)
        //    {
        //        for (int col = 0; col <= vertices.Count; col++)
        //            //shift edges[col,row] up one position
        //            edges[col, row - 1] = edges[col, row];
        //    }
        //}

    }
}
