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
            int[,] weights = { {0, -1, 4, 0, 0},
                               {0, 0, 3, 2, 2},
                               {0, 0, 0, 0, 0},
                               {0, 1, 5, 0, 0},
                               {0, 0, 0, -3, 0}
                             };
            Graph graph = new Graph(5, weights);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(1, 4);
            graph.AddEdge(3, 2);
            graph.AddEdge(3, 1);
            graph.AddEdge(4, 3);

            graph.BellmanFord_ShortestDistance(0);

            Console.ReadKey();

        }
    }
}
