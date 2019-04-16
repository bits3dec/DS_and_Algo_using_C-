using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MinimumCost
    {
        //Can travel 1)Left  2)Diagonally lower 3)Down
        public int MinCost(int[,] cost, int m, int n)
        {
            //T[i, j] denotes the total minimum cost required to reach (i,j) from (0,0)
            int[,] T = new int[m+1, n+1];

            T[0, 0] = cost[0, 0];

            for (int i = 1; i <= n; ++i)
                T[0, i] = T[0, i-1] + cost[0, i];
            for (int j = 1; j <= m; ++j)
                T[j, 0] = T[j - 1, 0] + cost[j, 0];

            for(int j = 1; j <= n; ++j)
            {
                for(int i = 1; i <= m; ++i)
                {
                    int minCost = Min(T[i, j - 1], T[i - 1, j - 1], T[i - 1, j]);
                    T[i, j] = minCost + cost[i, j];
                }
            }

            return T[m, n];
        }

        private int Min(int x, int y, int z)
        {
            return Math.Min(x, Math.Min(y, z));
        }
    }
}
