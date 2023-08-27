


//https://www.hackerrank.com/challenges/permutation-equation/problem?isFullScreen=true challenge


using System.IO;

int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> p = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pTemp => Convert.ToInt32(pTemp)).ToList();

List<int> result = Result.PermutationEquation(p);

Console.WriteLine(String.Join("\n", result));

//Sample Input 0
//3
//2 3 1

//Sample Output 0
//2
//3
//1

//Sample Input 1
//5
//4 3 5 1 2

//Sample Output 1
//1
//3
//5
//4
//2
