namespace CodilityProjects
{
    public class TapEquilibrium
    {
        //List<int> AllSum = new List<int>();
        public int solution(int[] A)
        {
            // Implement your solution here

            var minimumDifference = -1;
            for (int mid = 1; mid < A.Length; mid++)
            {
                int[] firstHalf = A.Take(mid).ToArray();
                int[] secondHalf = A.Skip(mid).ToArray();
                var diffrence = Math.Abs(Sum(firstHalf) - Sum(secondHalf));
                if (diffrence < minimumDifference || minimumDifference == -1) { minimumDifference = diffrence; }
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
