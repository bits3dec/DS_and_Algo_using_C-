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
            Graph graph = new Graph(5);
            graph.AddEdge(1, 0);
            graph.AddEdge(0, 2);
            graph.AddEdge(2, 1);
            graph.AddEdge(1, 3);
            graph.AddEdge(3, 4);

            Console.WriteLine("Following are the strongly connected components in the given graph:");
            SCCUtility.PrintSCCs(graph);

            Console.ReadKey();
        }
    }
}
