using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.UndirectedGraph_DFS_BFS
{
    public class Graph
    {
        #region CreateGraph
        int V;
        List<int>[] Adj;

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
            Adj[v].Add(u);
        }
        #endregion

        #region UsingDFS
        //T:O(V+E)
        public bool IsCyclic_DFS()
        {
            bool[] visited = new bool[V];

            for (int i = 0; i < V; ++i)
                if (visited[i] == false && IsCyclicUtil_DFS(i, visited, -1) == true)
                    return true;

            return false;
        }

        private bool IsCyclicUtil_DFS(int u, bool[] visited, int parent)
        {
            visited[u] = true;

            foreach (var v in Adj[u])
            {
                if (visited[v] == false)
                {
                    if (IsCyclicUtil_DFS(v, visited, u) == true)
                        return true;
                }
                else if (v != parent)
                    return true;
            }

            return false;
        }
        #endregion

        #region UsingBFS
        //T:O(V+E)
        public bool IsCyclic_BFS()
        {
            bool[] visited = new bool[V];
            int[] parent = new int[V];

            for (int i = 0; i < V; ++i)
                parent[i] = -1;

            for(int i = 0; i < V; ++i)
            {
                if (visited[i] == false && IsCyclicUtil_BFS(i, visited, parent) == true)
                    return true;
            }

            return false;
        }

        private bool IsCyclicUtil_BFS(int s, bool[] visited, int[] parent)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(s);
            visited[s] = true;
            parent[s] = -1;

            while(queue.Any() == true)
            {
                int u = queue.Dequeue();

                foreach(var v in Adj[u])
                {
                    if (visited[v] == false)
                    {
                        queue.Enqueue(v);
                        visited[v] = true;
                        parent[v] = u;
                    }
                    else if (v != parent[u])
                        return true;
                }
            }

            return false;
        }
        #endregion
    }

}
