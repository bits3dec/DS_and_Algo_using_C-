using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MatrixMultiplication
    {
        public int MatrixChainOrder(int[] p)
        {
            int n = p.Length - 1; ;

            int[,] M = new int[n + 1, n + 1];//T[i,j] denotes the minimum scalar multiplication needed to multiply {Ai,....Aj} where Ai is a matrix
            int[,] B = new int[n + 1, n + 1];//B[i,j] denotes the position of parenthesis to get the minimum scalar multiplications from {Ai,...Aj}

            for (int i = 1; i <= n; ++i)
                M[i, i] = 0; //Minimum scalar multiplication needed to multiply one matrix is 0

            //Chain length from 2 to the number of matrices n
            for(int l = 2; l <= n; ++l)
            {
                for (int i = 1; i <= n - l + 1; ++i)
                {
                    int j = i + l - 1;
                    int minCost = Int32.MaxValue;
                    for(int k = i; k < j; ++k)
                    {
                        int cost = M[i, k] + M[k + 1, j] + (p[i - 1] * p[k] * p[j]);
                        if(cost < minCost)
                        {
                            minCost = cost;
                            M[i, j] = minCost;
                            B[i, j] = k;
                        }
                    }
                }
            }

            return M[1, n];
        }
    }
}
