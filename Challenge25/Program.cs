

//https://www.hackerrank.com/challenges/mini-max-sum/problem?isFullScreen=true challenge

using Challenge25;

List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

Result.MiniMaxSum(arr);

//Sample Input
//1 2 3 4 5

//Sum everything except , the sum is 2+3+4+5=14.
//Sum everything except , the sum is 1+3+4+5=13.
//Sum everything except , the sum is 1+2+4+5=12.
//Sum everything except , the sum is 1+2+3+5=11.
//Sum everything except , the sum is 1+2+3+4=10.

//Sample Output
//10 14

