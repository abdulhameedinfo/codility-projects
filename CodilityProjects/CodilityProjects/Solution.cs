using System;
using System.Numerics;
class Solution
{
    public int solution(int A, int B, int K)
    {
        // Implement your solution here
        int divisibleByK = 0;

        if (A % K == 0)
            divisibleByK = (B - A) / K + 1;
        else
            divisibleByK = (B - (A - A % K)) / K;

        return divisibleByK;
    }
}