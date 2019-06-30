using System;
using System.Collections.Generic;
namespace CSC395_Module5
{
    public class GraphBuilder
    {
        internal static void UndirectedUnweighted()
        {
            // Undirected and unweighted edges
            Graph<int> graph = new Graph<int>(false, false);

            Node<int> n1 = graph.AddVertex(1);
            Node<int> n2 = graph.AddVertex(2);
            Node<int> n3 = graph.AddVertex(3);
            Node<int> n4 = graph.AddVertex(4);
            Node<int> n5 = graph.AddVertex(5);
            Node<int> n6 = graph.AddVertex(6);
            Node<int> n7 = graph.AddVertex(7);
            Node<int> n8 = graph.AddVertex(8);

            graph.AddEdge(n1, n2);
            graph.AddEdge(n1, n3);
            graph.AddEdge(n2, n4);
            graph.AddEdge(n3, n4);
            graph.AddEdge(n4, n5);
            graph.AddEdge(n5, n6);
            graph.AddEdge(n5, n7);
            graph.AddEdge(n5, n8);
            graph.AddEdge(n6, n7);
            graph.AddEdge(n7, n8);
        }

        internal static void DirectedUnweighted()
        {
            Graph<int> graph = new Graph<int>(true, true);

            Node<int> n1 = graph.AddVertex(1);
            Node<int> n2 = graph.AddVertex(2);
            Node<int> n3 = graph.AddVertex(3);
            Node<int> n4 = graph.AddVertex(4);
            Node<int> n5 = graph.AddVertex(5);
            Node<int> n6 = graph.AddVertex(6);
            Node<int> n7 = graph.AddVertex(7);
            Node<int> n8 = graph.AddVertex(8);

            graph.AddEdge(n1, n2, 9);
            graph.AddEdge(n1, n3, 5);
            graph.AddEdge(n2, n1, 3);
            graph.AddEdge(n2, n4, 18);
            graph.AddEdge(n3, n4, 12);
            graph.AddEdge(n4, n2, 2);
            graph.AddEdge(n4, n8, 8);
            graph.AddEdge(n5, n4, 9);
            graph.AddEdge(n5, n6, 2);
            graph.AddEdge(n5, n7, 5);
            graph.AddEdge(n5, n8, 3);
            graph.AddEdge(n6, n7, 1);
            graph.AddEdge(n7, n5, 4);
            graph.AddEdge(n7, n8, 6);
            graph.AddEdge(n8, n5, 3);
        }

        internal static void Dijkstra()
        {
            Graph<int> graph = new Graph<int>(true, true);
            Node<int> n1 = graph.AddVertex(1);
            Node<int> n2 = graph.AddVertex(2);
            Node<int> n3 = graph.AddVertex(3);
            Node<int> n4 = graph.AddVertex(4);
            Node<int> n5 = graph.AddVertex(5);
            Node<int> n6 = graph.AddVertex(6);
            Node<int> n7 = graph.AddVertex(7);
            Node<int> n8 = graph.AddVertex(8);
            graph.AddEdge(n1, n2, 9);
            graph.AddEdge(n1, n3, 5);
            graph.AddEdge(n2, n1, 3);
            graph.AddEdge(n2, n4, 18);
            graph.AddEdge(n3, n4, 12);
            graph.AddEdge(n4, n2, 2);
            graph.AddEdge(n4, n8, 8);
            graph.AddEdge(n5, n8, 3);
            graph.AddEdge(n5, n4, 9);
            graph.AddEdge(n5, n6, 2);
            graph.AddEdge(n5, n7, 5);
            graph.AddEdge(n6, n7, 1);
            graph.AddEdge(n7, n5, 4);
            graph.AddEdge(n7, n8, 6);
            graph.AddEdge(n8, n5, 3);
            List<Edge<int>> path = graph.GetShortestPathDijkstra(n1, n5);
            path.ForEach(e => Console.WriteLine(e));
        }

        //Graph myGraph = new Graph();

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

        public GraphBuilder()
        {
        }

        
    }
}
