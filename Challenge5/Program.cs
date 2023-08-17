
//https://www.hackerrank.com/challenges/30-conditional-statements/problem challenge


int n = Convert.ToInt32(Console.ReadLine().Trim());
if (n <= 100 && n >= 0)
{
    if (n % 2 == 1)
    {
        Console.WriteLine("Weird");
    }
    else if (n >= 2 && n <= 5)
    {
        Console.WriteLine("Not Weird");
    }
    else if (n >= 6 && n <= 20)
    {
        Console.WriteLine("Weird");
    }
    else if (n > 20)
    {
        Console.WriteLine("Not Weird");
    }
}
Console.ReadLine();


//Sample Input 0
//3

//Sample Output 0
//Weird

//Sample Input 1
//24

//Sample Output 1
//Not Weird