using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SCCUtility
    {
        public static void PrintSCCs(Graph graph)
        {
            int V = graph.V;
            bool[] visited = new bool[V];
            Stack<int> stack = new Stack<int>();

            //Fill the vertices in the stack according to their finishing time
            for (int i = 0; i < V; ++i)
                if (visited[i] == false)
                    FillOrder(graph, i, visited, stack);

            //GetTranspose
            Graph graphTranspose = GetTranspose(graph);

            //Reset the visited array for the 2nd DFS traversal
            for (int i = 0; i < V; ++i)
                visited[i] = false;

            //DFSUtil
            while(stack.Any() == true)
            {
                int v = stack.Pop();

                if(visited[v] == false)
                {
                    DFSUtil(graphTranspose, v, visited);
                    Console.Write("\n");
                }
            }
        }

        private static void FillOrder(Graph g, int u, bool[] visited, Stack<int> stack)
        {
            visited[u] = true;

            foreach (var v in g.Adj[u])
                if (visited[v] == false)
                    FillOrder(g, v, visited, stack);

            stack.Push(u);
        }

        private static Graph GetTranspose(Graph g)
        {
            Graph gTranspose = new Graph(g.V);

            for(int i = 0; i < g.V; ++i)
            {
                foreach (var v in g.Adj[i])
                    gTranspose.Adj[v].Add(i);
            }

            return gTranspose;
        }

        private static void DFSUtil(Graph g, int u, bool[] visited)
        {
            visited[u] = true;
            Console.Write(u + " ");

            foreach (var v in g.Adj[u])
                if (visited[v] == false)
                    DFSUtil(g, v, visited);
        }
    }
}
