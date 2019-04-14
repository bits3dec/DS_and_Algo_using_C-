using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Partition
    {
        //Check if total sum is odd/even. If odd then partitioning is not possible.
        //The problem then reduces to finding subset whose sum is half of the total sum(i.e. total sum/2).
        public bool CheckPartitionExists(int[] arr)
        {
            int sum = CalculateSum(arr);
            if(sum % 2 == 1)
                return false;

            int n = arr.Length;
            int k = sum / 2;

            bool[,] S = new bool[n+1, k + 1];

            //There always exists an empty set whose sum is 0.
            for (int i = 0; i < n; ++i)
                S[i, 0] = true;
            
            for(int j = 1; j <= k; ++j)
            {
                for(int i = 1; i <= n; ++i)
                {
                    if(arr[i-1] > j)
                        S[i, j] = S[i - 1, j];
                    else if(arr[i-1] <= j)
                        S[i, j] = S[i, j - arr[i-1]] || S[i - 1, j];
                }
            }

            return S[n, k];
        }

        private int CalculateSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; ++i)
                sum += arr[i];

            return sum;
        }
    }
}
