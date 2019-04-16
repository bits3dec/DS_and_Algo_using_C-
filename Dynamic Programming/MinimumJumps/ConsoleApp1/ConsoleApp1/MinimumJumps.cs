using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MinimumJumps
    {
        public int MinJumps(int[] arr)
        {
            int n = arr.Length;

            if (n == 0 || arr[0] == 0)
                return Int32.MaxValue;

            //jumps[i] denotes the minimum num of jumps needed to reach "i".
            int[] jumps = new int[n];

            jumps[0] = 0;

            for(int j = 1; j < n; ++j)
            {
                jumps[j] = Int32.MaxValue;
                for(int i = 0; i < j; ++i)
                {
                    if (i + arr[i] >= j && jumps[i] != Int32.MaxValue)
                        jumps[j] = Math.Min(jumps[i] + 1, jumps[j]);
                }
            }

            return jumps[n - 1];
        }
    }
}
