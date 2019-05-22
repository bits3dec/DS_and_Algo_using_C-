using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BinaryHeapUtility
    {
        public static void FirstKNonRepeatingCharacters(string str, int k)
        {
            int n = str.Length;
            Dictionary<char, Node> map = new Dictionary<char, Node>();

            for (int j = 0; j < n; ++j)
            {
                if (map.ContainsKey(str[j]) == true)
                    map[str[j]].Count++;
                else
                    map.Add(str[j], new Node(1, j));
            }

            int[] subArr = new int[k];//MaxHeap
            int i = 0;
            foreach (var kvp in map)
            {
                int count = kvp.Value.Count;
                int index = kvp.Value.StartIndex;

                if (count == 1)
                {
                    if (i < k)
                    {
                        subArr[i] = index;
                        ++i;
                        if (i == k)
                            BuildHeap(subArr);//O(log k)
                    }
                    else
                    {
                        if (index > subArr[0])
                        {
                            subArr[0] = index;
                            Heapify(subArr, 0, k);//O(log k)
                        }
                    }
                }
            }

            char[] res = new char[k];
            i = 0;
            while (i < k)
            {
                res[i] = str[subArr[0]];
                subArr[0] = int.MinValue;
                Heapify(subArr, 0, k);
                ++i;
            }

            Print(res);
        }

        //MaxHeap
        private static void BuildHeap(int[] arr)
        {
            int n = arr.Length;

            for (int i = (n - 2) / 2; i >= 0; --i)
                Heapify(arr, i, n);
        }

        //Percolate down(top-down apporach)
        private static void Heapify(int[] arr, int i, int n)
        {
            int max = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && arr[l] > max)
                max = l;
            if (r < n && arr[r] > max)
                max = r;

            if (max != i)
            {
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

        private static void Print(char[] res)
        {
            for (int i = 0; i < res.Length; ++i)
                Console.Write(res[i] + " ");
        }
    }
}
