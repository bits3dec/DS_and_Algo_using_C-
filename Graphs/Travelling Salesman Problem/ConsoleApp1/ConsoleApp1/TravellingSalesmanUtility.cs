using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TravellingSalesmanUtility
    {
        //T:O(n!)
        public static void Tsp(int[,] g)
        {
            int n = g.GetLength(0);
            bool[] visited = new bool[n];
            int ans = Int32.MaxValue;

            visited[0] = true;
            TspUtil(g, 1, 0, 0, ref ans, visited, n);

            if(ans == Int32.MaxValue)
                Console.WriteLine("No path exist");
            else
                Console.WriteLine(ans);
        }

        private static void TspUtil(int[,] g, int count, int currPos, int cost, ref int ans, bool[] visited, int n)
        {
            if(count == n)
            {
                if(g[currPos, 0] != 0)
                {
                    ans = Math.Min(ans, cost + g[currPos, 0]);
                    return;
                }
            }
            else
            {
                for(int i = 0; i < n; ++i)
                {
                    if(g[currPos, i] != 0 && visited[i] == false)
                    {
                        visited[i] = true;
                        TspUtil(g, count+1, i, cost + g[currPos, i], ref ans, visited, n);
                        visited[i] = false;
                    }
                }
            }
        }
    }
}
