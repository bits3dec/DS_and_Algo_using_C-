using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BoxStacking
    {
        public static void MaxHeight(Box[] boxes)
        {
            int n = boxes.Length;
            Box[] rotBoxes = new Box[3 * n];

            //create a new array of boxes considering every rotation of boxes
            //Assume width is always greater than depth for simplicity
            for(int i = 0; i < n; ++i)
            {
                rotBoxes[3 * i] = new Box(boxes[i].Height,
                                          Math.Max(boxes[i].Width, boxes[i].Depth),
                                          Math.Min(boxes[i].Width, boxes[i].Depth));
                rotBoxes[3 * i + 1] = new Box(boxes[i].Width,
                                              Math.Max(boxes[i].Height, boxes[i].Depth),
                                              Math.Min(boxes[i].Height, boxes[i].Depth));
                rotBoxes[3 * i + 2] = new Box(boxes[i].Depth,
                                              Math.Max(boxes[i].Width, boxes[i].Height),
                                              Math.Min(boxes[i].Width, boxes[i].Height));
            }

            //Sort the array of boxes in decreasing order of base area
            Array.Sort(rotBoxes);

            int newLength = 3 * n;
            //MSH[j] denotes the maximum stack height with rotBoxes[j] at top
            int[] MSH = new int[newLength];

            for (int i = 0; i < newLength; ++i)
                MSH[i] = rotBoxes[i].Height;

            for(int j = 1; j < newLength; ++j)
            {
                Box currentBox = rotBoxes[j];
                for(int i = 0; i < j; ++i)
                {
                    Box prevBox = rotBoxes[i];
                    if(prevBox.Width > currentBox.Width && prevBox.Depth > currentBox.Depth
                       && MSH[i] + currentBox.Height > MSH[j])
                    {
                        MSH[j] = MSH[i] + currentBox.Height;
                    }
                }
            }

            int res = FindMax(MSH);

            Console.WriteLine($"The maximum stack height is: {res}");
        }

        private static int FindMax(int[] arr)
        {
            int max = Int32.MinValue;

            for (int i = 0; i < arr.Length; ++i)
                if (arr[i] > max)
                    max = arr[i];

            return max;
        }
    }


    public class Box : IComparable<Box>
    {
        public Box(int height, int width, int depth)
        {
            Height = height;
            Width = width;
            Depth = depth;
        }
        public int Height { get;  private set; }
        public int Width { get;  private set; }
        public int Depth { get;  private set; }

        public int BaseArea { get { return Width* Depth; } }

        public int CompareTo(Box other)
        {
            if (other == null)
                return 1;

            if (this.BaseArea > other.BaseArea)
                return -1;

            if (this.BaseArea < other.BaseArea)
                return 1;

            return 0;
        }
    }
}
