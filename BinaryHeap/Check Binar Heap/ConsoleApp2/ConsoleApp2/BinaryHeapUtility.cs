using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class BinaryHeapUtility
    {
        public static int KthLargestElement(int[] arr, int k)
        {
            int n = arr.Length;

            int[] subArr = new int[k];
            int[] res = new int[k];

            for (int i = 0; i < k; ++i)
                subArr[i] = arr[i];

            BuildHeap(subArr);//Min Heap

            for(int i = k; i < n; ++i)
            {
                if (arr[i] > subArr[0])
                {
                    subArr[0] = arr[i];
                    Heapify(subArr, 0);
                }
            }

            return subArr[0];
        }

        //Min Heap
        private static void BuildHeap(int[] arr)
        {
            int n = arr.Length;
            for (int i = (n - 2) / 2; i >= 0; --i)
                Heapify(arr, i);
        }

        private static void Heapify(int[] arr, int i)
        {
            int n = arr.Length;

            int min = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && arr[l] < arr[min])
                min = l;
            if (r < n && arr[r] < arr[min])
                min = r;
            if(min != i)
            {
                Swap(ref arr[i], ref arr[min]);
                Heapify(arr, min);
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
