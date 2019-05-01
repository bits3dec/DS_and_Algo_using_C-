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
        public List<int>[] Adj;

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
    }
}
