using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class WordBreak
    {
        public static bool WordBreak_Recursive(string str, HashSet<string> dict)
        {
            if (string.IsNullOrEmpty(str))
                return true;

            int size = str.Length;

            for(int i = 1; i <= size; ++i)
            {
                string prefix = str.Substring(0, i);
                string suffix = str.Substring(i);

                if (dict.Contains(prefix) == true && WordBreak_Recursive(suffix, dict))
                    return true;
            }

            return false;
        }

        //T: O(n^3) S:O(n^2)
        public static bool WordBreak_DP(string word, HashSet<string> dict)
        {
            if (string.IsNullOrEmpty(word))
                return true;

            int n = word.Length;

            //T[i,j] denotes the index at which the word can be splitted so that the substring [Si...Sj] are present in the dictionary
            int[,] T = new int[n, n];

            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                    T[i, j] = -1;

            for(int l = 1; l <= n; ++l)
            {
                for(int i = 0; i <= n-l; ++i)
                {
                    int j = i + l - 1;

                    string str = word.Substring(i, l);
                    if (dict.Contains(str) == true)
                    {
                        T[i, j] = i;
                    }
                    else
                    {
                        for(int k = i; k < j; ++k)
                        {
                            if (T[i, k] != -1 && T[k + 1, j] != -1)
                            {
                                T[i, j] = k;
                                break;
                            }
                        }
                    }
                }
            }

            return T[0, n - 1] != -1;
        }

        //Preferred method T:O(n^2) S:O(n)
        public static bool WordBreak_DP_SpaceOptimized(string word, HashSet<string> dictionary)
        {
            if(string.IsNullOrEmpty(word))
                return true;

            int n = word.Length;
            bool[] T = new bool[n];

            for(int i = 0; i < n; ++i)
            {
                string prefix = word.Substring(0, i + 1);
                if (T[i] == false && dictionary.Contains(prefix) == true)
                    T[i] = true;

                if(T[i] == true)
                {
                    if (i == n - 1)
                        return true;

                    for(int k = i+1; k < n; ++k)
                    {
                        string suffix = word.Substring(i + 1, k-i);
                        if (T[k] == false && dictionary.Contains(suffix))
                            T[k] = true;

                        if (T[k] == true && k == n - 1)
                            return true;
                    }
                }
            }

            //we have checked all possible prefixes and suffixes but there were no combinations satisfying our word break problem
            return false;
        }
    }
}
