



//https://www.hackerrank.com/challenges/divisible-sum-pairs/problem?isFullScreen=true challenge

using System.IO;

string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);

int k = Convert.ToInt32(firstMultipleInput[1]);

List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

int result = Result.DivisibleSumPairs(n, k, ar);

Console.WriteLine(result);



//Sample Input
//6 3             n = 6, k = 3
//1 3 2 6 1 2     ar = [1, 3, 2, 6, 1, 2]

//Sample Output
// 5