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
            Graph_AdjacencyList<String> graph = new Graph_AdjacencyList<String>(false, false);

            // To add Verticies, specify a node with a label and index number.
            Node<String> Alice = graph.AddVertex("Alice");
            Node<String> Bob = graph.AddVertex("Bob");
            Node<String> Carl = graph.AddVertex("Carl");
            Node<String> Antonio = graph.AddVertex("Antonio");
            Node<String> Ann = graph.AddVertex("Ann");
            Node<String> Terrence = graph.AddVertex("Terrence");
            Node<String> Alex = graph.AddVertex("Alex");
            Node<String> Robert = graph.AddVertex("Robert");

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

            // To print the verticies from the graph.
            graph.GetEachVertex();

            // To print the edges.
            Console.WriteLine("Robert's neighbors are: ");
            foreach (var neighbor in Robert.Neighbors)
            {

                //Console.Write(neighbor.Index.ToString() + ", ");
                Console.WriteLine(neighbor.GetNeighbors());
            }


        }
    }
}
