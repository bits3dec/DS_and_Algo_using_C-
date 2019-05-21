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
            string text = "ABABDABACDABABCABAB";
            string pat = "ABABCABAB";

            PatternMatchingUtility.KMP(text, pat);

            Console.ReadKey();
        }
    }
}
