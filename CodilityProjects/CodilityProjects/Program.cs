// See https://aka.ms/new-console-template for more information
Solution solution = new Solution();
int missingPositiveInteger = solution.solution(new int[] { 1, 2, 3, -1 });
Console.WriteLine(String.Format("Missing positive integer is {0}", missingPositiveInteger));