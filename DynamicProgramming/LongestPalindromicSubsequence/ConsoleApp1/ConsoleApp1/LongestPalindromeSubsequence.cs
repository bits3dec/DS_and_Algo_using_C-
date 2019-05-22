using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LongestPalindromeSubsequence
    {
        public int LPS(string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;

            int n = str.Length;

            //L[i,j] denotes the longest palindromic subsequence from str[i]....str[j]
            int[,] L = new int[n, n];

            for(int i = 0; i < n; ++i)
                L[i, i] = 1;

            for(int i = 0; i < n-1; ++i)
            {
                if (str[i] == str[i + 1])
                    L[i, i + 1] = 2; 
                else
                    L[i, i + 1] = 1;
            }

            for(int k = 3; k <= n; ++k)
            {
                for(int i = 0; i <= n-k; ++i)
                {
                    int j = i + k - 1;
                    if(str[i] == str[j])
                        L[i, j] = L[i + 1, j - 1] + 2;
                    else
                        L[i, j] = Math.Max(L[i + 1, j], L[i, j - 1]);
                }
            }

            return L[0, n-1];
        }
    }
}
