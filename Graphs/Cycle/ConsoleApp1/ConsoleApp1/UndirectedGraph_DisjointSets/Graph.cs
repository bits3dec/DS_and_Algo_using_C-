using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.UndirectedGraph_DisjointSets
{
    public class Graph
    {
        public int V;
        public int E;
        public Edge[] Edges;

        public Graph(int V, int E)
        {
            this.V = V;
            this.E = E;
            Edges = new Edge[E];
            for (int e = 0; e < E; ++e)
                Edges[e] = new Edge();
        }

        //FIND(X)
        public int Find(int x, Subset[] subsets)
        {
            if (subsets[x].Parent == x)
                return x;

            return subsets[x].Parent = Find(subsets[x].Parent, subsets); //Path Compression
        }

        //UNION(X, Y)
        public void Union(int x, int y, Subset[] subsets)
        {
            //Union by rank: Smaller depth tree is under the root of deeper depth tree
            int x_root = Find(x, subsets);
            int y_root = Find(y, subsets);

            if (subsets[y_root].Rank < subsets[x_root].Rank)
                subsets[y_root].Parent = x_root;
            else if (subsets[x_root].Rank < subsets[y_root].Rank)
                subsets[x_root].Parent = y_root;
            else
            {
                subsets[y_root].Parent = x_root;
                subsets[x_root].Rank++;
            }
        }

        public bool IsCyclic()
        {
            Subset[] subsets = new Subset[V];
            //MAKESET(X)
            for(int i = 0; i < V; ++i)
            {
                subsets[i] = new Subset();
                subsets[i].Parent = i;
                subsets[i].Rank = 0;
            }

            for(int e = 0; e < E; ++e)
            {
                int x = Find(Edges[e].Src, subsets);
                int y = Find(Edges[e].Dest, subsets);

                if (x == y)
                    return true;

                Union(x, y, subsets);
            }

            return false;
        }
    }
}
