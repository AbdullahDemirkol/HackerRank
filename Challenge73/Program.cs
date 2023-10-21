
//https://www.hackerrank.com/challenges/30-bitwise-and/problem?isFullScreen=true challenge

using Challenge73;


int t = Convert.ToInt32(Console.ReadLine().Trim());
var result = new List<int>();

for (int tItr = 0; tItr < t; tItr++)
{
    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

    int count = Convert.ToInt32(firstMultipleInput[0]);

    int lim = Convert.ToInt32(firstMultipleInput[1]);

    int res = Result.BitwiseAnd(count, lim);

    result.Add(res);
}
foreach (var resul in result)
{
    Console.WriteLine(resul);
}

//Sample Input
//3       =>  T = 3
//5 2     =>  N = 5, K = 2
//8 5     =>  N = 8, K = 5
//2 2     =>  N = 8, K = 5

//Sample Output
//1
//4
//0