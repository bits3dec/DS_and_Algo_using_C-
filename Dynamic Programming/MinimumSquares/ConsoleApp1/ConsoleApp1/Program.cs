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
            MinimumSquare min = new MinimumSquare();

            int number = 7;
            int res = min.MinSquares(number);

            Console.WriteLine($"The minimum number of squares to sum to get number: {number} is: {res}");

            Console.ReadKey();
        }
    }
}
