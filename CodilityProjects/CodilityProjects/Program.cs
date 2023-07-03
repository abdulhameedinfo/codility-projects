// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Solution solution = new Solution();
int A = 7;
int B = 12;
int K = 3;
int divisibleByK = solution.solution(A, B, K);
Console.WriteLine(String.Format("Number of integers divisible by {0} between {1} & {2} is = {3}", K, A, B,
    divisibleByK));