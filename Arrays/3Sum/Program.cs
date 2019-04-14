using System;
using System.Collections.Generic;

namespace _3Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution obj = new Solution();
            int[] nums = {-1, 0, 1, 2, -1, -4};
            var res = obj.ThreeSum(nums);
        }
    }
}
