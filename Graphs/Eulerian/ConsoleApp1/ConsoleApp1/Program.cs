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
            EulerianUtility.CheckEulerian(g1);

            Graph g2 = new Graph(5);
            g2.AddEdge(1, 0);
            g2.AddEdge(0, 2);
            g2.AddEdge(2, 1);
            g2.AddEdge(0, 3);
            g2.AddEdge(3, 4);
            g2.AddEdge(4, 0);
            EulerianUtility.CheckEulerian(g2);

            Graph g3 = new Graph(5);
            g3.AddEdge(1, 0);
            g3.AddEdge(0, 2);
            g3.AddEdge(2, 1);
            g3.AddEdge(0, 3);
            g3.AddEdge(3, 4);
            g3.AddEdge(1, 3);
            EulerianUtility.CheckEulerian(g3);

            // Let us create a graph with 3 vertices 
            // connected in the form of cycle 
            Graph g4 = new Graph(3);
            g4.AddEdge(0, 1);
            g4.AddEdge(1, 2);
            g4.AddEdge(2, 0);
            EulerianUtility.CheckEulerian(g4);

            // Let us create a graph with all veritces 
            // with zero degree 
            Graph g5 = new Graph(3);
            EulerianUtility.CheckEulerian(g4);

            Console.ReadKey();
        }
    }
}
