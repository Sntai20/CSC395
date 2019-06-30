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
            // Undirected and unweighted edges
            GraphBuilder.UndirectedUnweighted();

            // Directed and unweighted Graph
            GraphBuilder.DirectedUnweighted();

            // Graph and SPF
            GraphBuilder.Dijkstra();
        }
    }
}
