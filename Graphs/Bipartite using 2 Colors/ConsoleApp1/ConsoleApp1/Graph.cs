using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Graph
    {
        public int V;
        List<int>[] Adj;

        public Graph(int v)
        {
            this.V = v;
            Adj = new List<int>[V];
            for (int i = 0; i < V; ++i)
                Adj[i] = new List<int>();
        }

        public void AddEdge(int u, int v)
        {
            Adj[u].Add(v);
            Adj[v].Add(u);
        }

        public bool IsBipartite()
        {
            int[] colors = new int[V];

            for (int i = 0; i < V; ++i)
                colors[i] = -1;

            Queue<int> queue = new Queue<int>();

            int s = 0;
            queue.Enqueue(s);
            colors[s] = 0;

            while(queue.Any() == true)
            {
                int u = queue.Dequeue();

                foreach(var v in Adj[u])
                {
                    if (colors[v] == -1)
                    {
                        queue.Enqueue(v);
                        colors[v] = 1 - colors[u];
                    }
                    else if (colors[v] == colors[u])
                        return false;
                }
            }

            return true;

        }
    }
}
