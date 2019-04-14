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
            int[] arr = { 3, 34, 4, 12, 5, 2 };
            int sum = 9;

            CheckSum checker = new CheckSum();

            bool sumExists = checker.SumExists(arr, sum);
            if(sumExists == true)
                Console.WriteLine($"There exisits a subset with sum: {sum}");
            else
                Console.WriteLine($"There is no subset with the given sum: {sum}");

            Console.ReadKey();
        }
    }
}
