using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MergeUtility
    {
        public static void MergeKSortedArrays(int[][] arr, int k)
        {
            List<int> res = new List<int>();
            Node[] subArr = new Node[k];
            int n = 0;//Total number of elements in the jagged array

            for (int i = 0; i < k; ++i)
            {
                subArr[i] = new Node(arr[i][0], i, 0);
                n += arr[i].Length;
            }

            BuildHeap(subArr, k);

            for (int i = 0; i < n; ++i)
            {
                Node item = subArr[0];
                res.Add(item.value);

                int array = item.array;
                int index = item.index + 1;
                if (index < arr[array].Length)
                    subArr[0] = new Node(arr[array][index], array, index);
                else
                    subArr[0] = new Node(int.MaxValue, -1, -1);

                Heapify(subArr, 0, k);
            }

            Print(res);
        }

        //MinHeap
        private static void BuildHeap(Node[] arr, int n)
        {
            for (int i = (n - 2) / 2; i >= 0; --i)
                Heapify(arr, i, n);
        }

        private static void Heapify(Node[] arr, int i, int n)
        {
            int min = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && arr[l].value < arr[min].value)
                min = l;
            if (r < n && arr[r].value < arr[min].value)
                min = r;

            if(min != i)
            {
                Swap(ref arr[min], ref arr[i]);
                Heapify(arr, min, n);
            }
        }

        private static void Swap(ref Node x, ref Node y)
        {
            Node temp = x;
            x = y;
            y = temp;
        }

        private static void Print(List<int> res)
        {
            foreach (var next in res)
                Console.Write(next + " ");
        }
    }
}
