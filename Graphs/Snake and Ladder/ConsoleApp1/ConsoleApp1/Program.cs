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
            int N = 30;
            int[] moves = new int[N];
            for (int i = 0; i < N; i++)
                moves[i] = -1;

            // Ladders  
            moves[2] = 21;
            moves[4] = 7;
            moves[10] = 25;
            moves[19] = 28;

            // Snakes  
            moves[26] = 0;
            moves[20] = 8;
            moves[16] = 3;
            moves[18] = 6;

            Console.WriteLine("Min Dice throws required is: "+ SnakeLadder.GetMinThrows(moves, N));

            Console.ReadKey();
        }
    }
}
