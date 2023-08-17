
//https://www.hackerrank.com/challenges/30-loops/problem challenge


int n = Convert.ToInt32(Console.ReadLine().Trim());
if (n >= 2 && n <= 20)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(n + " x " + i + " = " + (n * i));
    }
}


//Sample Input
//2

//Sample Output
//2 x 1 = 2
//2 x 2 = 4
//2 x 3 = 6
//2 x 4 = 8
//2 x 5 = 10
//2 x 6 = 12
//2 x 7 = 14
//2 x 8 = 16
//2 x 9 = 18
//2 x 10 = 20