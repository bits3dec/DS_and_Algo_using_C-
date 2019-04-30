using directed = ConsoleApp1.DirectedGraph_RecStack;
using undirected = ConsoleApp1.UndirectedGraph_DisjointSets;
using undirected2 = ConsoleApp1.UndirectedGraph_DFS_BFS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.UndirectedGraph_DFS_BFS;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///* Directed Graph: Using Recursion stack*/
            //Graph graph = new Graph(4);
            //graph.AddEdge(0, 1);
            //graph.AddEdge(0, 2);
            //graph.AddEdge(1, 2);
            //graph.AddEdge(2, 0);
            //graph.AddEdge(2, 3);
            //graph.AddEdge(3, 3);
            //if(graph.IsCyclic() == true)
            //    Console.WriteLine("The graph contains cycle");
            //else
            //    Console.WriteLine("The graph doesnot contain cycle");


            ///* Undirected Graph: Using Disjoint Set */
            //int V = 3, E = 3;
            //undirected.Graph graph = new undirected.Graph(V, E);
            //// add edge 0-1 
            //graph.Edges[0].Src = 0;
            //graph.Edges[0].Dest = 1;
            //// add edge 1-2 
            //graph.Edges[1].Src = 1;
            //graph.Edges[1].Dest = 2;
            //// add edge 0-2 
            //graph.Edges[2].Src = 0;
            //graph.Edges[2].Dest = 2;
            //if (graph.IsCyclic() == true)
            //    Console.WriteLine("The graph contains cycle");
            //else
            //    Console.WriteLine("The graph doesnot contain cycle");


            ///* Undirected Graph: Using DFS_BFS */
            //undirected2.Graph g1 = new undirected2.Graph(5);
            //g1.AddEdge(1, 0);
            //g1.AddEdge(0, 2);
            //g1.AddEdge(2, 0);
            //g1.AddEdge(0, 3);
            //g1.AddEdge(3, 4);
            //if (g1.IsCyclic_DFS() == true)
            //    Console.WriteLine("DFS: The graph contains cycle");
            //else
            //    Console.WriteLine("DFS: The graph doesnot contain cycle");
            //if (g1.IsCyclic_BFS() == true)
            //    Console.WriteLine("BFS: The graph contains cycle");
            //else
            //    Console.WriteLine("BFS: The graph doesnot contain cycle");

            //undirected2.Graph g2 = new undirected2.Graph(3);
            //g2.AddEdge(0, 1);
            //g2.AddEdge(1, 2);
            //if (g2.IsCyclic_DFS() == true)
            //    Console.WriteLine("DFS: The graph contains cycle");
            //else
            //    Console.WriteLine("DFS: The graph doesnot contain cycle");
            //if (g2.IsCyclic_BFS() == true)
            //    Console.WriteLine("BFS: The graph contains cycle");
            //else
            //    Console.WriteLine("BFS: The graph doesnot contain cycle");

            Console.ReadKey();
        }
    }
}
