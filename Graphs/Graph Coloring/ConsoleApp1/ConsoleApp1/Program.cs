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
            Graph g1 = new Graph(5);
            g1.AddEdge(0, 1);
            g1.AddEdge(0, 2);
            g1.AddEdge(1, 2);
            g1.AddEdge(1, 3);
            g1.AddEdge(2, 3);
            g1.AddEdge(3, 4);
            Console.WriteLine("Coloring of graph 1:");
            g1.GraphColoring(3);

            Graph g2 = new Graph(5);
            g2.AddEdge(0, 1);
            g2.AddEdge(0, 2);
            g2.AddEdge(1, 2);
            g2.AddEdge(1, 4);
            g2.AddEdge(2, 4);
            g2.AddEdge(4, 3);
            Console.WriteLine("\nColoring of graph 2:");
            g2.GraphColoring(2);

            Console.ReadKey();
        }
    }
}
