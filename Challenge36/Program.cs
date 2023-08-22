

//https://www.hackerrank.com/challenges/drawing-book/problem?isFullScreen=true challenge



int n = Convert.ToInt32(Console.ReadLine().Trim());

int p = Convert.ToInt32(Console.ReadLine().Trim());

int result = Result.PageCount(n, p);

Console.WriteLine(result);

//Sample Input 0
//6
//2

//Sample Output 0
//1

//Sample Input 1
//5
//4

//Sample Output 1
//0