using System;

namespace CodeWars.Kata_8
{
    internal class GravityFlip
    {
        public int[] Solution_0(char dir, int[] arr)
        {
            Console.WriteLine(arr.Min());

            Array.Sort(arr);

            if (dir == 'L')
            {
                Array.Reverse(arr);
            }

            return arr;
        }
    }
}
