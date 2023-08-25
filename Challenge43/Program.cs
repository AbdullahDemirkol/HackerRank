
//https://www.hackerrank.com/challenges/the-hurdle-race/problem?isFullScreen=true challenge

string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);

int k = Convert.ToInt32(firstMultipleInput[1]);

List<int> height = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(heightTemp => Convert.ToInt32(heightTemp)).ToList();

int result = Result.HurdleRace(k, height);

Console.WriteLine(result);

//Sample Input 0
//5 4
//1 6 3 5 2

//Sample Output 0
//2

//Sample Input 1
//5 7
//2 5 4 5 2

//Sample Output 1
//0