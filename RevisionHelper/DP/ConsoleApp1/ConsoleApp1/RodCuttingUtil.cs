using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RodCuttingUtil
    {
        public static void MaxValue(int[] prices, int rodLength)
        {
            int n = rodLength;

            //T[j] denotes the maximum value that can be collected cutting a rod of length "j" using lengths lengths[0]..length[j]
            int[] T = new int[n+1];

            T[0] = 0;

            for(int j = 1; j <= n; ++j)
            {
                T[j] = Int32.MinValue;
                for(int i = 1; i <= j; ++i)
                {
                    if (prices[i - 1] + T[j - i] > T[j])
                        T[j] = prices[i - 1] + T[j - i];
                }
            }

            int res = T[n];

            Console.WriteLine($"The maximum value that can be collected cutting a rod of length {rodLength} is: {res}");
        }
    }
}
