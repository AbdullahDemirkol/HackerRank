

//https://www.hackerrank.com/challenges/30-arrays/problem challenge

int n = Convert.ToInt32(Console.ReadLine().Trim());
if (n>=1 && n<=1000)
{
    List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
    bool flag = true;
    foreach (int element in arr)
    {
        if (element<1 || element >10000)
        {
            flag = false;
        }
    }
    if (flag)
    {
        arr.Reverse();
        Console.WriteLine(string.Join(" ", arr));
    }
}

//Sample Input
//4
//1 4 3 2

//Sample Output
//2 3 4 1
