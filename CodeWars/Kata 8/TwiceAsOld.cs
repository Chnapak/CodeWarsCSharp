using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata_8
{
    internal class TwiceAsOld
    {    
        public static int TwiceAsOldSol(int dadYears, int sonYears)
        {
           return Math.Abs(dadYears - 2 * sonYears);
        }
    }
}
