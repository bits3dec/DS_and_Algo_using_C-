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
            int[,] M1 = {{0, 1, 1, 0}, 
                         {1, 1, 1, 1}, 
                         {1, 1, 1, 1}, 
                        };

            int res1 = MaximumRectangularSubMatrixWith1s.GetMaxSubmatrixSize(M1);
            Console.WriteLine("Area of maximum rectangle is:" + res1);

            int[,] M2 = {{0, 1, 1, 0, 1},  
                         {1, 1, 0, 1, 0},  
                         {0, 1, 1, 1, 0},  
                         {1, 1, 1, 1, 0},  
                         {1, 1, 1, 1, 1},  
                         {0, 0, 0, 0, 0}};

            int res2 = MaximumSquareSubmatrixWith1s.GetMaxSquareSubmatrixSize(M2);
            Console.WriteLine("Area of maximum square is:" + res2);

            Console.ReadKey();
        }
    }
}
