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
            int[] arr = new int[]{1, 2, 3, 4, 3};

            MatrixMultiplication calculator = new MatrixMultiplication();

            int res = calculator.MatrixChainOrder(arr);
            Console.Write($"Minimum number of multiplications is: {res}");

            Console.ReadKey();
        }
    }
}
