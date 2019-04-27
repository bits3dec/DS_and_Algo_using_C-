using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OptimalGameStrategyUtil
    {
        public static void MaxValue(int[] coins)
        {
            int n = coins.Length;

            //T[i,j] denotes the maximum amount the user can collect from coins[i]...coins[j] if the user picks first
            int[,] T = new int[n, n];

            for(int gap = 0; gap < n; ++gap)
            {
                for(int i = 0, j = gap; j < n; ++i, ++j)
                {
                    if (i == j)
                        T[i, j] = coins[i];

                    else if (i + 1 == j)
                        T[i, j] = Math.Max(coins[i], coins[j]);

                    else
                        T[i, j] = Math.Max( coins[i] + Math.Min(T[i + 1, j - 1], T[i + 2, j]),
                                            coins[j] + Math.Min(T[i + 1, j - 1], T[i, j - 2])
                                          );
                }
            }

            int res = T[0, n - 1];

            Console.WriteLine($"The maximum amount the user can collect if the user picks first is: {res}");
        }
    }
}
