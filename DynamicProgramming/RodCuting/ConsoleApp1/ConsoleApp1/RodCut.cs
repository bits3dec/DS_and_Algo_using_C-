using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RodCut
    {
        public int MaxProfit(int[] price, int n)
        {
            //V[j] denotes the maximum profit that we can get cutting a rod of length n
            int[] V = new int[n + 1];
            V[0] = 0;

            for(int j = 1; j <= n; ++j)
            {
                int maxValue = Int32.MinValue;
                for(int i = 1; i <= j; ++i)
                {
                    int value = price[i - 1] + V[j - i];
                    if(value > maxValue)
                        maxValue = value;
                }
                V[j] = maxValue;
            }

            return V[n];
        }
    }
}
