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
            HashSet<string> dictionary = WordUtility.GetDictionary();
            string inputString = WordUtility.GetInputString();

            WordBreakHelper(inputString, dictionary);

            Console.ReadKey();
        }

        private static void WordBreakHelper(string inputString, HashSet<string> dict)
        {
            Console.WriteLine("-----Recursive-----");
            Console.Write($"{inputString} : ");
            if (WordBreak.WordBreak_Recursive(inputString, dict))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            Console.WriteLine("\n");

            Console.WriteLine("-----DP-----");
            Console.Write($"{inputString} : ");
            if (WordBreak.WordBreak_Recursive(inputString, dict))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            Console.WriteLine("\n");

            Console.WriteLine("-----DP_SpaceOptimized-----");
            Console.Write($"{inputString} : ");
            if (WordBreak.WordBreak_Recursive(inputString, dict))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
