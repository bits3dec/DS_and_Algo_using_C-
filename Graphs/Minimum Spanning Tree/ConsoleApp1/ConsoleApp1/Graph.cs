using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Graph
    {
        public int v;
        public int e;
        public Edge[] edges;

        public Graph(int v, int e)
        {
            this.v = v;
            this.e = e;
            edges = new Edge[e];
            for (int i = 0; i < e; ++i)
                edges[i] = new Edge();
        }
    }
}
