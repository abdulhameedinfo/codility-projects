namespace CodilityProjects
{
    public class TapEquilibrium
    {
        //List<int> AllSum = new List<int>();
        public int solution(int[] A)
        {
            int sum = Sum(A);
            int leftSum = 0;
            int minimumDifference = -1;
            for (int mid = 1; mid < A.Length; mid++)
            {
                leftSum += A[mid - 1];
                int rightSum = sum - leftSum;
                int difference = Math.Abs(leftSum - rightSum);
                if (minimumDifference == -1 || difference < minimumDifference)
                {
                    minimumDifference = difference;
                }
            }
            return minimumDifference;
        }

        public int Sum(int[] A)
        {
            int sum = 0;
            foreach (var el in A)
            {
                sum += el;
            }
            return sum;
        }
    }
}
