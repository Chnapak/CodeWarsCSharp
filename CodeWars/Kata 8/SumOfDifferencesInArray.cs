using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata_8
{
    internal class SumOfDifferencesInArray
    {
        public static int SumOfDifferences(int[] arr)
        {
            return arr.Length > 0 ? arr.Max() - arr.Min() : 0;
        }
    }
}
