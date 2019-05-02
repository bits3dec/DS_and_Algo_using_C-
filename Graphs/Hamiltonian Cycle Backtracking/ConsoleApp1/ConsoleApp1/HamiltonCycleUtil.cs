using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HamiltonianUtil
    {
        //T:O(n!) Backtracking: NP Hard Problem (Non-deterministic Polynomial time hardness)
        public static void CheckHamiltonCycle(int[,] g, int N, int s)
        {
            int[] path = new int[N];

            for (int i = 0; i < N; ++i)
                path[i] = -1;

            path[0] = s;//Fix the start index as vertex "s" since if it is a cycle the starting point doesnot matter

            if (HamiltonCycleUtil(g, N, path, 1) == true)
                PrintPath(path, N);
            else
                Console.WriteLine("No Hamilton Cycle");
        }

        private static bool HamiltonCycleUtil(int[,] g, int N, int[] path, int pos)
        {
            if(pos == N)
            {
                if (g[path[pos - 1], 0] == 1)
                    return true;

                return false;
            }

            //Check for all the vertices
            for(int v = 0; v < N; ++v)
            {
                if(IsSafe(g, N, path, pos, v) == true)
                {
                    path[pos] = v;

                    if (HamiltonCycleUtil(g, N, path, pos + 1) == true)
                        return true;

                    path[pos] = -1;//Remove the path[pos] if it doesnot lead to a solution
                }
            }
            return false;
        }

        private static bool IsSafe(int[,] g, int N, int[] path, int pos, int v)
        {
            //check if there exist an edge from previous vertex in the path to this vertex
            if (g[path[pos - 1], v] == 0)
                return false;

            //check if the vertex already exist in the path
            for (int i = 0; i < N; ++i)
                if (path[i] == v)
                    return false;

            return true;
        }

        private static void PrintPath(int[] path, int N)
        {
            for (int i = 0; i < N; ++i)
                Console.Write(path[i] + " ");

            Console.Write(path[0]);
            Console.WriteLine();

        }
    }
}
