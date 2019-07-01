using System;
namespace CSC395_Module5
{
    public class GraphBuilder
    {
        internal static void ClassExample()
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
        }

        internal static void UndirectedUnweighted()
        {
            // To create a Unweighted, undirected graph, pass false, false parameters.
            Graph_AdjacencyList<int> graph = new Graph_AdjacencyList<int>(false, false);

            // To add Verticies, specify a node with a label and index number.
            Node<int> Alice = graph.AddVertex(1);
            Node<int> Bob = graph.AddVertex(2);
            Node<int> Carl = graph.AddVertex(3);
            Node<int> Antonio = graph.AddVertex(4);
            Node<int> Ann = graph.AddVertex(5);
            Node<int> Terrence = graph.AddVertex(6);
            Node<int> Alex = graph.AddVertex(7);
            Node<int> Robert = graph.AddVertex(8);

            // To add connections, specify the from and to
            // labels of the connecting nodes.
            graph.AddEdge(Alice, Bob);
            graph.AddEdge(Alice, Carl);
            graph.AddEdge(Bob, Antonio);
            graph.AddEdge(Carl, Antonio);
            graph.AddEdge(Antonio, Ann);
            graph.AddEdge(Ann, Terrence);
            graph.AddEdge(Ann, Alex);
            graph.AddEdge(Ann, Robert);
            graph.AddEdge(Terrence, Alex);
            graph.AddEdge(Alex, Robert);

            // To print the edges
            Console.WriteLine(Alice.Data.ToString());
            Console.WriteLine(Bob.Neighbors);
            Console.WriteLine(Carl.Neighbors);
            Console.WriteLine(Antonio.Neighbors);
            Console.WriteLine(Ann.Neighbors);
            Console.WriteLine(Terrence.Neighbors);
            Console.WriteLine(Alex.Neighbors);
            Console.WriteLine(Robert.Neighbors);

            // To print the verticies

        }
    }
}
