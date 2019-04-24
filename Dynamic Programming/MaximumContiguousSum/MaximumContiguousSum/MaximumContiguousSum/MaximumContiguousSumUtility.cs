using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumContiguousSum
{
    class MaxContiguousSumUtility
    {
        //Kadane's Algorithm T:O(n) S:O(1)
        public static void MaxContiguousSum(int[] arr)
        {
            Console.WriteLine("------Kadane's Algorithm------");
            //Check if all are negative then return the least negative
            if (CheckAllNegative(arr))
            {
                Console.Write("Maximum contiguous sum is " + FindMax(arr));
                return;
            }

            //Kadane's Algorithm
            int n = arr.Length;
            int maxSumSoFar = Int32.MinValue;
            int sumEndingHere = 0;

            for (int i = 0; i < n; ++i)
            {
                sumEndingHere += arr[i];
                if (sumEndingHere < 0)
                    sumEndingHere = 0;
                else if (sumEndingHere > maxSumSoFar)
                    maxSumSoFar = sumEndingHere;
            }

            Console.Write("Maximum contiguous sum is " + maxSumSoFar);
        }

        private static bool CheckAllNegative(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                if (arr[i] > 0)
                    return false;

            return true;
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

    public class MaxContiguousSumUtility_DP
    {
        //Dynamic Programming T:O(n) S:O(n)
        public static void MaxContiguousSum(int[] arr)
        {
            Console.WriteLine("\n------Dynamic Programming------");
            int n = arr.Length;

            //M[i] denotes the maximum contiguous sum in the array with arr[i] as last element in the window
            int[] M = new int[n];

            for (int i = 0; i < n; ++i)
            {
                if (i == 0)
                    M[i] = arr[i] > 0 ? arr[i] : 0;

                else
                {
                    if (M[i - 1] + arr[i] > 0)
                        M[i] = M[i - 1] + arr[i];
                    else
                        M[i] = 0;
                }
            }

            int res = FindMax(M);
            Console.Write("Maximum contiguous sum is " + res);
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
