using Challenge2;

//https://www.hackerrank.com/challenges/cut-the-sticks/problem?h_r=next-challenge&h_v=zen challenge


int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
List<int> result = Result.CutTheSticks(arr);

Console.WriteLine(String.Join("\n", result));

Console.ReadLine();
