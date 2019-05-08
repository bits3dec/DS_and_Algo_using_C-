using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = 4;
            int E = 5;
            Graph graph = new Graph(V, E);

            // add edge 0-1 
            graph.edges[0].src = 0;
            graph.edges[0].dest = 1;
            graph.edges[0].weight = 10;

            // add edge 0-2 
            graph.edges[1].src = 0;
            graph.edges[1].dest = 2;
            graph.edges[1].weight = 6;

            // add edge 0-3 
            graph.edges[2].src = 0;
            graph.edges[2].dest = 3;
            graph.edges[2].weight = 5;

            // add edge 1-3 
            graph.edges[3].src = 1;
            graph.edges[3].dest = 3;
            graph.edges[3].weight = 15;

            // add edge 2-3 
            graph.edges[4].src = 2;
            graph.edges[4].dest = 3;
            graph.edges[4].weight = 4;

            MinimumSpanningTreeUtility.MST(graph);

            Console.ReadKey();
        }
    }
}
