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
            int[,] cost = {{1, 2, 3},
                           {4, 8, 2},
                           {1, 5, 3}};
            int m = 2;
            int n = 2;

            MinimumCost calculator = new MinimumCost();

            int res = calculator.MinCost(cost, m, n);
            Console.WriteLine($"The total minimum cost to reach ({m}, {n}) from (0, 0) is: {res}");

            Console.ReadKey();
        }
    }
}
