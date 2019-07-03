using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Box : IComparable<Box>
    {
        public int height;
        public int width;
        public int length;

        public Box(int height, int width, int length)
        {
            this.height = height;
            this.width = width;
            this.length = length;
        }

        public int BaseArea { get { return length * width; } }

        public int CompareTo(Box other)
        {
            if (other == null) return 1;

            Box secondBox = other as Box;
            return secondBox.BaseArea - this.BaseArea;
        }
    }
}
