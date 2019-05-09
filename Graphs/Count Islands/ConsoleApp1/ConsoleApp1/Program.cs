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
            int[,] g = new int[,] {{1, 1, 0, 0, 0},
                               {0, 1, 0, 0, 1},
                               {1, 0, 0, 1, 1},
                               {0, 0, 0, 0, 0},
                               {1, 0, 1, 0, 1}};
            Console.Write("Number of islands is: " + CountIslands.GetIslandsCount(g, 5, 5));

            Console.ReadKey();
        }
    }
}
