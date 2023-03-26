using System;
using System.Collections.Generic;

namespace app10
{
    internal class Randomizer
    {
        public static int[] GetRandomNumber(int quantity, int dozenCount = 1)
        {
            Random rnd = new Random();
            List<int> digits = new List<int>();
            
            int lowest = (int)Math.Pow(10, dozenCount-1);
            int highest = (int)Math.Pow(10, dozenCount);

            for (int i = 0; i < quantity; i++)
                digits.Add(rnd.Next(lowest, highest));

            return digits.ToArray();
        }
    }
}
