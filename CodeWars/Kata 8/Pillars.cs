using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata_8
{
    internal class Pillars
    {
       public static class Kata
        {
            public static int Pillars(int numPill, int dist, int width)
            {
                int constA, constB;
                constA = (numPill > 2) ? (numPill - 2) : 0;
                constB = (numPill > 1) ? (numPill - 1) : 0;
                return constB * dist * 100 + constA * width;

                
            }
        }
    }
}
