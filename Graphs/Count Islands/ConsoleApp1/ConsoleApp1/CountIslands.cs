using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //A group of connected 1s form an island
    public class CountIslands
    {
        public static int GetIslandsCount(int[,] g, int m, int n)
        {
            bool[,] visited = new bool[m, n];

            int count = 0;

            for(int i = 0; i < m; ++i)
            {
                for(int j = 0; j < n; ++j)
                {
                    if (visited[i, j] == false && g[i, j] == 1)
                    {
                        DFSUtil(g, i, j, visited, m, n);
                        ++count;
                    }
                }
            }

            return count;
        }

        private static void DFSUtil(int [,] g, int i, int j, bool[,] visited, int m, int n)
        {
            visited[i, j] = true;

            int[] rows = {0, -1, -1, -1, 0, 1, 1, 1 };
            int[] cols = {-1, -1, 0, 1, 1, 1, 0, -1 };

            for(int k = 0; k < 8; ++k)
            {
                int row = rows[k] + i;
                int col = cols[k] + j;
                if(IsSafe(g, row, col, visited, m, n) == true)
                {
                    DFSUtil(g, row, col, visited, m, n);
                }
            }
        }

        private static bool IsSafe(int[,] g, int row, int col, bool[,] visited, int m, int n)
        {
            if (row >= 0 && row < m && col >= 0 && col < n && 
                g[row, col] == 1 &&  visited[row, col] == false)
                return true;

            return false;
        }
    }
}
