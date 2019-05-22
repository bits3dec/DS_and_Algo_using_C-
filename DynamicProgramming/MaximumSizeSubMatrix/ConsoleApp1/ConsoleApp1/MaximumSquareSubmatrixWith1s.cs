using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MaximumSquareSubmatrixWith1s
    {
        public static int GetMaxSquareSubmatrixSize(int[,] M)
        {
            int m = M.GetLength(0);
            int n = M.GetLength(1);

            //T[i,j] denotes the size of maximum submatrix with all 1s and with M[i,j] as the rightmost bottom entry
            int[,] T = new int[m, n];

            int maxArea = Int32.MinValue;

            for (int j = 0; j < n; ++j)
                T[0, j] = M[0, j];
            for (int i = 0; i < m; ++i)
                T[i,0] = M[i, 0];

            for (int i = 1; i < m; ++i)
            {
                for(int j = 1; j < n; ++j)
                {
                    if (M[i, j] == 1)
                        T[i, j] = Min(T[i, j - 1], T[i - 1, j - 1], T[i - 1, j]) + 1;
                    else
                        T[i, j] = 0;

                    if (T[i, j] > maxArea)
                        maxArea = T[i, j];
                }
            }

            return maxArea;
        }

        private static int Min(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }
    }
}
