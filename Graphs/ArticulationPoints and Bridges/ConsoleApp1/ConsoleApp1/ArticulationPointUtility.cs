using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ArticulationPointUtility
    {
        private static int time = 0;

        public static void AP(Graph g)
        {
            int V = g.V;
            bool[] visited = new bool[V];
            int[] parent = new int[V];
            int[] low = new int[V];
            int[] disc = new int[V];
            bool[] ap = new bool[V];

            for (int i = 0; i < V; ++i)
                parent[i] = -1;

            for(int i = 0; i < V; ++i)
                if(visited[i] == false)
                    APUtil(g, i, visited, parent, low, disc, ap);

            for (int i = 0; i < V; ++i)
                if (ap[i] == true)
                    Console.Write(i + " ");
        }

        private static void APUtil(Graph g, int u, bool[] visited, int[] parent, int[] low, int[] disc, bool[] ap)
        {
            visited[u] = true;

            int children = 0;
            time++;
            low[u] = disc[u] = time;

            foreach(var v in g.Adj[u])
            {
                if(visited[v] == false)
                {
                    children++;
                    parent[v] = u;

                    APUtil(g, v, visited, parent, low, disc, ap);

                    low[u] = Math.Min(low[u], low[v]);

                    if (parent[u] == -1 && children >= 2)
                        ap[u] = true;
                    else if (parent[u] != -1 && disc[u] <= low[v])
                        ap[u] = true;
                }
                else if(v != parent[u])
                {
                    low[u] = Math.Min(low[u], disc[v]);
                }
            }

        }
    }
}
