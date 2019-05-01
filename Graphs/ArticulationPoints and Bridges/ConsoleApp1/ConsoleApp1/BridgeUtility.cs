using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BridgeUtility
    {
        private static int time = 0;

        public static void Bridge(Graph g)
        {
            int V = g.V;
            bool[] visited = new bool[V];
            int[] parent = new int[V];
            int[] low = new int[V];
            int[] disc = new int[V];

            for (int i = 0; i < V; ++i)
                parent[i] = -1;

            for (int i = 0; i < V; ++i)
                if (visited[i] == false)
                    BridgeUtil(g, i, visited, parent, low, disc);
        }

        private static void BridgeUtil(Graph g, int u, bool[] visited, int[] parent, int[] low, int[] disc)
        {
            visited[u] = true;

            time++;
            low[u] = disc[u] = time;

            foreach (var v in g.Adj[u])
            {
                if (visited[v] == false)
                {
                    parent[v] = u;

                    BridgeUtil(g, v, visited, parent, low, disc);

                    low[u] = Math.Min(low[u], low[v]);

                    if (disc[u] < low[v])
                        Console.WriteLine(u + "-" + v);
                }
                else if (v != parent[u])
                {
                    low[u] = Math.Min(low[u], disc[v]);
                }
            }

        }
    }
}
