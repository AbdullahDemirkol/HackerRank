

//https://www.hackerrank.com/challenges/circular-array-rotation/problem?isFullScreen=true challenge


string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);

int k = Convert.ToInt32(firstMultipleInput[1]);

int q = Convert.ToInt32(firstMultipleInput[2]);

List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

List<int> queries = new List<int>();

for (int i = 0; i < q; i++)
{
    int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
    queries.Add(queriesItem);
}

List<int> result = Result.CircularArrayRotation(a, k, queries);

Console.WriteLine(String.Join("\n", result));



//Sample Input 0
//3 2 3
//1 2 3
//0
//1
//2

//Sample Output 0
//2
//3
//1