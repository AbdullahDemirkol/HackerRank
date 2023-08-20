

//https://www.hackerrank.com/challenges/between-two-sets/problem?isFullScreen=true challenge


using Challenge29;

string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);

int m = Convert.ToInt32(firstMultipleInput[1]);

List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

int totalX = Result.GetTotalX(arr, brr);
int totalY = Result.GetTotalY(arr, brr);

Console.WriteLine(totalX);
Console.WriteLine(totalY);


//Sample Input
//2 3
//2 4
//16 32 96

//Sample Output
//3