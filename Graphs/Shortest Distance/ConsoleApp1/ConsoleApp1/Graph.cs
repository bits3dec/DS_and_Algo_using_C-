using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Graph
    {
        int V;
        List<int>[] adj;
        int[,] weights;

        public Graph(int v, int[,] weights)
        {
            this.V = v;

            adj = new List<int>[V];
            for (int i = 0; i < V; ++i)
                adj[i] = new List<int>();

            this.weights = weights;
        }

        public void AddEdge(int u, int v)
        {
            adj[u].Add(v);
        }

        //Calculates shortest distance for negative edges
        //T:O(E*V), where E = No. of edges, V = No. of vertices
        public void BellmanFord_ShortestDistance(int s)
        {
            int[] distances = new int[V];
            int[] paths = new int[V];

            Queue<int> queue = new Queue<int>();

            for(int i = 0; i < V; ++i)
                distances[i] = Int32.MaxValue;
            for(int i = 0; i < V; ++i)
                paths[i] = -1;

            distances[s] = 0;
            paths[s] = s;
            queue.Enqueue(s);

            while(queue.Any() == true)
            {
                int u = queue.Dequeue();

                foreach(var v in adj[u])
                {
                    int newDistance = distances[u] + weights[u,v];
                    if(newDistance < distances[v])
                    {
                        distances[v] = newDistance;
                        paths[v] = u;

                        if (queue.Contains(v) == false)
                            queue.Enqueue(v);
                    }
                }
            }

            PrintResult(distances, paths);
        }

        private void PrintResult(int[] distances, int[] paths)
        {
            Console.WriteLine("Node" + "\t"+ "Distance" + "\t" + "Path");
            for(int i = 0; i < V; ++i)
                Console.WriteLine(i + "\t"+ distances[i] + "\t\t" + paths[i]);
        }
    }
}
