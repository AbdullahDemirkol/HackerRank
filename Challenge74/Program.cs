


//https://www.hackerrank.com/challenges/sherlock-and-the-beast/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=7-day-campaign challenge



using Challenge74;
using static System.Net.Mime.MediaTypeNames;

int t = Convert.ToInt32(Console.ReadLine().Trim());

for (int tItr = 0; tItr < t; tItr++)
{
    int n = Convert.ToInt32(Console.ReadLine().Trim());

    Result.DecentNumber(n);
}

//Sample Input
//4       t = 4
//1       n = 1 (first test case)
//3       n = 3(second test case)
//5
//11

//Sample Output
//-1
//555
//33333
//55555533333