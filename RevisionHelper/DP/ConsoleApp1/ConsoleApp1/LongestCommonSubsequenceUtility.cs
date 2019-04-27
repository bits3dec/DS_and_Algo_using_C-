using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LongestCommonSubsequenceUtility
    {
        public static void LCS(string X, string Y)
        {
            int m = X.Length;
            int n = Y.Length;

            //L[i,j] denotes longest common subsequence for X[0...i-1] and Y[0....j-1]
            int[,] L = new int[m + 1, n + 1];

            for (int i = 0; i < m + 1; ++i)
            {
                for (int j = 0; j < n + 1; ++j)
                {
                    if (i == 0 || j == 0)
                        L[i, j] = 0;
                    else
                    {
                        if (X[i - 1] == Y[j - 1])
                            L[i, j] = 1 + L[i - 1, j - 1];
                        else
                            L[i, j] = Math.Max(L[i, j - 1], L[i - 1, j]);
                    }
                }
            }
            int res = L[m, n];

            Console.WriteLine($"LCS: {res}");
            PrintLCS(X, Y, L, res);
        }

        private static void PrintLCS(string X, string Y, int[,] L, int LCS)
        {
            int i = L.GetLength(0) - 1;
            int j = L.GetLength(1) - 1;
            char[] res = new char[LCS];
            int k = LCS - 1;

            while (i > 0 && j > 0)
            {
                if (X[i - 1] == Y[j - 1])
                {
                    res[k] = X[i - 1];
                    --i;
                    --j;
                    --k;
                }
                else
                {
                    if (L[i - 1, j] >= L[i, j - 1])
                        --i;
                    else
                        --j;
                }
            }

            Console.WriteLine($"The lcs string is: {new string(res)}");
        }
    }
}
