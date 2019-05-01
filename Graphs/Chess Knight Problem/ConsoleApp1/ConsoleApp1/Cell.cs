using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cell
    {
        public int x;
        public int y;
        public int dist;

        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Cell(int x, int y, int dist)
        {
            this.x = x;
            this.y = y;
            this.dist = dist;
        }
    }
}
