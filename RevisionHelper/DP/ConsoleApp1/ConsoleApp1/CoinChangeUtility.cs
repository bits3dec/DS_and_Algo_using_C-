using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CoinChangeUtility
    {
        //Assuming coins[0] = 1
        //T:O(nV) S:O(nV)
        public static void MinCoins_2D(int[] coins, int V)
        {
            int n = coins.Length;

            //T[i,j] denotes minimum num of coins needed to get a sum "j"
            int[,] T = new int[n, V + 1];
            T[0, 0] = 0;

            for (int j = 1; j <= V; ++j)
                T[0, j] = j;

            for(int j = 0; j <= V; ++j)
            {
                for(int i = 1; i < n; ++i)
                {
                    if (coins[i] <= j)
                        T[i, j] = Math.Min(1 + T[i, j - coins[i]],
                                           T[i - 1, j]);
                    else
                        T[i, j] = T[i, j] = T[i - 1, j];
                }
            }

            int res = T[n - 1, V];

            Console.WriteLine($"Minimum num of coins to get a sum {V} is: {res}");
        }

        public static void MinCoins_1D(int[] coins, int V)
        {
            //T[j] denotes the min num of coins needed to get a sum "j"
            int[] T = new int[V+1];
            T[0] = 0;

            for (int j = 1; j <= V; ++j)
                T[j] = Int32.MaxValue;

            for(int j = 1; j <= V; ++j)
            {
                for(int i = 0; i < coins.Length; ++i)
                {
                    if(coins[i] <= j)
                    {
                        int subResult = T[j - coins[i]];
                        if (subResult != Int32.MaxValue && subResult + 1 < T[j])
                            T[j] = subResult + 1;
                    }
                }
            }

            int res = T[V];

            Console.WriteLine($"Minimum num of coins to get a sum {V} is: {res}");
        }

        public static void TotalWays_2D(int[] coins, int V)
        {
            int n = coins.Length;
            //T[i, j] denotes the num of ways to get a value "j" from coins[0]...coins[i]
            int[,] T = new int[n, V + 1];

            //When value is 0 then num of ways is 1 (i.e. no change possible)
            for (int i = 0; i < n; ++i)
                T[i, 0] = 1;
            for (int j = 1; j <= V; ++j)
                T[0, j] = 1;

            for (int i = 1; i < n; ++i)
            {
                for(int j = 1; j <= V; ++j)
                {
                    int x = T[i - 1, j]; //Case: not selecting the current coin
                    int y = coins[i] <= j ? T[i, j - coins[i]] : 0; // Case: selecting the current coin
                    T[i, j] = x + y;
                }
            }

            int res = T[n - 1, V];

            Console.WriteLine($"Num of ways to get a value {V} is: {res}");
        }
    }
}
