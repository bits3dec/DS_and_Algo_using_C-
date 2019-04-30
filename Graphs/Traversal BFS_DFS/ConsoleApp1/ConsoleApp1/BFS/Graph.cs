using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BFS
{
    public class Graph
    {
        int V;
        List<int>[] adj;

        public Graph(int v)
        {
            this.V = v;
            adj = new List<int>[V];
            for (int i = 0; i < V; ++i)
                adj[i] = new List<int>();
        }

        public void AddEdge(int u, int v)
        {
            adj[u].Add(v);
            //adj[v].Add(u); //if undirected graph
        }

        public void BFS(int s)
        {
            bool[] visited = new bool[V];
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(s);
            visited[s] = true;

            while(queue.Any() == true)
            {
                int u = queue.Dequeue();
                Console.Write(u + " ");

                foreach(var v in adj[u])
                {
                    if (visited[v] == false)
                    {
                        queue.Enqueue(v);
                        visited[v] = true;
                    }
                }
            }
        }
    }
}
