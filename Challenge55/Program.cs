

//https://www.hackerrank.com/challenges/append-and-delete/problem?isFullScreen=true challenge


using System.IO;

string s = Console.ReadLine();

string t = Console.ReadLine();

int k = Convert.ToInt32(Console.ReadLine().Trim());

string result = Result.AppendAndDelete(s, t, k);

Console.WriteLine(result);

//Sample Input 0
//hackerhappy
//hackerrank
//9

//Sample Output 0
//Yes

//Sample Input 1
//aba
//aba
//7

//Sample Output 1
//Yes

//Sample Input 2
//ashley
//ash
//2

//Sample Output 2
//No