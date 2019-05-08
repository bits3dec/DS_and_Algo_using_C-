using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MinimumSpanningTreeUtility
    {
        public static int Find(Subset[] subsets, int x)
        {
            if (subsets[x].parent == x)
                return x;

            return subsets[x].parent = Find(subsets, subsets[x].parent);
        }

        public static void Union(Subset[] subsets, int x, int y)
        {
            int x_root = Find(subsets, x);
            int y_root = Find(subsets, y);

            if (subsets[x_root].rank > subsets[y_root].rank)
                subsets[y_root].parent = x_root;
            if (subsets[x_root].rank < subsets[y_root].rank)
                subsets[x_root].parent = y_root;
            else
            {
                subsets[x_root].parent = y_root;
                subsets[y_root].rank++;
            }
        }

        public static void MST(Graph g)
        {
            int V = g.v;
            Edge[] res = new Edge[V - 1];
            for (int i = 0; i < V - 1; ++i)
                res[i] = new Edge();

            Subset[] subsets = new Subset[V];
            for (int i = 0; i < V; ++i)
            {
                subsets[i] = new Subset();
                subsets[i].parent = i;
                subsets[i].rank = 0;
            }

            //Sort the edges in non-decreasing order of their weight
            Array.Sort(g.edges, new Comparison<Edge>((e1, e2) => e1.weight.CompareTo(e2.weight)));

            int e = 0;
            int j = 0;

            while(e < V - 1)
            {
                Edge nextEdge = g.edges[j];

                int x = Find(subsets, nextEdge.src);
                int y = Find(subsets, nextEdge.dest);

                if(x != y)
                {
                    res[e] = nextEdge;
                    Union(subsets, x, y);
                    ++e;
                }

                ++j;
            }

            PrintEdges(res);
        }

        private static void PrintEdges(Edge[] edges)
        {
            for(int i = 0; i < edges.Length; ++i)
                Console.WriteLine(edges[i].src + "----" + edges[i].dest);
        }
    }
}
