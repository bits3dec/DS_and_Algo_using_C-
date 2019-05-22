using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OptimalGameStrategy
    {
        public static int MaximumValue(int[] arr)
        {
            int n = arr.Length;

            //T[i,j] denotes the maximum value the user can get from the array of coins arr[i]...arr[j] if he picks first
            int[,] T = new int[n, n];

            for(int gap = 0; gap < n; ++gap)
            {
                for(int i = 0, j = gap; j < n; ++i, ++j)
                {
                    if (i == j)
                        T[i, j] = arr[i];
                    else if (i + 1 == j)
                        T[i, j] = Math.Max(arr[i], arr[j]);
                    else
                    {
                        T[i, j] = Math.Max(arr[i] + Math.Min(T[i + 1, j - 1], T[i + 2, j]),
                                           arr[j] + Math.Min(T[i + 1, j - 1], T[i, j - 2])
                                           );
                    }
                }
            }

            return T[0, n - 1];
        }
    }
}
