

//https://www.hackerrank.com/challenges/kangaroo/problem?isFullScreen=true challenge


using Challenge28;

string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int x1 = Convert.ToInt32(firstMultipleInput[0]);

int v1 = Convert.ToInt32(firstMultipleInput[1]);

int x2 = Convert.ToInt32(firstMultipleInput[2]);

int v2 = Convert.ToInt32(firstMultipleInput[3]);

string result = Result.Kangaroo(x1, v1, x2, v2);

Console.WriteLine(result);


//Sample Input 0
//0 3 4 2

//Sample Output 0
//YES

//Sample Input 1
//0 2 5 3

//Sample Output 1
//NO
