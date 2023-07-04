using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Solution
{
    public int[] solution(string S, int[] P, int[] Q)
    {
        int[] answers = new int[P.Length];
        int[] prefixSumA = new int[S.Length + 1];
        int[] prefixSumC = new int[S.Length + 1];
        int[] prefixSumG = new int[S.Length + 1];

        for (int i = 0; i < S.Length; i++)
        {
            prefixSumA[i + 1] = prefixSumA[i] + (S[i] == 'A' ? 1 : 0);
            prefixSumC[i + 1] = prefixSumC[i] + (S[i] == 'C' ? 1 : 0);
            prefixSumG[i + 1] = prefixSumG[i] + (S[i] == 'G' ? 1 : 0);
        }

        for (int i = 0; i < P.Length; i++)
        {
            int start = P[i];
            int end = Q[i] + 1;

            if (prefixSumA[end] - prefixSumA[start] > 0)
                answers[i] = 1;
            else if (prefixSumC[end] - prefixSumC[start] > 0)
                answers[i] = 2;
            else if (prefixSumG[end] - prefixSumG[start] > 0)
                answers[i] = 3;
            else
                answers[i] = 4;
        }
        return answers;
    }
}
/* Explanation:

1) Instead of sorting the DNA substring for each query, we can preprocess the counts of 'A', 'C', and 'G' characters 
    using prefix sums. This way, we can quickly calculate the count of each character within a given range.

2) We create three arrays prefixSumA, prefixSumC, and prefixSumG, where prefixSumA[i] represents the count of 'A' characters 
    up to index i in the string S. Similarly, prefixSumC[i] and prefixSumG[i] represent the counts of 'C' and 'G' characters up to index i respectively.

3) By calculating the differences between the prefix sums at the start and end indices of each query range, we can determine the 
    count of each character within that range.
4) Based on the counts, we assign the corresponding values to the answers array, as specified in the original code.

5) The optimized code eliminates the need for sorting and improves the time complexity, making it more efficient.
*/ 
