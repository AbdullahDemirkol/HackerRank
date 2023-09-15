

//https://www.hackerrank.com/challenges/30-running-time-and-complexity/problem?isFullScreen=true challenge

var arCount = Convert.ToInt32(Console.ReadLine());
List<int> a=new List<int>();
for (int i = 0; i < arCount; i++)
{
    int aElement= Convert.ToInt32(Console.ReadLine());
    a.Add(aElement);
}

for (int i = 0; i < a.Count(); i++)
{
    var isPrime = PrimeControl(a[i]);

    Console.WriteLine(isPrime);
}

string PrimeControl(int a)
{
    if (a <= 1)
    {
        return "Not prime";
    }
    if (a == 2) 
    {
        return "Prime";
    }
    if (a%2==0)
    {
        return "Not prime";
    }
    for (int i = 3; i < a; i+=2)
    {
        if (a % i == 0)
        {
            return "Not prime";
        }
    }
    return "Prime";
}

//Sample Input
//3
//12
//5
//7

//Sample Output
//Not prime
//Prime
//Prime