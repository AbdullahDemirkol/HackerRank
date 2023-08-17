using Challenge2;

int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
List<int> result = Result.CutTheSticks(arr);

Console.WriteLine(String.Join("\n", result));

Console.ReadLine();