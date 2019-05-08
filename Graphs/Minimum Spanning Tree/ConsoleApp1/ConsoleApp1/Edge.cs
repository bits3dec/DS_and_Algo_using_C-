using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Edge : IComparable<Edge>
    {
        public int src;
        public int dest;
        public int weight;

        public int CompareTo(Edge other)
        {
            if (this.weight > other.weight)
                return -1;
            if (this.weight < other.weight)
                return 1;

            return 0;
        }
    }
}
