using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        // Implement your solution here
        Array.Sort(A);
        int minPositiveInteger = 1;
        int missingPositiveInteger = 0;
        foreach (var el in A)
        {
            if (el != minPositiveInteger)
                missingPositiveInteger = minPositiveInteger;
            else
                minPositiveInteger++;
        }
        if (missingPositiveInteger == 0)
            missingPositiveInteger = minPositiveInteger;

        return missingPositiveInteger;
    }
}
