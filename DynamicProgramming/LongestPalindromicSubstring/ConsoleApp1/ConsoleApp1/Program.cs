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
            string str = "forgeeksskeegfor";

            LongestPalindromicSubstring lps = new LongestPalindromicSubstring();
            string res = lps.LPS(str);
            Console.WriteLine($"The longest palindromic substring is: \"{res}\" of length: {res.Length}");

            Console.ReadKey();
        }
    }
}
