using System;
using System.Linq;

class Solution
{
    public int solution(int[] A)
    {
        Array.Sort(A); // Sort the array in ascending order

        int minPositiveInteger = 1;
        foreach (var el in A)
        {
            if (el == minPositiveInteger)
                minPositiveInteger++;
            else if (el > minPositiveInteger)
                break; // Exit the loop if we find a gap

            // Ignore negative numbers and duplicates
        }

        return minPositiveInteger;
    }
}




