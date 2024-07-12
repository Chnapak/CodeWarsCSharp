using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata_6
{
    internal class CreatePhoneNumber
    {
        public static string CreatePhoneNumberSol(int[] number)
        {
            string parentheses = $"{number[0]}{number[1]}{number[2]}";
            string three_dig = $"{number[3]}{number[4]}{number[5]}";
            string four_dig = $"{number[6]}{number[7]}{number[8]}{number[9]}";

            return $"({parentheses}) {three_dig}-{four_dig}";
        }
    }
}
