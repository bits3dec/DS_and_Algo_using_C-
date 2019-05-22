using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Node
    {
        public int Count;
        public int StartIndex;

        public Node(int count, int startIndex)
        {
            this.Count = count;
            this.StartIndex = startIndex;
        }
    }
}
