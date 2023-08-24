

//https://www.hackerrank.com/challenges/picking-numbers/problem?isFullScreen=true challenge




int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

int result = Result.PickingNumbers(a);

Console.WriteLine(result);

//Sample Input 0
//6
//4 6 5 3 3 1

//Sample Output 0
//3

//Sample Input 1
//6
//1 2 2 3 1 2

//Sample Output 1
//5