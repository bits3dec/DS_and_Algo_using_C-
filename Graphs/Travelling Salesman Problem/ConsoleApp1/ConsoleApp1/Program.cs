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
            int[,] graph = {{ 0, 10, 15, 20 }, 
                            { 10, 0, 35, 25 }, 
                            { 15, 35, 0, 30 }, 
                            { 20, 25, 30, 0 } 
                           };

            TravellingSalesmanUtility.Tsp(graph);

            Console.ReadKey();
        }
    }
}
