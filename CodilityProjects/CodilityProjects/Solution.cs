using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProjects
{
    public class Solution
    {
        public int NoOfPassingCars(int[] A)
        {
            int ZerrosCount = 0;
            int PassingPairs = 0;
            foreach (int car in A)
            {
                if (car == 0)
                    ZerrosCount++;
                else
                {
                    PassingPairs += ZerrosCount;
                    if (PassingPairs > 100000)
                        return -1;
                }
            }
            return PassingPairs;
        }
    }
}
