using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "ABCBDAB";
            string s2 = "BDCABA";

            LCS(s1.ToCharArray(), s2.ToCharArray());

            Console.ReadKey();
        }

        private static void LCS(char[] x, char[] y)
        {
            int res = 0;
            int m = x.Length;
            int n = y.Length;

            //lcs[i,j] denotes the length of longest common subsequence in x[0, ......, i-1] and y[0, ......, j-1]
            int[,] lookUp = new int[m + 1, n + 1];

            for(int i = 0; i <= m; ++i)
                for(int j = 0; j <= n; ++j)
                {
                    if (i == 0 || j == 0)
                        lookUp[i, j] = 0;
                    else if (x[i - 1] == y[j - 1])
                        lookUp[i, j] = 1 + lookUp[i - 1, j - 1];
                    else
                        lookUp[i, j] = Math.Max(lookUp[i - 1, j], lookUp[i, j - 1]);
                }

            res = lookUp[m, n];

            int index = res;
            char[] lcs = new char[res + 1];
            lcs[index] = '\0';
            index--;

            int k = m;
            int l = n;

            while(k > 0 && l > 0)
            {
                if (x[k - 1] == y[l - 1])
                {
                    lcs[index] = x[k - 1];
                    --index;
                    --k;
                    --l;
                }
                else if (lookUp[k - 1, l] > lookUp[k, l - 1])
                    --k;
                else
                    --l;
            }
            Console.WriteLine("The longest common subsequence is: {0} of length: {1}", new string(lcs), res);
        }
    }
}
