using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChange
{
    public class CoinChange
    {
        //T: Exponential  S: Stack used in recursive calls
        public int MinCoins_Recursive(int[] coins, int n, int v)
        {
            if (v == 0)
                return 0;

            int res = Int32.MaxValue;
            
            for (int i = 0; i < n; ++i)
            {
                if (coins[i] <= v)
                {
                    int sub_res = MinCoins_Recursive(coins, n, v - coins[i]);
                    if (sub_res != Int32.MaxValue && sub_res + 1 < res)
                        res = sub_res + 1;
                }
            }

            return res;
        }

        //T: O(nv) S: O(max(n,v))
        public int MinCoins_DP(int[] coins, int n, int v)
        {
            //T[j] denotes the minimum num of coins required to get a sum "j";
            int[] T = new int[v + 1];

            for (int i = 0; i <= v; ++i)
                T[i] = Int32.MaxValue;
            T[0] = 0;

            for(int j = 1; j <= v; ++j)
            {
                for(int i = 0; i < n; ++i)
                {
                    if(coins[i] <= j)
                    {
                        int sub_res = T[j - coins[i]];

                        if (sub_res != Int32.MaxValue && sub_res + 1 < T[j])
                            T[j] = sub_res + 1;
                    }
                }
            }

            return T[v];
        }

        //T: O(nc)  S: O(nv)
        public int NumberOfCoinChanges(int[] coins, int n, int v)
        {
            int[,] T = new int[n, v + 1];

            for (int i = 0; i < n; ++i)
                T[i, 0] = 1;

            for(int j = 1; j <= v; ++j)
            {
                for(int i = 0; i < n; ++i)
                {
                    if(i == 0)
                    {
                        T[i, j] = 1;
                        continue;
                    }
                    else
                    {
                        int x = 0;
                        int y = 0;

                        x = coins[i] <= j ? T[i, j - coins[i]] : 0;
                        y = T[i - 1, j];

                        T[i, j] = x + y;
                    }
                }
            }

            return T[n-1, v];
        }

        //T: O(nv) S: O(max(v,n))
        public int NumberOfCoinChanges_spaceEfficient(int[] coins, int n, int v)
        {
            //T[j] denotes num of coin change required to get a sun "j"
            int[] T = new int[v + 1];

            for (int i = 0; i <= v; ++i)
                T[i] = 0;
            T[0] = 1;

            for(int i = 0; i < n; ++i)
            {
                for(int j = 1; j <= v; ++j)
                {
                    if(j >= coins[i])
                        T[j] += T[j - coins[i]];
                }
            }

            return T[v];
        }
    }
}
