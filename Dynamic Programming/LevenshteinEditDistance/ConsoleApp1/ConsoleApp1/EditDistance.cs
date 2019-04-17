using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    // Operations: 1)No Edit 2)Delete 3)Replace 4)Insert
    public class EditDistance
    {
        public int MinEdit(string s1, string s2, int m, int n)
        {
            //T[i,j] denotes the min number of edits required to transform s1(0,j-1) to s2(0,i-1)
            int[,] T = new int[n+1, m+1];

            for(int i = 0; i <= n; ++i)
            {
                for(int j = 0; j <= m; ++j)
                {
                    if(i == 0)
                    {
                        T[i, j] = j;//To transform s1(0,j-1)-> "" empty string we need to delete all the characters of s1
                        continue;
                    }
                    if(j == 0)
                    {
                        T[i, j] = i;//To transform empty string "" -> s2(0,i-1)
                        continue;
                    }

                    if (s1[j - 1] == s2[i - 1])
                        T[i, j] = T[i - 1, j - 1]; //No edit operation
                    else
                    {
                        T[i, j] = Min( 1 + T[i, j - 1],      //Delete
                                       1 + T[i - 1, j - 1],  //Replace
                                       1 + T[i - 1, j]       //Insert
                                     );     
                    }
                }
            }

            return T[n, m];
        }

        private int Min(int x, int y, int z)
        {
            return Math.Min(x, Math.Min(y, z));
        }
    }
}
