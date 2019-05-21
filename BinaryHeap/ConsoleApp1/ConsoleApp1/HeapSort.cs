using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class HeapSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            for(int i = (n-2)/2; i >= 0; --i)
                Heapify(arr, i, n);

            for(int i = n-1; i >= 0; --i)
            {
                //swap the root(largest node in the reduced heap) and place it at the end of the array one by one
                Swap(ref arr[0], ref arr[i]);

                //Heapify arr[0] in the new reduced heap;
                Heapify(arr, 0, i);
            }

        }

        private static void Heapify(int[] arr, int i, int n)
        {
            int max = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && arr[l] > arr[max])
                max = l;
            if (r < n && arr[r] > arr[max])
                max = r;

            if(max != i)
            {
                //swap parent and child
                Swap(ref arr[i], ref arr[max]);

                Heapify(arr, max, n);
            }
        }

        private static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
