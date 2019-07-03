using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BoxStacking
    {
        public int MaxStackHeight(Box[] boxes)
        {
            int n = boxes.Length;

            //Create a new array of boxes considering the rotations of each boxes i.e. each box will have 3 kinds after rotation
            //Assume width > length for simplicity
            Box[] rotatedBoxes = new Box[3 * n];
            int newLength = rotatedBoxes.Length;

            for (int i = 0; i < n; ++i)
            {
                Box box = boxes[i];

                rotatedBoxes[3 * i] = new Box(box.height, Math.Max(box.length, box.width), Math.Min(box.length, box.width));
                rotatedBoxes[3 * i + 1] = new Box(box.length, Math.Max(box.height, box.width), Math.Min(box.height, box.width));
                rotatedBoxes[3 * i + 2] = new Box(box.width, Math.Max(box.length, box.height), Math.Min(box.length, box.height));
            }

            Array.Sort(rotatedBoxes);

            //MSH[j] means the maximum height we can get with box[j] on top of the stack
            int[] MSH = new int[newLength];
            int[] stack = new int[newLength];

            for (int i = 0; i < newLength; ++i)
                MSH[i] = rotatedBoxes[i].height;


            for (int j = 1; j < newLength; ++j)
            {
                Box topBox = rotatedBoxes[j];
                for (int i = 0; i < j; ++i)
                {
                    Box bottomBox = rotatedBoxes[i];
                    if (IsStackingValid(bottomBox, topBox) && MSH[i] + topBox.height > MSH[j])
                    {
                        MSH[j] = MSH[i] + topBox.height;
                        stack[j] = i;
                    }
                }
            }

            int maxHeight = FindMax(MSH);

            return maxHeight;
        }

        private bool IsStackingValid(Box bottomBox, Box topBox)
        {
            if (bottomBox.width > topBox.width && bottomBox.length > topBox.length)
                return true;

            return false;
        }

        private int FindMax(int[] arr)
        {
            int max = Int32.MinValue;
            for(int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            return max;
        }
    }
}
