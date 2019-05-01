using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SnakeLadder
    {
        // This function returns minimum number of dice  
        // throws required to Reach last cell from 0'th cell  
        // in a snake and ladder game. moves[] is an array of  
        // size n where n is no. of cells on board If there  
        // is no snake or ladder from cell i, then move[i]  
        // is -1 Otherwise move[i] contains cell to which  
        // snake or ladder at i takes to.
        public static int GetMinThrows(int[] moves, int n)
        {
            bool[] visited = new bool[n];
            Queue<Node> queue = new Queue<Node>();
            int minThrows = 0;

            Node qe = new Node();
            qe.V = 0;
            qe.Dist = 0;

            queue.Enqueue(qe);
            visited[0] = true;

            while(queue.Any() == true)
            {
                qe = queue.Dequeue();
                int v = qe.V;

                if(v == n-1)
                {
                    minThrows = qe.Dist;
                    break;
                }

                for(int j = 0; j <= (v + 6) && j < n; ++j)
                {
                    if(visited[j] == false)
                    {
                        Node q = new Node();
                        q.Dist = qe.Dist + 1;

                        if (moves[j] != -1)
                            q.V = moves[j];
                        else
                            q.V = j;

                        queue.Enqueue(q);
                        visited[j] = true;
                    }
                }
            }

            return minThrows;
        }
    }
}
