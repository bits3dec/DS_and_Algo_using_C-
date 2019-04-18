using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SortingUtility
    {
        public static void MergeSort(int[] arr)
        {
            MergeSortUtil(arr, 0, arr.Length - 1);
        }

        private static void MergeSortUtil(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSortUtil(arr, low, mid);
                MergeSortUtil(arr, mid + 1, high);
                Merge(arr, low, mid, high);
            }
        }

        private static void Merge(int[] arr, int low, int mid, int high)
        {
            int n1 = mid - low + 1;
            int n2 = high - mid;
            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int index = 0; index < n1; ++index)
                L[index] = arr[low + index];
            for (int index = 0; index < n2; ++index)
                R[index] = arr[mid + 1 + index];

            int i = 0;
            int j = 0;
            int k = low;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    ++k;
                    ++i;
                }
                else
                {
                    arr[k] = R[j];
                    ++k;
                    ++j;
                }
            }

            while (i < n1)
            {
                arr[k] = L[i];
                ++k;
                ++i;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                ++k;
                ++j;
            }
        }
    }
}

