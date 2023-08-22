


//https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem?isFullScreen=true challenge

using System.IO;

int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

List<int> result = Result.BreakingRecords(scores);

Console.WriteLine(String.Join(" ", result));


//Sample Input 0
//9
//10 5 20 20 4 5 2 25 1

//Sample Output 0
//2 4

//Sample Input 1
//10
//3 4 21 36 10 28 35 5 24 42

//Sample Output 1
//4 0