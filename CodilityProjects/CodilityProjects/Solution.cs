using System;
using System.Collections.Generic;

class Solution
{
    public int solution(int X, int[] A)
    {
        HashSet<int> positions = new HashSet<int>();

        for (int i = 0; i < A.Length; i++)
        {
            positions.Add(A[i]);

            if (positions.Count == X)
                return i;
        }

        return -1;
    }
}