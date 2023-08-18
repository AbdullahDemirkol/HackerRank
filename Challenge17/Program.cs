
//https://www.hackerrank.com/challenges/30-exceptions-string-to-integer/problem challenge


string S = Console.ReadLine();

if (S.Length<=6 && S.Length >= 1)
{
	try
	{
		int result=Convert.ToInt32(S);
		Console.WriteLine(result);
	}
	catch (Exception)
	{
        Console.WriteLine("Bad String");
    }
}


//Sample Input 0
//3

//Sample Output 0
//3

//Sample Input 1
//za

//Sample Output 1
//Bad String