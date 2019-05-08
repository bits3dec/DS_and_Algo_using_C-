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
            int[] hist = new int[] { 6, 2, 5, 4, 5, 1, 6 };
            Console.WriteLine("Maximum area is " + MaximumHistogramArea.GetMaxArea(hist));

            Console.ReadKey();
        }
    }
}


