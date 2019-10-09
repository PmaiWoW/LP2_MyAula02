using System;
using System.Collections.Generic;
using System.Text;

namespace Tuples
{
    struct Stuff
    {
        public int I { get; set; }
        public double D { get; set; }
        public bool B { get; set; }

        public Stuff(int i, double d, bool b)
        {
            I = i;
            D = d;
            B = b;
        }
    }
}
