using System;
using System.Collections.Generic;

namespace CSC395_Module5
{
    public class Graph_AdjacencyMatrix
    {
        class Node
        {
            public string Label { get; set; }
            //public bool wasVisited;
            public Node(string newLbl)
            {
                Label = newLbl;
            }
        }

        //data
        //Graph = {Vertices, Edges}
        List<Node> vertices;
        int[,] edges;//we'll use this for the adjacency matrix
        int MAX_SIZE;

        //methods
        //print vertices
        public void PrintVertices()
        {
            Console.WriteLine();
            Console.WriteLine("Printing the vertices ...");
            foreach (var node in vertices)
                Console.Write(node.Label + " ");
        }

        //print edges
        public void PrintEdges()
        {
            Console.WriteLine();
            Console.WriteLine("Printing the edges ...");
            for (int i = 0; i < vertices.Count; i++)
            {
                //print all rows
                Console.WriteLine();//start on a new line
                for (int j = 0; j < vertices.Count; j++)
                {
                    Console.Write(edges[i, j] + "\t");
                }
            }
        }

        //print edges
        public void PrintEdges2()
        {
            Console.WriteLine();
            Console.WriteLine("Printing the edges ...");

            Console.Write("\t");
            foreach (var node in vertices)
                Console.Write(node.Label + "\t");
            Console.WriteLine();
            Console.Write("\t");
            foreach (var node in vertices)
                Console.Write("----\t");

            for (int i = 0; i < vertices.Count; i++)
            {
                //print all rows
                Console.WriteLine();//start on a new line
                Console.Write(vertices[i].Label + "\t|");
                for (int j = 0; j < vertices.Count; j++)
                {
                    Console.Write(edges[i, j] + "\t");
                }
            }
        }
        //add vertex
        public void AddVertex(string newLabel)
        {
            if (vertices.Count < MAX_SIZE)
            {
                //Node newNode = new Node(newLabel);
                //vertices.Add(newNode);
                vertices.Add(new Node(newLabel));

                //you may want to make sure to add 0s in row = vertices.count-1 and col  = vertices.count-1
            }
        }

        //add edge
        public void AddEdge(string A, string B, int weight = 1) //adds an edge between A and B
        {
            int i = -1;
            for (int k = 0; k < vertices.Count; k++)
                if (vertices[k].Label.Equals(A))
                {
                    i = k;
                    break;
                }

            int j = -1;
            for (int k = 0; k < vertices.Count; k++)
                if (vertices[k].Label.Equals(B))
                {
                    j = k;
                    break;
                }

            //sanity check
            if (i == -1 || j == -1)
                return;

            edges[i, j] = weight;

            edges[j, i] = weight; //for undirected:
        }

        //remove edge
        public void RemoveEdge(string A, string B)
        {
            AddEdge(A, B, 0);
        }

        //remove vertex
        public void RemoveVertex(string labelA)
        {
            //find the position of labelA in vertices
            int i = -1;
            for (int k = 0; k < vertices.Count; k++)
                if (vertices[k].Label.Equals(labelA))
                {
                    i = k;//found it
                    break;
                }

            if (i == -1)//labelA not found
                return;


            //remove the node in the ith position in the list vertices
            vertices.RemoveAt(i);

            //remove column i from the adjacency matrix: edges
            for (int col = i + 1; col <= vertices.Count; col++)
            {
                for (int row = 0; row <= vertices.Count; row++)
                    //shift edges[col,row] to the left one position
                    edges[col - 1, row] = edges[col, row];
            }

            //remove row i from the adjacency matrix: edges
            for (int row = i + 1; row <= vertices.Count; row++)
            {
                for (int col = 0; col <= vertices.Count; col++)
                    //shift edges[col,row] up one position
                    edges[col, row - 1] = edges[col, row];
            }
        }

        //ctor
        public Graph_AdjacencyMatrix()
        {
            vertices = new List<Node>();

            MAX_SIZE = 20;//this is the max numb of vertices allowed in the graph - this can be extended later ...
            edges = new int[MAX_SIZE, MAX_SIZE];//allocates a 2D block of size MAX_SIZE^2

        }

    }
}
