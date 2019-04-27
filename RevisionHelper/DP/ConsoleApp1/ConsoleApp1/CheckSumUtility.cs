using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CheckSumUtility
    {
        public static void Partition(int[] arr)
        {
            int sum = CalculateSum(arr);
            if(sum % 2 == 1)
            {
                Console.WriteLine("The given set cannot be partitioned into two sets with equal sum");
                return;
            }

            if(CheckSum(arr, sum/2))
            {
                Console.WriteLine("The given set can be partitoned into two subsets with equal sum");
            }
            else
            {
                Console.WriteLine("The given set cannot be partitioned into two sets with equal sum");
            }
        }

        private static int CalculateSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; ++i)
                sum += arr[i];

            return sum;
        }

        public static bool CheckSum(int[] arr, int sum)
        {
            int n = arr.Length;

            bool[,] T = new bool[n + 1, sum + 1];

            for (int i = 0; i <= n; ++i)
                T[i, 0] = true;

            for(int i = 1; i <=n; ++i)
            {
                for(int j = 1; j <= sum; ++j)
                {
                    if (arr[i - 1] <= j)
                        T[i, j] = T[i - 1, j] || T[i - 1, j - arr[i - 1]];
                    else
                        T[i, j] = T[i - 1, j];
                }
            }

            return T[n, sum]; ;
        }
    }
}
