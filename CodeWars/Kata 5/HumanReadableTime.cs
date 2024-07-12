using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata_5
{
    internal class HumanReadableTime
    {
        public static string GetReadableTime(int seconds)
        {
            string hrs = (seconds / 3600) > 9 ? (seconds / 3600).ToString() : "0" + (seconds / 3600).ToString();
            string min = (seconds % 3600) / 60 > 9 ? ((seconds % 3600) / 60).ToString() : "0" + ((seconds % 3600) / 60).ToString();
            string sec = (seconds % 3600) % 60 > 9 ? ((seconds % 3600) % 60).ToString() : "0" + ((seconds % 3600) % 60).ToString();

            return $"{hrs}:{min}:{sec}";
        }
    }
}
