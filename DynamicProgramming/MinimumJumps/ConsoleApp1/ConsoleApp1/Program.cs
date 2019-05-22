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
            int[] arr = { 1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9 };

            MinimumJumps minJump = new MinimumJumps();

            int res = minJump.MinJumps(arr);
            if(res != Int32.MaxValue)
                Console.WriteLine($"The minimum num of jumps to reach the end is : {res}");
            else
                Console.WriteLine("It is not possible to reach the end");

            Console.ReadKey();
        }
    }
}
