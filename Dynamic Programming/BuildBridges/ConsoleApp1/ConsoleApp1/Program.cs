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
            CityPair city_A = new CityPair(6, 2);
            CityPair city_B = new CityPair(4, 3);
            CityPair city_C = new CityPair(2, 6);
            CityPair city_D = new CityPair(1, 5);

            CityPair[] cityPairs = { city_A, city_B, city_C, city_D };

            BridgeBuilder builder = new BridgeBuilder();

            int res = builder.MaxBridge(cityPairs);

            Console.WriteLine($"The maximum num of bridges that can be build is: {res}");

            Console.ReadKey();
        }
    }
}
