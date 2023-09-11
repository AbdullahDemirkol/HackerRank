

//https://www.hackerrank.com/challenges/non-divisible-subset/problem?isFullScreen=true challenge



string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);

int k = Convert.ToInt32(firstMultipleInput[1]);

List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

int result = Result.NonDivisibleSubset(k, s);

Console.WriteLine(result);


//Sample Input
//4 3             => S[] size n = 4, k = 3
//1 7 2 4         => S = [1, 7, 2, 4]

//Sample Output
//3