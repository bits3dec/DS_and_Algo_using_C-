using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PatternMatchingUtility
    {
        /*
           Proper prefix example: "ABC" -> "", "A", "AB" are proper prefix but not "ABC"
           Proper suffix example: "ABC" -> "", "C", "BC" are proper suffix but not "ABC"
           lps: longest prefix suffix table
           lps[j] denotes the length of the longest proper prefix which is also a suffix in pat[0]....pat[j]
           i.e. if there is a mismatch at pat[j+1], lps[j] will give us the num of characters to skip in the next window
           since we already know that there is a prefix which is also a prefix of length lps[j] we can avoid checking them 
           P.S-To construct a lps table we check for every indices if there is prefix which is also a suffix
        */
        //T: O(m + n) S:O(n) where m=len(text), n=len(pat)
        public static void KMP(string text, string pat)
        {
            int m = text.Length;
            int n = pat.Length;

           
            int[] lps = new int[n];

            constructlps(lps, pat);

            int i = 0;//index for text
            int j = 0;//index for pattern

            while(i < m)
            {
                if(text[i] == pat[j])
                {
                    ++i;
                    ++j;
                }

                if(j == n)
                {
                    Console.WriteLine($"Found pattern at index: {i-j}");
                    j = lps[j - 1];//Reset the index "j" for the next window
                }

                //If there is a mismatch at pat[j] the pattern check how many characters to skip checking in the next window
                if(i < m && text[i] != pat[j])
                {
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        ++i;
                }
            }
        }

        private static void constructlps(int[] lps, string pat)
        {
            int len = 0;//len denotes the length of the previous longest prefix suffix
            int n = pat.Length;
            int i = 1;

            lps[0] = 0;//Always

            while(i < n)
            {
                if(pat[len] == pat[i])
                {
                    ++len;
                    lps[i] = len;
                    ++i;
                }
                else
                {
                    if (len != 0)
                        len = lps[len - 1];
                    else
                    {
                        lps[i] = len;
                        ++i;
                    }
                }
            }
        }
    }
}
