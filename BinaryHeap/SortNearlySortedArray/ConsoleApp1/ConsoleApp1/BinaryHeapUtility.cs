using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BinaryHeapUtility
    {
        public static void Sort(int[] arr, int k)
        {
            int n = arr.Length;
            int[] subArr = new int[k + 1];
            
            for(int i = 0; i <= k; ++i)
                subArr[i] = arr[i];

            //Min Heap
            BuildHeap(subArr);

            int index = 0;
            for(int i = k+1; i < n; ++i)
            {
                arr[index] = subArr[0];
                subArr[0] = arr[i];
                Heapify(subArr, 0, k+1);

                ++index;
            }

            while(index < n)
            {
                arr[index] = DeleteMin(subArr);
                ++index;
            }

            Print(arr);

        }

        //Min Heap
        private static void BuildHeap(int[] arr)
        {
            int n = arr.Length;

            for (int i = (n - 2) / 2; i >= 0; --i)
                Heapify(arr, i, n);
        }

        //Percolate down (Top-down approach)
        private static void Heapify(int[] arr, int i, int n)
        {
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
                Heapify(arr, min, n);
            }
        }
        private static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        private static int DeleteMin(int[] arr)
        {
            int min = arr[0];

            int n = arr.Length;
            arr[0] = arr[n - 1];
            arr[n - 1] = int.MaxValue;
            Heapify(arr, 0, n);

            return min;
        }

        private static void Print(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
        }
    }
}
