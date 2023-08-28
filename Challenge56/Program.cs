

//https://www.hackerrank.com/challenges/sherlock-and-squares/problem?isFullScreen=true challenge

using System.IO;

int q = Convert.ToInt32(Console.ReadLine().Trim());

for (int qItr = 0; qItr < q; qItr++)
{
    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

    int a = Convert.ToInt32(firstMultipleInput[0]);

    int b = Convert.ToInt32(firstMultipleInput[1]);

    var result = Result.Squares(a, b);
    
    Console.WriteLine(result);
}

//Sample Input
//2
//3 9
//17 24

//Sample Output
//2
//0