// See https://aka.ms/new-console-template for more information
using CodilityProjects;

var converter = new BinaryConverter();
var gapFinder = new BinaryGapFinder();
var printer = new BinaryGapPrinter();

var binary = converter.ConvertToBinary(16500);
var gap = gapFinder.FindMaximumGap(binary);
printer.PrintMaximumGap(gap);