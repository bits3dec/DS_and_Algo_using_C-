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
            Graph graph1 = new Graph(5);
            graph1.AddEdge(0, 1);
            graph1.AddEdge(1, 2);
            graph1.AddEdge(2, 3);
            graph1.AddEdge(3, 4);
            graph1.AddEdge(4, 0);
            if(graph1.IsBipartite() == true)
                Console.WriteLine("The graph can be colored with 2 colors.\nIt is Bipartite graph");
            else
                Console.WriteLine("The graph cannot be colored with 2 colors.\nIt is not a Bipartite graph");

            Graph graph2 = new Graph(6);
            graph2.AddEdge(0, 1);
            graph2.AddEdge(1, 2);
            graph2.AddEdge(2, 3);
            graph2.AddEdge(3, 4);
            graph2.AddEdge(4, 5);
            graph2.AddEdge(5, 0);
            if (graph2.IsBipartite() == true)
                Console.WriteLine("The graph can be colored with 2 colors.\nIt is Bipartite graph");
            else
                Console.WriteLine("The graph cannot be colored with 2 colors.\nIt is not a Bipartite graph");

            Console.ReadKey();
        }
    }
}
