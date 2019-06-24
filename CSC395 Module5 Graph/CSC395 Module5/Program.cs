using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC395_Module5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Graph_AdjacencyMatrix myGraph = new Graph_AdjacencyMatrix();

            //myGraph.AddVertex("Alice");
            //myGraph.AddVertex("Bob");
            //myGraph.AddVertex("Carl");



            //myGraph.AddEdge("Alice", "Carl", 2019);
            //myGraph.AddEdge("Alice", "Alice");

            //myGraph.PrintVertices();
            //Console.WriteLine();
            //myGraph.PrintEdges2();



            //myGraph.RemoveVertex("Carl");


            //myGraph.PrintVertices();
            //Console.WriteLine();
            //myGraph.PrintEdges2();


            // 
            Graph_AdjacencyList<string> myALGraph = new Graph_AdjacencyList<string>();

            myALGraph.AddVertex("Alice");
            myALGraph.AddVertex("Bob");
            //myGraph.AddVertex("Carl");


            myALGraph.AddEdge("Alice", "Bob");
            //myALGraph.AddEdge( Alice", "Bob");
            //myGraph.AddEdge("Alice", "Alice");

            myALGraph.PrintVertices();
            Console.WriteLine();
            //myGraph.PrintEdges2();



            //myGraph.RemoveVertex("Carl");


            //myGraph.PrintVertices();
            //Console.WriteLine();
            //myGraph.PrintEdges2();
        }
    }
}
