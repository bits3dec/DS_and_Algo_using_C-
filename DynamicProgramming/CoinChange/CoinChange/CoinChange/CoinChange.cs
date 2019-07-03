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

        //T: O(nv) S: O(v))
        public int MinCoins_1D(int[] coins, int n, int v)
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
        //Assuming coins[0] = 1
        public int NumberOfCoinChanges_2D(int[] coins, int n, int v)
        {
            //T[i, j] denotes the num of ways to get a value "j" from coins[0]...coins[i]
            int[,] T = new int[n, v + 1];

            //When value is 0 then num of ways is 1 (i.e. no change possible)
            for (int i = 0; i < n; ++i)
                T[i, 0] = 1;
            for (int j = 1; j <= v; ++j)
                T[0, j] = 1; //Assuming coins[0] = 1

            for (int i = 1; i < n; ++i)
            {
                for (int j = 1; j <= v; ++j)
                {
                    int x = T[i - 1, j]; //Case: not selecting the current coin
                    int y = coins[i] <= j ? T[i, j - coins[i]] : 0; // Case: selecting the current coin
                    T[i, j] = x + y;
                }
            }

            return T[n-1, v];
        }
    }
}
