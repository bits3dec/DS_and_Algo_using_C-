using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EditDistanceUtility
    {
        //Transform str1 to str2
        //Operations: 1) Insert 2) Delete 3) Replace 4) No Edit
        public static void MinEdit(string str1, string str2)
        {
            int m = str1.Length;
            int n = str2.Length;

            //T[i,j] denotes the minimum edit operations needed to transform str1[0]...str1[j-1] to str2[0]...str[i-1]
            int[,] T = new int[n + 1, m + 1];

            //Transforming empty string "" to str2[0]...str2[i-1] will take "i" insert operations 
            for (int i = 0; i <= n; ++i)
                T[i, 0] = i; 

            //Transforming str1[0]...str[j-1] to empty string "" will take "j" delete operations
            for (int j = 0; j <= m; ++j)
                T[0, j] = j;

            for(int j = 1; j <= m; ++j)
            {
                for(int i = 1; i <= n; ++i)
                {
                    if(str1[j-1] == str2[i-1])
                    {
                        T[i, j] = T[i - 1, j - 1]; //No edit
                    }
                    else
                    {
                        int insertCost = T[i - 1, j] + 1; //Insert
                        int deleteCost = T[i, j - 1] + 1; //Delete
                        int replaceCost = T[i - 1, j - 1] + 1; //Replace

                        T[i, j] = Min(insertCost, deleteCost, replaceCost);
                    }
                }
            }

            int res = T[n, m];

            Console.WriteLine($"The minimum edit cost to transform \"{str1}\" to \"{str2}\" is: {res}");
        }

        private static int Min(int x, int y, int z)
        {
            return Math.Min(x, Math.Min(y, z));
        }
    }
}
