

//https://www.hackerrank.com/challenges/30-sorting/problem challenge

int n = Convert.ToInt32(Console.ReadLine().Trim());
if (n >=2 && n <= 600)
{
    List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
    var flag = true;
    foreach (var item in a)
    {
        if (item<1 || item>2*(Math.Pow(10,6)))
        {
            flag = false;
        }
    }
    if (flag)
    {
        int numberOfSwaps = 0;

        for (int i = 0; i < n; i++)
        {

            for (int j = 0; j < n - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    var tempValue = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = tempValue;
                    numberOfSwaps++;
                }
            }
        }
        Console.WriteLine("Array is sorted in {0} swaps.", numberOfSwaps);
        Console.WriteLine("First Element: " + a[0]);
        Console.WriteLine("Last Element: " + a[a.Count() - 1]);
        Console.ReadLine();
    }
}

//Sample Input 1
//3
//3 2 1

//Sample Output 1
//Array is sorted in 3 swaps.
//First Element: 1
//Last Element: 3