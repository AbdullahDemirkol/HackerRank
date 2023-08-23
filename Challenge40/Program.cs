


//https://www.hackerrank.com/challenges/magic-square-forming/problem?isFullScreen=true challenge


List<List<int>> s = new List<List<int>>();

for (int i = 0; i < 3; i++)
{
    s.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList());
}

int result = Result.FormingMagicSquare(s);

Console.WriteLine(result);


//Sample Input 0
//4 9 2
//3 5 7
//8 1 5

//Sample Output 0
//1

//Sample Input 1
//4 8 2
//4 5 7
//6 1 6

//Sample Output 1
//4