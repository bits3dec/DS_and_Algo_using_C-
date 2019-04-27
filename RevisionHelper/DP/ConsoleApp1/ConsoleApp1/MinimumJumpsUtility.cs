using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MinimumJumpsUtility
    {
        public static void MinJumps(int[] arr)
        {
            int n = arr.Length;
            if(n == 0 || arr[0] == 0)
            {
                Console.WriteLine("End is not reachable");
                return;
            }

            //Jumps[j] denotes the minimum number of jumps needed to reach "j"
            int[] Jumps = new int[n];
            Jumps[0] = 0;

            for(int j = 1; j < n; ++j)
            {
                Jumps[j] = Int32.MaxValue;
                for(int i = 0; i < j; ++i)
                {
                    if (i + arr[i] >= j && Jumps[i] != Int32.MaxValue)
                        Jumps[j] = Math.Min(Jumps[i] + 1, Jumps[j]);
                }
            }

            int minJumps = Jumps[n - 1];

            Console.WriteLine($"The minimum num of jumps needed to reach the end is {minJumps}");
        }
    }
}
