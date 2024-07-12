using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata_5
{
    internal class FirstNonRepeatingLetter
    {
        public static string FirstNonRepeatingLetterSol(string s)
        {
            return s.Distinct() != String.Empty ? s[0].ToString() : String.Empty;
        }
    }
}
