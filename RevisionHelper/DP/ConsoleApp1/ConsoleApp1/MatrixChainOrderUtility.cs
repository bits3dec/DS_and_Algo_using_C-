using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MatrixChainOrderUtility
    {
        public static void MinMultiplications(int[] matrices)
        {
            int n = matrices.Length - 1;

            //T[i,j] denotes the minimum num of multiplications needed to multiply matrices A[i].....A[j]
            int[,] T = new int[n + 1, n + 1];
            //B[i,j] denotes the position of the bracket to get minimum multiplications
            int[,] B = new int[n + 1, n + 1];

            for (int i = 1; i <= n; ++i)
                T[i, i] = 0; //No multiplication is needed when there is only single matrix

            for(int l = 2; l <= n; ++l)
            {
                for(int i = 1; i <= n-l+1; ++i)
                {
                    int j = i + l - 1;
                    int minCost = Int32.MaxValue;
                    for(int k = i; k < j; ++k)
                    {
                        int cost = T[i, k] + T[k + 1, j] + (matrices[i - 1] * matrices[k] * matrices[j]);
                        if(cost < minCost)
                        {
                            minCost = cost;
                            T[i, j] = minCost;
                            B[i, j] = k;
                        }
                    }
                }
            }

            int res = T[1, n];

            Console.WriteLine($"The minimum number of multiplications needed are: {res}");


        }
    }
}
