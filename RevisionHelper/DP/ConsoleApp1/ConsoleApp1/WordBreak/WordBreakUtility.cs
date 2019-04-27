using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.WordBreak
{
    public class WordBreakUtility
    {
        public static void WordBreak(string str, HashSet<string> dictionary)
        {
            int n = str.Length;

            //T[j] denotes if string str(0,j) can be segmented into space separated dictionary words
            bool[] T = new bool[n];

            for(int i = 0; i < n; ++i)
            {
                string prefix = str.Substring(0, i + 1);

                if (T[i] == false && dictionary.Contains(prefix) == true)
                    T[i] = true;

                if(T[i] == true)
                {
                    if(i == n-1)
                    {
                        Console.WriteLine("Possible");
                        return;
                    }
                    for(int k = i + 1; k < n; ++k)
                    {
                        string suffix = str.Substring(i + 1, k - i);

                        if (T[k] == false && dictionary.Contains(suffix) == true)
                            T[k] = true;

                        if (T[k] == true && k == n - 1)
                        {
                            Console.WriteLine("Possible");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("Not Possible");
        }

        public static void WordBreak_2D(string str, HashSet<string> dictionary)
        {
            int n = str.Length;

            bool[,] T = new bool[n, n];

            for(int l = 1; l <= n; ++l)
            {
                for(int i = 0; i <= n-l; ++i)
                {
                    string subStr = str.Substring(i, l);

                    int j = i + l - 1;
                    if(T[i,j] == false && dictionary.Contains(subStr) == true)
                        T[i, j] = true;

                    if(T[i,j] == false)
                    {
                        for(int k = i; k < j; ++k)
                        {
                            if(T[i, k] == true && T[k+1, j] == true)
                                T[i, j] = true;
                        }
                    }
                }
            }

            bool res = T[0, n - 1];

            if(res == true)
                Console.WriteLine("Possible");
            else
                Console.WriteLine("Not Possible");
        }
    }
}
