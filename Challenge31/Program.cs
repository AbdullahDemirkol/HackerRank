


//https://www.hackerrank.com/challenges/the-birthday-bar/problem?isFullScreen=true challenge 


using System.IO;

int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int d = Convert.ToInt32(firstMultipleInput[0]);

int m = Convert.ToInt32(firstMultipleInput[1]);

int result = Result.Birthday(s, d, m);

Console.WriteLine(result);


//Sample Input 0
//5
//1 2 1 3 2
//3 2

//Sample Output 0
//2

//Sample Input 1
//6
//1 1 1 1 1 1
//3 2

//Sample Output 1
//0

//Sample Input 2
//1
//4
//4 1

//Sample Output 2
//1
