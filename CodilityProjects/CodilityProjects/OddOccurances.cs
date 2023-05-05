using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityProjects
{
    public static class OddOccurances
    {
        public static int solution(int[] A)
        {
            // Implement your solution here
            int result = 0;
            foreach (int number in A)
            {
                result ^= number; // use bitwise XOR operator to find the unpaired element
            }
            return result;
        }
    }
}
