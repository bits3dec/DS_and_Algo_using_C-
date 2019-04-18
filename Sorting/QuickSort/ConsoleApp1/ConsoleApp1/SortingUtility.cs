using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SortingUtility
    {
        public static void Sort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length-1);
        }

        private static void QuickSort(int[] arr, int low, int high)
        {
            if(low < high)
            {
                int partition = Partition(arr, low, high);
                QuickSort(arr, low, partition - 1);
                QuickSort(arr, partition + 1, high);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low-1;

            for (int j = low; j < high; ++j)
            {
                if (arr[j] <= pivot)
                {
                    ++i;
                    Swap(ref arr[i], ref arr[j]);
                }
            }
            ++i;
            Swap(ref arr[i], ref arr[high]);

            return i;
        }

        private static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
