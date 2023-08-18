

//https://www.hackerrank.com/challenges/30-recursion/problem challenge


using Challenge16;

int n = Convert.ToInt32(Console.ReadLine().Trim());
if (n<=12 && n>=2) 
{
    int result = Result.Factorial(n);

    Console.WriteLine(result);
}


//Sample Input
//3

//Sample Output
//6                         => 3x2x1=6
