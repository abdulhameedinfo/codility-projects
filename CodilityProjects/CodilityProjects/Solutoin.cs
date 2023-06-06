public class Solution
{
    public int solution(int[] A)
    {
        int distinctCount = A.Distinct().Count();
        Array.Sort(A);

        return (A[A.Length - 1] == distinctCount && A[A.Length - 1] == A.Length) ? 1 : 0;
    }
}