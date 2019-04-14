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
            Box[] boxes = new Box[4];
            boxes[0] = new Box(4, 6, 7);
            boxes[1] = new Box(1, 2, 3);
            boxes[2] = new Box(4, 5, 6);
            boxes[3] = new Box(10, 12, 32);

            BoxStacking builder = new BoxStacking();

            int res = builder.MaxStackHeight(boxes);

            Console.WriteLine($"The maximum height of the stack is: {res}");

            Console.ReadKey();
        }
    }
}
