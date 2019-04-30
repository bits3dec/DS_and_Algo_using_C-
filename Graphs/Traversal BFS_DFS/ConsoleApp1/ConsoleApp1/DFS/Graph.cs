using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DFS
{
    public class Graph
    {
        int V;
        List<int>[] adj;

        public Graph(int v)
        {
            this.V = v;
            adj = new List<int>[V];
            for(int i = 0; i < V; ++i)
                adj[i] = new List<int>();
        }

        public void AddEdge(int u, int v)
        {
            adj[u].Add(v);
        }

        public void DFS(int s)
        {
            bool[] visited = new bool[V];

            for (int i = 0; i < V; ++i)
                if (visited[i] == false)
                    DFSUtil(i, visited);
        }

        private void DFSUtil(int u, bool[] visited)
        {
            Console.Write(u + " ");
            visited[u] = true;

            foreach(var v in adj[u])
            {
                if (visited[v] == false)
                    DFSUtil(v, visited);
            }
        }
            
    }
}
