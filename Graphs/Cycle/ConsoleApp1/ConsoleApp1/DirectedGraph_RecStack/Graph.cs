using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DirectedGraph_RecStack
{
    public class Graph
    {
        public int V;
        public List<int>[] Adj;

        public Graph(int V)
        {
            this.V = V;
            Adj = new List<int>[V];
            for (int i = 0; i < V; ++i)
                Adj[i] = new List<int>();
        }

        public void AddEdge(int u, int v)
        {
            Adj[u].Add(v);
        }

        public bool IsCyclic()
        {
            bool[] visited = new bool[V];
            bool[] recStack = new bool[V];

            for(int i = 0; i < V; ++i)
            {
                if (visited[i] == false && IsCyclicUtil(i, visited, recStack) == true)
                    return true;
            }

            return false;
        }

        private bool IsCyclicUtil(int u, bool[] visited, bool[] recStack)
        {
            visited[u] = true;
            recStack[u] = true;

            foreach(var v in Adj[u])
            {
                if(visited[v] == false)
                {
                    if (IsCyclicUtil(v, visited, recStack) == true)
                        return true;
                }
                else
                {
                    if (recStack[v] == true)
                        return true;
                }
            }
            recStack[u] = false;

            return false;
        }
    }
}
