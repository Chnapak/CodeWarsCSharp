using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata_8
{
    internal class TotalAmountOfPoints
    {
        public static int TotalPoints(string[] games)
        {
            int sum = 0;
            for (int i = 0; i < games.Length; i++)
            {
                string score = games[i];
                string[] points = score.Split(':');

                if (int.Parse(points[0]) > int.Parse(points[1]))
                {
                    sum += 3;
                }
                else if (int.Parse(points[0]) == int.Parse(points[1]))
                {
                    sum++;
                }
            }
            return sum;
        }
    }
}
