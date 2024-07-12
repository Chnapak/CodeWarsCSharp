using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata_8
{
    internal class CheckSameCase
    {
        public static int SameCase(char a, char b)
        {
            bool isAChar = (int)a > 64 && (int)a < 123 && !((int)a > 90 && (int)a < 97);
            bool isBChar = (int)b > 64 && (int)b < 123 && !((int)b > 90 && (int)b < 97);

            bool isAUpperCase = (int)a > 64 && (int)a <= 90;
            bool isBUpperCase = (int)b > 64 && (int)b <= 90;

            if (isAChar && isBChar)
            {
                if ((isAUpperCase ^ isBUpperCase))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            return -1;
        }
    }
}
