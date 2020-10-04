using System;
using System.Collections.Generic;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            List<int> ret = new List<int>();
            foreach(int num in numbers)
            {
                if (num % 2 == 0)
                    ret.Add(num);
            }
            return ret.ToArray();
        }
    }
}
