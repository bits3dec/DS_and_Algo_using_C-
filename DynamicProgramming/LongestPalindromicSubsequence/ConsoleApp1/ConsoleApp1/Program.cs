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
            string str = "AGCTCBMAACTGGAM";

            LongestPalindromeSubsequence lps = new LongestPalindromeSubsequence();
            int res = lps.LPS(str);
            Console.WriteLine($"The length of longest palindromic subsequence is: {res}");

            Console.ReadKey();
        }
    }
}
