using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata_8
{
    internal class ANeedleInTheHaystack
    {
        public static string FindNeedle(object[] haystack)
        {
            return "found the needle at position " + Array.IndexOf(haystack, "needle");
        }
    }
}
