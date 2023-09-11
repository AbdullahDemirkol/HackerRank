


//https://www.hackerrank.com/challenges/30-2d-arrays/problem?isFullScreen=true challenge


List<List<int>> arr = new List<List<int>>();

for (int i = 0; i < 6; i++)
{
    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
}
var maxResult = -999;
for (int i = 0; i < arr.Count-2; i++)
{
    for (int j = 0; j < arr.Count-2; j++)
    {
        var preparedArray= PreparedArray(arr,i,j);
        int result = CheckResult(preparedArray);
        maxResult = Math.Max(maxResult, result);
    }
}
Console.WriteLine(maxResult);

List<List<int>> PreparedArray(List<List<int>> arr, int iIndex, int jIndex)
{
    var preparedArray = new List<List<int>>()
    {
        new List<int>() { arr[iIndex][jIndex], arr[iIndex][jIndex+1], arr[iIndex][jIndex+2] },
        new List<int>() { arr[iIndex + 1][jIndex], arr[iIndex + 1][jIndex+1], arr[iIndex+1][jIndex+2] },
        new List<int>() { arr[iIndex + 2][jIndex], arr[iIndex + 2][jIndex+1], arr[iIndex + 2][jIndex+2] }
    };
    return preparedArray;
}



int CheckResult(List<List<int>> arr)
{
    var sum = 0;
    for (int i = 0; i < arr.Count; i++)
    {
        for (int j = 0; j < arr.Count; j++)
        {
            if (i!=1)
            {
                sum += arr[i][j];
            }
            else if(j!=0 && j!=2)
            {
                sum+=arr[i][j];
            }
        }
    }
    return sum;
}



//Sample Input
//1 1 1 0 0 0
//0 1 0 0 0 0
//1 1 1 0 0 0
//0 0 2 4 4 0
//0 0 0 2 0 0
//0 0 1 2 4 0

//Sample Output
//19