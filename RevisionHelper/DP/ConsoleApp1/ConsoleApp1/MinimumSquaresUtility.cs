using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MinimumSquaresUtility
    {
        public static void MinimumSquares(int n)
        {
            //T[j] denotes the minimum num of squares needed to sum to get a number "j"
            int[] T = new int[n + 1];
            T[0] = 0;

            //Number of squares to get a number "j" is j by default as every number can be represented as summation of square(1)
            for (int i = 0; i <= n; ++i)
                T[i] = i;

            for(int j = 1; j <= n; ++j)
            {
                for(int i = 1; i <= Math.Sqrt(j); ++i)
                {
                    int x = i * i;
                    if(x <= j)
                    {
                        if (T[j - x] + 1 < T[j])
                            T[j] = T[j - x] + 1;
                    }
                }
            }

            int res = T[n];

            Console.WriteLine($"The minimum number of squares needed to sum to get {n} is: {res}");
        }
    }
}
