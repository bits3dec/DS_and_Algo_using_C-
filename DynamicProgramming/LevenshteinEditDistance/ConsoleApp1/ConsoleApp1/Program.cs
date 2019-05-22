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
            string str1 = "sunday";
            string str2 = "saturday";

            EditDistance calculator = new EditDistance();

            int res = calculator.MinEdit(str1, str2, str1.Length, str2.Length);

            Console.WriteLine($"The minimum edit operations need to transform \"{str1}\" to \"{str2}\" is: {res}");

            Console.ReadKey();
        }
    }
}
