

//https://www.hackerrank.com/challenges/diagonal-difference/problem?isFullScreen=true challenge



using Challenge24;

int n = Convert.ToInt32(Console.ReadLine().Trim());

List<List<int>> arr = new List<List<int>>();

for (int i = 0; i < n; i++)
{
    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
}

int result = Result.DiagonalDifference(arr);

Console.WriteLine(result);



//Sample Input
//3
//11 2 4
//4 5 6
//10 8 -12

//Sample Output
//15        => 11+5+(-12)=4   4+5+10=19  |19-4|=15