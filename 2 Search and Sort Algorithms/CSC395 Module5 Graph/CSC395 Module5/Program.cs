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
            Graph myGraph = new Graph();

            myGraph.AddVertex("Alice");
            myGraph.AddVertex("Bob");
            myGraph.AddVertex("Carl");



            myGraph.AddEdge("Alice", "Carl", 2019);
            myGraph.AddEdge("Alice", "Alice");

            myGraph.PrintVertices();
            Console.WriteLine();
            myGraph.PrintEdges2();



            myGraph.RemoveVertex("Carl");


            myGraph.PrintVertices();
            Console.WriteLine();
            myGraph.PrintEdges2();
        }
    }
}
