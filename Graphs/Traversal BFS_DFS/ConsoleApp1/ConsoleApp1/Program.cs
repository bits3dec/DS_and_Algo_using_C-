using BFS = ConsoleApp1.BFS;
using DFS = ConsoleApp1.DFS;
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
            BFS.Graph graph1 = new BFS.Graph(4);
            graph1.AddEdge(0, 1);
            graph1.AddEdge(0, 2);
            graph1.AddEdge(1, 2);
            graph1.AddEdge(2, 0);
            graph1.AddEdge(2, 3);
            graph1.AddEdge(3, 3);
            Console.WriteLine("The Breadth First Traversal of the given graph is:");
            graph1.BFS(2);

            DFS.Graph graph2 = new DFS.Graph(4);
            graph2.AddEdge(0, 1);
            graph2.AddEdge(0, 2);
            graph2.AddEdge(1, 2);
            graph2.AddEdge(2, 0);
            graph2.AddEdge(2, 3);
            graph2.AddEdge(3, 3);
            Console.WriteLine("The Depth First Trraversal of the given graph is:");
            graph2.DFS(2);

            Console.ReadKey();
        }
    }
}
