


//https://www.hackerrank.com/challenges/save-the-prisoner/problem?isFullScreen=true challenge


int t = Convert.ToInt32(Console.ReadLine().Trim());

for (int tItr = 0; tItr < t; tItr++)
{
    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

    int n = Convert.ToInt32(firstMultipleInput[0]);

    int m = Convert.ToInt32(firstMultipleInput[1]);

    int s = Convert.ToInt32(firstMultipleInput[2]);

    int result = Result.SaveThePrisoner(n, m, s);

    Console.WriteLine(result);
}


//Sample Input 0
//2
//5 2 1
//5 2 2

//Sample Output 0
//2
//3

//Sample Input 1
//2
//7 19 2
//3 7 3

//Sample Output 1
//6
//3