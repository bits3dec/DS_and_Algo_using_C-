using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class KnapsackProblemUtility
    {
        //T:O(n*W) S:O(n*W)
        public static void KnapsackProblem_01(int[] val, int[] wt, int W)
        {
            int n = val.Length;

            //T[i,j] denotes the maximum value that we can collect from arr[0]....arr[i-1]
            int[,] T = new int[n + 1, W + 1];

            for(int i = 0; i <= n; ++i)
            {
                for(int j = 0; j <= W; ++j)
                {
                    if (i == 0 || j == 0)
                        T[i, j] = 0;

                    else
                    {
                        if (wt[i - 1] > j)
                            T[i, j] = T[i - 1, j];

                        else
                        {
                            T[i, j] = Math.Max(val[i - 1] + T[i - 1, j - wt[i - 1]],
                                               T[i - 1, j]);
                        }
                    }
                }
            }
            int res = T[n, W];
            Console.WriteLine($"The maximum value that can be collected with capacity {W} is: {res}");
        }

        //T:O(nlogn)
        public static void FractionalKnapsackProblem(int[] val, int[] wt, int W)
        {
            int n = val.Length;
            Item[] items = new Item[n];

            for (int i = 0; i < n; ++i)
                items[i] = new Item(val[i], wt[i]);

            Array.Sort(items, new Comparison<Item>( (i1, i2) => (i2.ratio).CompareTo(i1.ratio)) );

            int currentWeight = 0;
            double finalValue = 0;

            for(int i = 0; i < n; ++i)
            {
                if (currentWeight + items[i].wt <= W)
                {
                    currentWeight += items[i].wt;
                    finalValue += items[i].val;
                }

                else
                {
                    int remainingWeight = W - currentWeight;

                    finalValue += items[i].val * ((double)remainingWeight / items[i].wt);
                    break;
                }
            }

            Console.WriteLine($"The maximum value that can be collected with capacity {W} is: {finalValue}");
        }

        private class Item
        {
            public int val;
            public int wt;
            public double ratio;

            public Item(int val, int wt)
            {
                this.val = val;
                this.wt = wt;
                ratio = val / wt;
            }
        }
    }
}
