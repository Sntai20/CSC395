using System;
using System.Collections.Generic;

namespace CSC395_Module5
{
    /// <summary>
    /// To creat a graph we need to have vertices and edges.
    /// Nodes are used for the vertices.
    /// Edges represent connections to neighbors.
    /// </summary>
    public class Graph_AdjacencyList<T>
    {
        /// <summary>
        /// To store the adjacent neighbors we need a list in each node.
        /// Example. The Alice node stores a list of 
        /// </summary>
        

        // Use an Adjacency List instead of an Adjacency Matrix.
        // For the adjacency list use an array-lists.
        // Graph_AdjacencyMatrix
        // Graph_AdjacencyList

        //data
        //Graph = {Vertices, Edges}
        //List<Node<T>> vertices { get; set; } = new List<Node<T>>();
        List<Node<T>> vertices = new List<Node<T>>();
        
        //Array<List>
        //int[,] edges;//we'll use this for the adjacency matrix
        //List<string> Neighbors;


        //int MAX_SIZE;

        //methods
        //print vertices
        public void PrintVertices()
        {
            Console.WriteLine();
            Console.WriteLine("Printing the vertices ...");
            foreach (var node in vertices)
            {
                Console.Write(node.Label + " ");
                //node.Neighbors.ToString;
                //foreach (var neighbor in node)
                //{
                //    Console.WriteLine(neighbor);
                //    //foreach (var match in neighbor)
                //    //{
                //    //    Console.WriteLine(match);
                //    //}
                    
                //}
            }
        }

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

        //add vertex
        public void AddVertex(T newLabel)
        {
            //if (vertices.Count < MAX_SIZE)
            //{
            Node<T> newNode = new Node<T>(newLabel);
            vertices.Add(newNode);
            //vertices.Add(new Node(newLabel));

            //you may want to make sure to add 0s in row = vertices.count-1 and col  = vertices.count-1
            //}
        }

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
    

        public void AddEdge(string nodeFrom, string nodeTo)
        {
            // To create an edge, use the edge class.
            //Edge<T> newEdge = new Edge<T>();
            //List<Node<T>> Neighbors = new List<Node<T>>();
            vertices.Insert()

            Node<T> edgeFrom;
            Node<T> edgeTo;


            foreach (var neighbor in vertices)
            {
                neighbor.addNeighbor(nodeFrom);
                if (neighbor == null)
                {
                    Console.WriteLine("Node to not found");
                    break;
                }
                else if (string.Equals(neighbor.Label, nodeFrom))
                {
                    edgeFrom = neighbor;
                    Console.WriteLine($"{edgeFrom} found! What's next?");
                    edgeFrom.addNeighbor(edgeTo);
                    //return edgeFrom;
                }
                else
                    Console.WriteLine("not found");
            }

            foreach (var neighbor in vertices)
            {
                if (neighbor == null)
                {
                    Console.WriteLine("Node to not found");
                    break;
                }
                else if (string.Equals(neighbor.Label, nodeTo))
                {
                    //Node<T> edgeTo;
                    edgeTo = neighbor;
                    Console.WriteLine($"{neighbor} found! What's next?");
                    //return edgeTo;

                }
                else
                    Console.WriteLine("not found");


                //var edgeTo = string.Compare(neighbor.Label, nodeTo);
                //if (edgeFrom(neighbor))
                //{
                //    //Neighbors.Add(nodeTo);
                //    neighbor.addMyNeighbor(edgeTo);
                //    Console.WriteLine(nodeFrom.myNeighbors);
                //}
            }
            //return null;
            //edgeFrom.addMyNeighbor(edgeTo);
            //edgeTo.addMyNeighbor(edgeFrom)

            //Node<T> nodeFrom;
            //Node<T> nodeTo;
            //from = nodeFrom;
            //Node<T>. nodeFrom = from;
            //public Node<T> to;
            //int weight = 1;
            //AddEdgeHelper(from, to, weight, vertices);

            // sort of worked last time.
            //Console.WriteLine("Printing the vertices ...");
            //foreach (var node in vertices)
            //{

            //    // Add the neighbor node, if the node label matches
            //    Console.WriteLine(node.Label);
            //    if (node.Label.Equals(nodeFrom))
            //    {
            //        Console.WriteLine("nodeTo matched add the to node to neighbor");
            //        //nodeFrom = node;
            //        Edge<T> myEdge = new Edge<T>();
            //        //Neighbors.Add(nodeTo);
            //        Console.WriteLine($"{nodeFrom.Label} added");

            //    }

            //if (!node.Label.Equals(to))
            //{
            //    Console.WriteLine("to matched add the from node to neighbor");
            //    nodeTo = node;
            //    //node.Neighbors.Add(nodeTo);
            //    //Console.WriteLine($"{node.Neighbors} added");
            //}

            //}

        }

        
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

        //ctor
        public Graph_AdjacencyList()
        {
            vertices = new List<Node<T>>();

            //MAX_SIZE = 20;//this is the max numb of vertices allowed in the graph - this can be extended later ...
            //edges = new int[MAX_SIZE, MAX_SIZE];//allocates a 2D block of size MAX_SIZE^2
            //edges = new List<string>(Neighbor);
            //edges = new List<
        }

    }
}
