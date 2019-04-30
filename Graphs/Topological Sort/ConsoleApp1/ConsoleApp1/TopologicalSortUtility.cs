using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TopologicalSortUtility
    {
        public static void TopologicalSort_Indegree(Graph graph)
        {
            //Calculat indegrees of all the nodes
            int[] indegrees = new int[graph.V];
            for(int i = 0; i < graph.V; ++i)
            {
                foreach(var v in graph.Adj[i])
                    indegrees[v]++;
            }

            Queue<int> queue = new Queue<int>();
            int[] topologicalOrder = new int[graph.V];
            int counter = 0;

            //Enqueue all the nodes with zero indegrees
            for(int i = 0; i < graph.V; ++i)
            {
                if (indegrees[i] == 0)
                    queue.Enqueue(i);
            }

            while(queue.Any() == true)
            {
                int u = queue.Dequeue();
                topologicalOrder[counter] = u;
                counter++;

                foreach (var v in graph.Adj[u])
                {
                    //Decreement the indegree of all the corresponding adjacent nodes and enqueue it to the queue if the indegree becomes xero
                    if (--indegrees[v] == 0)
                        queue.Enqueue(v);
                }
            }

            //if the counter is not equal to zero then there exists a cycle
            if(counter != graph.V)
                Console.WriteLine("Graph contains cycle");
            else
            {
                for(int i = 0; i < graph.V; ++i)
                    Console.Write(topologicalOrder[i] + " ");
            }
        }

        public static void TopologicalSort_DFS(Graph graph)
        {
            bool[] visited = new bool[graph.V];
            Stack<int> stack = new Stack<int>();
            
            for (int i = 0; i < graph.V; ++i)
            {
                if (visited[i] == false)
                    DFSUtil(graph, i, visited, stack);
            }

            Print(stack);
        }

        private static void DFSUtil(Graph graph, int u, bool[] visited, Stack<int> stack)
        {
            visited[u] = true;

            foreach(var v in graph.Adj[u])
            {
                if (visited[v] == false)
                    DFSUtil(graph, v, visited, stack);
            }

            stack.Push(u);
        }

        private static void Print(Stack<int> stack)
        {
            while (stack.Any() == true)
            {
                int v = stack.Pop();
                Console.Write(v + " ");
            }
        }
    }
}
