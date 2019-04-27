using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LongestPalindromicUtility
    {
        public static void LPSubstring(string str)
        {
            int n = str.Length;

            //T[i,j] denotes the longest palindromic substring from str[i].....str[j]
            bool[,] T = new bool[n, n];
            int maxLength = 0;
            int startIndex = 0;

            for(int i = 0; i < n; ++i)
            {
                T[i, i] = true;
                maxLength = 1;
                startIndex = i;
            }

            for(int i = 0; i < n-1; ++i)
            {
                if (str[i] == str[i + 1])
                {
                    T[i, i + 1] = true;
                    maxLength = 2;
                    startIndex = i;
                }
            }

            for(int k = 3; k <= n; ++k)
            {
                for(int i = 0; i < n-k+1; ++i)
                {
                    int j = i + k - 1;
                    if(str[i] == str[j] && T[i+1, j-1] == true)
                    {
                        T[i, j] = true;
                        if(maxLength < k)
                        {
                            maxLength = k;
                            startIndex = i;
                        }
                    }
                }
            }

            string palindrome = str.Substring(startIndex, maxLength);
            Console.WriteLine($"The longest palindromic substring is {palindrome} of length {maxLength}");
        }

        public static void LPSubsequence(string str)
        {
            int n = str.Length;

            //L[i,j] denotes the longest palindromic subsequence from str[i]....str[j]
            int[,] L = new int[n, n];

            for (int i = 0; i < n; ++i)
                L[i, i] = 1;

            for(int i = 0; i < n-1; ++i)
            {
                if (str[i] == str[i + 1])
                    L[i, i + 1] = 2;
                else
                    L[i, i+1] = 1;
            }

            for(int k = 3; k <= n; ++k)
            {
                for(int i = 0; i < n-k+1; ++i)
                {
                    int j = i + k - 1;
                    if (str[i] == str[j])
                        L[i, j] = L[i + 1, j - 1] + 2;
                    else
                        L[i, j] = Math.Max(L[i + 1, j], L[i, j - 1]);
                }
            }

            int res = L[0, n - 1];

            Console.WriteLine($"The longest palindromic subsequence is of length {res}");
        }
    }
}
