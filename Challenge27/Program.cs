

//https://www.hackerrank.com/challenges/apple-and-orange/problem?isFullScreen=true challenge


using Challenge27;

string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int s = Convert.ToInt32(firstMultipleInput[0]);

int t = Convert.ToInt32(firstMultipleInput[1]);

string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int a = Convert.ToInt32(secondMultipleInput[0]);

int b = Convert.ToInt32(secondMultipleInput[1]);

string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int m = Convert.ToInt32(thirdMultipleInput[0]);

int n = Convert.ToInt32(thirdMultipleInput[1]);

List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

Result.CountApplesAndOranges(s, t, a, b, apples, oranges);

//Sample Input 0
//7 11
//5 15
//3 2
//-2 2 1
//5 -6

//Sample Output 0
//1
//1
