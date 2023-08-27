


//https://www.hackerrank.com/challenges/find-digits/problem?isFullScreen=true challenge

using System.IO;

int t = Convert.ToInt32(Console.ReadLine().Trim());

for (int tItr = 0; tItr < t; tItr++)
{
    int n = Convert.ToInt32(Console.ReadLine().Trim());

    int result = Result.FindDigits(n);

    Console.WriteLine(result);
}



//Sample Input
//2
//12
//1012

//Sample Output
//2
//3