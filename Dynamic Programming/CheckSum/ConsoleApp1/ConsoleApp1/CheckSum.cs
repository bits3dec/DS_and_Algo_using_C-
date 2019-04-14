using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CheckSum
    {
        //T:O(sum * n) S:O(sum * n)
        public bool SumExists(int[] arr, int sum)
        {
            int n = arr.Length;
            //S[i,j] denotes that if there exist a subset till element "ar[i-1]" whose sum is "j".
            bool[,] S = new bool[n+1, sum + 1];

            //If sum is 0 then there will always be an emty set with sum as 0.
            for (int i = 0; i <= n; ++i)
                S[i, 0] = true;

            for(int j = 1; j <= sum; ++j)
            {
                for(int i = 1; i <= n; ++i)
                {
                    if (j < arr[i - 1])
                        S[i, j] = S[i - 1, j];
                    else if(arr[i-1] <= j)
                        S[i, j] = S[i, j - arr[i - 1]] || S[i - 1, j];
                }
            }
            
            return S[n, sum];
        }
    }
}
