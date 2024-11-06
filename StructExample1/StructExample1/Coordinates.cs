using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample1
{
    public struct Coordinates
    {
        private int x;
        private int y;

        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Print()
        {
            Console.WriteLine(x + "  " + y);
        }
    }
}
