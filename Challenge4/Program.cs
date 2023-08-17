
//https://www.hackerrank.com/challenges/solve-me-first/problem challenge

internal class Program
{
    private static void Main(string[] args)
    {
        int val1 = Convert.ToInt32(Console.ReadLine());
        int val2 = Convert.ToInt32(Console.ReadLine());
        int sum = SolveMeFirst(val1, val2);
        Console.WriteLine(sum);
        Console.ReadLine();
    }

    public static int SolveMeFirst(int a, int b)
    {
        if (a <= 1000 && a >= 1 && b <= 1000 && b >= 1)
        {
            return a + b;
        }
        return 0;
    }
}

//Sample Input
//val1 = 2
//val2 = 3

//Sample Output
//5