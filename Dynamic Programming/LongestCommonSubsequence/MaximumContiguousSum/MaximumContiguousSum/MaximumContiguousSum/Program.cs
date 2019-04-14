using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumContiguousSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -2, 11, -4, 13, -5, 2 };
            //int[] arr = new int[] {-2, -11, -4, -13, -5, -2};
            //int[] arr = new int[] {2, 11, 4, 13, 5, 2};

            int res = FindMaxContiguousSum(arr);
            Console.WriteLine("The max contiguous sum of the given array is: {0}", res);

            Console.ReadKey();
        }

        private static int FindMaxContiguousSum(int[] arr)
        {
            int i = 0;
            //check if all the elements are negative. If so then return the maximum of the elements as maxSum
            for (i = 0; i < arr.Length; ++i)
                if (arr[i] > 0) break;

            if (i == arr.Length)
                return FindMinNegative(arr);
            
            int sumSoFar = Int32.MinValue;
            int sumEndingHere = 0;

            for(i = 0; i < arr.Length; ++i)
            {
                sumEndingHere = sumEndingHere + arr[i];

                if (sumEndingHere < 0)
                    sumEndingHere = 0;
                else if (sumSoFar < sumEndingHere)
                    sumSoFar = sumEndingHere;
            }

            return sumSoFar;
        }
        private static int FindMinNegative(int[] arr)
        {
            int max = Int32.MinValue;

            for(int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            return max;
        }
    }
}
