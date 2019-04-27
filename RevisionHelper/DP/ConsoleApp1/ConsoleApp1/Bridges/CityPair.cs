using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Bridges
{
    public class CityPair
    {
        public CityPair(int x_North, int x_South)
        {
            this.x_North = x_North;
            this.x_South = x_South;
        }
        public int x_North { get; private set; }
        public int x_South { get; private set; }
    }
}
