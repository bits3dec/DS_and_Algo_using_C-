using System;

namespace LongestPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "geeksforgeekskeeg";
            LongestPalindrome(text);
        }

        private static void LongestPalindrome(string text)
        {
            if(string.IsNullOrEmpty(text))
                return ;

            var str = text.ToCharArray();
            int n = str.Length;

            bool[,] table = new bool[n,n];
            int startIndex = 0;
            int maxLength = 1;

            for(int i = 0; i < n; ++i)
                table[i, i] = true;

            for(int i = 0; i < n-1; ++i)
            {
                if(str[i] == str[i+1])
                {
                    table[i, i+1] = true;
                    startIndex = i;
                    maxLength = 2;
                }
            }

            for(int k = 3; k <= n; ++k)
            {
                for(int i = 0; i < n-k+1; ++i)
                {
                    int j = i+k-1;
                    if(table[i+1, j-1] == true && str[i] == str[j])
                    {
                        table[i, j] = true;
                        if(k > maxLength)
                        {
                            maxLength = k;
                            startIndex = i;    
                        }
                    }

                }
            }

            System.Console.WriteLine("The longest palindrome in " + text + " is at: " + startIndex );

            System.Console.WriteLine("Palindrome: ");
            int count = 0;
            for(int i = startIndex; count < maxLength; ++i)
            {
                System.Console.Write(str[i]);
                ++count;                
            }
        }
    }
}
