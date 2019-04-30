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
            //Undirected graph
            Adj[u].Add(v);
            Adj[v].Add(u);
        }

        public void GraphColoring(int m)
        {
            int[] colors = new int[V];
            int s = 0;

            if (GraphColoringUtil(s, colors, m) == false)
            {
                Console.WriteLine($"Graph coloring is not possible with {m} colors");
                return;
            }

            PrintColors(colors);
            return;
        }

        private bool GraphColoringUtil(int u, int[] colors, int m)
        {
            //If all vertices are assigned colors then return true
            if (u == V)
                return true;
            
            for(int c = 1; c <= m; ++c)
            {
                if(IsSafe(u, c, colors) == true)
                {
                    colors[u] = c;

                    if (GraphColoringUtil(u + 1, colors, m) == true)
                        return true;

                    colors[u] = 0;//If assigning the color doesnot lead to a solution then remove it
                }
            }

            return false;
        }

        private bool IsSafe(int u, int c, int[] colors)
        {
            foreach (var v in Adj[u])
                if (colors[v] == c)
                    return false;

            return true;
        }

        private void PrintColors(int[] colors)
        {
            for(int i = 0; i < V; ++i)
                Console.Write(colors[i] + " ");
        }
    }
}
