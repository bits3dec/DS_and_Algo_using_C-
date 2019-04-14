using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LongestIncreasingSubsequence
    {
        public int LIS(int[] arr)
        {
            int n = arr.Length;
            int[] LIS = new int[n];

            for (int i = 0; i < n; ++i)
                LIS[i] = 1;

            for(int j = 1; j < n; ++j)
            {
                for(int i = 0; i < j; ++i)
                {
                    if (arr[i] < arr[j] && LIS[i] + 1 > LIS[j])
                        LIS[j] = 1 + LIS[i];
                }
            }

            int max = Int32.MinValue;
            for (int i = 0; i < n; ++i)
                if (LIS[i] > max)
                    max = LIS[i];

            return max;
        }
    }
}
