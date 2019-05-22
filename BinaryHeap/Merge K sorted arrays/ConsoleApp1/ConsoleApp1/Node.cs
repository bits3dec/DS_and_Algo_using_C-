using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Node
    {
        public int value;
        public int array;
        public int index;

        public Node(int value, int array, int index)
        {
            this.value = value;
            this.array = array;
            this.index = index;
        }
    }
}
