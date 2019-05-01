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
            g1.AddEdge(1, 0);
            g1.AddEdge(0, 2);
            g1.AddEdge(2, 1);
            g1.AddEdge(0, 3);
            g1.AddEdge(3, 4);
            Console.WriteLine("Articulation Points in first graph ");
            ArticulationPointUtility.AP(g1);
            Console.WriteLine("\nBridges in first graph ");
            BridgeUtility.Bridge(g1);
            Console.WriteLine();

            Graph g2 = new Graph(4);
            g2.AddEdge(0, 1);
            g2.AddEdge(1, 2);
            g2.AddEdge(2, 3);
            Console.WriteLine("Articulation Points in second graph ");
            ArticulationPointUtility.AP(g2);
            Console.WriteLine("\nBridges in second graph ");
            BridgeUtility.Bridge(g2);
            Console.WriteLine();

            Graph g3 = new Graph(7);
            g3.AddEdge(0, 1);
            g3.AddEdge(1, 2);
            g3.AddEdge(2, 0);
            g3.AddEdge(1, 3);
            g3.AddEdge(1, 4);
            g3.AddEdge(1, 6);
            g3.AddEdge(3, 5);
            g3.AddEdge(4, 5);
            Console.WriteLine("Articulation Points in third graph ");
            ArticulationPointUtility.AP(g3);
            Console.WriteLine("\nBridges in third graph ");
            BridgeUtility.Bridge(g3);

            Console.ReadKey();
        }
    }
}
