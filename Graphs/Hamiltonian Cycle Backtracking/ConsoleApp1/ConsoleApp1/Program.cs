using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int s = 0;
            int[,] graph1 = {{0, 1, 0, 1, 0},
                             {1, 0, 1, 1, 1},
                             {0, 1, 0, 0, 1},
                             {1, 1, 0, 0, 1},
                             {0, 1, 1, 1, 0},
                            };
            N = graph1.GetLength(0);
            s = 0;//Start index is vertex 0
            HamiltonianUtil.CheckHamiltonCycle(graph1, N, s);

            int[,] graph2 = {{0, 1, 0, 1, 0},
                             {1, 0, 1, 1, 1},
                             {0, 1, 0, 0, 1},
                             {1, 1, 0, 0, 0},
                             {0, 1, 1, 0, 0},
                            };
            N = graph1.GetLength(0);
            s = 0;
            HamiltonianUtil.CheckHamiltonCycle(graph2, N, s);

            Console.ReadKey();
        }
    }
}
