using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ChessKnightUtility
    {
        public static int GetMinSteps(Cell source, Cell dest, int n)
        {
            int[] rows = { -2, -2, -1, -1, 1, 1, 1, 2, 2 };
            int[] cols = { -1, 1, -2, 2, -2, 2, -1, 1 };

            int minSteps = Int32.MaxValue;
            bool[,] visited = new bool[n, n];

            Queue<Cell> queue = new Queue<Cell>();
            queue.Enqueue(source);
            visited[source.x, source.y] = true;

            while(queue.Any() == true)
            {
                Cell u = queue.Dequeue();

                if(u.x == dest.x && u.y == dest.y)
                {
                    minSteps = u.dist;
                    break;
                }

                for(int j = 0; j < 8; ++j)
                {
                    int row = u.x + rows[j];
                    int col = u.y + cols[j];

                    if(IsValid(row, col, n) && visited[row, col] == false)
                    {
                        Cell v = new Cell(row, col, u.dist + 1);
                        queue.Enqueue(v);
                        visited[row, col] = true;
                    }
                }
            }

            return minSteps;
        }

        private static bool IsValid(int x, int y, int n)
        {
            if (x < 0 || y < 0 || x >= n || y >= n)
                return false;

            return true;
        }
    }
}
