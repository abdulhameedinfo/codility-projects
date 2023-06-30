// See https://aka.ms/new-console-template for more information
using CodilityProjects;

Console.WriteLine("Hello, World!");

Solution solution = new Solution();
int passingPairs = solution.NoOfPassingCars(new int[] { 1, 0, 0, 0, 1, 0, 1});

Console.WriteLine("No of passing pairs: " + passingPairs);
