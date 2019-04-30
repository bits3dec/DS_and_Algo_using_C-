using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EulerianUtility
    {
        public static void CheckEulerian(Graph graph)
        {
            if (IsConnected(graph) == false)
            {
                Console.WriteLine("Non Eulerian");
                return;
            }

            int odd = 0;
            for (int i = 0; i < graph.V; ++i)
            {
                if (graph.Adj[i].Count % 2 == 1)
                    ++odd;
            }

            if (odd == 2)
                Console.WriteLine("Semi-Eulerian (Eulerian Path)");
            else if (odd == 0)
                Console.WriteLine("Eulerian (Eulerian Cycle)");
            else
                Console.WriteLine("Non Eulerian");
        }

        //DFS traversal
        private static void DFS(Graph graph, int u, bool[] visited)
        {
            visited[u] = true;

            foreach(var v in graph.Adj[u])
            {
                if (visited[v] == false)
                    DFS(graph, v, visited);
            }
        }

        //Check if all non-zero degree vertices are connected since we are interested only in Edges
        private static bool IsConnected(Graph graph)
        {
            int u = -1;
            int V = graph.V;

            //find a vertex with non-zero degree since we are interested for only non-zero degree vertices for Eulerian
            for (u = 0; u < V; ++u)
            { 
                if (graph.Adj[u].Count > 0)
                    break;
            }

            if (u == V)
                return true; //return true when all the vertices are disconnected

            bool[] visited = new bool[V];
            DFS(graph, u, visited);

            //check if all non-zero degree vertices are visited
            for (int i = 0; i < V; ++i)
            {
                if (visited[i] == false && graph.Adj[i].Count > 0)
                    return false;
            }

            return true;
        }

        
    }
}
