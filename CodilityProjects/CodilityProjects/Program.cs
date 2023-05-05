// See https://aka.ms/new-console-template for more information
using CodilityProjects;

//var converter = new BinaryConverter();
//var gapFinder = new BinaryGapFinder();
//var printer = new BinaryGapPrinter();

//var binary = converter.ConvertToBinary(16500);
//var gap = gapFinder.FindMaximumGap(binary);
//printer.PrintMaximumGap(gap);

int[] arr = { -3 , -1 };
//Console.WriteLine(solution(arr));

int[] arr2 = {42, 1,1, 2, 2,3, 4, 500, 3, 4, 42};
var oddValue = OddOccurances.solution(arr2) ;
Console.WriteLine(oddValue);
int solution(int[] A)
{
    // Implement your solution here
    Array.Sort(A);
    var list= A.ToList();
    var smallestElement = 0;
    var largestElement = A[A.Length - 1] > 0 ? A[A.Length-1] : 0;
    
    for(int i= 1; i <= largestElement; i++)
    {
        if (list.Exists(x => x == i) == false)
        {
            smallestElement = i;
            break;
        }
    }

    return smallestElement > 0 ? smallestElement : largestElement + 1 ;
}