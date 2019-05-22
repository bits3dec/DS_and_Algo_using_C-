using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MinimumSquare
    {
        public int MinSquares(int n)
        {
            //T[i] denotes the minimum number of squares to sum to get the number "i"
            int[] T = new int[n+1];

            T[0] = 0;

            for(int j = 1; j <= n; ++j)
            {
                T[j] = j; //Initialize with i because every number can represented as a summation of square(1)
                for(int i = 1; i <= Math.Sqrt(j); ++i)
                {
                    int x = i * i;
                    if (x <= j)
                    {
                        if (1 + T[j - x] < T[j])
                            T[j] = 1 + T[j - x];
                    }
                }
            }

            return T[n];
        }
    }
}
