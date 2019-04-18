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
            int[] price = new int[] { 1, 5, 8, 9, 10, 17, 17, 20 };
            int rodLength = price.Length;

            RodCut calculator = new RodCut();

            int res = calculator.MaxProfit(price, rodLength);
            Console.WriteLine($"The maximum profit that we can get cutting a rod of length {rodLength} is: {res}");

            Console.ReadKey();
        }
    }
}
