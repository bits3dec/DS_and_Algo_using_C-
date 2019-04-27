using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LongestIncreasingSubsequenceUtility
    {
        public static void LIS(int[] arr)
        {
            int n = arr.Length;
            //L[j] denotes the longest increasing subsequence staring from arr[0] and with arr[j] on top
            int[] L = new int[n];

            for (int i = 0; i < n; ++i)
                L[i] = 1;

            for(int j = 1; j < n; ++j)
            {
                for(int i = 0; i < j; ++i)
                {
                    if (arr[i] <= arr[j] && L[i] + 1 > L[j])
                        L[j] = L[i] + 1;
                }
            }

            int res = FindMax(L);

            Console.WriteLine($"The longest increasing subsequence is: {res}");
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
}
