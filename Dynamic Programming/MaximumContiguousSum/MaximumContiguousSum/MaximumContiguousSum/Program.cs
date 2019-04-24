using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumContiguousSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -2, -3, 4, -1, -2, 1, 5, -3 };

            MaxContiguousSumUtility.MaxContiguousSum(arr);
            MaxContiguousSumUtility_DP.MaxContiguousSum(arr);

            Console.ReadKey();
        }
    }
}
