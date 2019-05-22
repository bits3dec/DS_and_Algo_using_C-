using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 22, 9, 33, 21, 50, 41, 60 };

            LongestIncreasingSubsequence obj = new LongestIncreasingSubsequence();

            int res = obj.LIS(arr);

            Console.WriteLine($"The longest increasing subsequence is: {res}");

            Console.ReadKey();
        }
    }
}
