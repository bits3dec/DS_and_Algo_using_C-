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
            int N = 31;
            Cell source = new Cell(0, 0);
            Cell dest = new Cell(30, 30);

            int minSteps = ChessKnightUtility.GetMinSteps(source, dest, N);

            if(minSteps != Int32.MaxValue)
                Console.WriteLine("The min steps for the knight to reach the destination is: " + minSteps);
            else
                Console.WriteLine("The destination is not reachable");

            Console.ReadKey();
        }
    }
}
