

//https://www.hackerrank.com/challenges/30-more-exceptions/problem challenge

using Challenge19;

int T = Int32.Parse(Console.ReadLine());
while (T-- > 0)
{
    string[] num = Console.ReadLine().Split();
    int n = int.Parse(num[0]);
    int p = int.Parse(num[1]);
    try
    {
        int ans = Calculator.Power(n, p);
        Console.WriteLine(ans);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);

    }
}



//Sample Input
//4
//3 5
//2 4
//-1 -2
//-1 3

//Sample Output
//243
//16
//n and p should be non-negative
//n and p should be non-negative