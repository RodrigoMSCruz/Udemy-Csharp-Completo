using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 15.Exemplo.04.Entities
{
    struct Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y): this()
        {
            X = x;
            Y = y;
        }
    }

}