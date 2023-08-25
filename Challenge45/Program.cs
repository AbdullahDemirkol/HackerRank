

//https://www.hackerrank.com/challenges/utopian-tree/problem?isFullScreen=true challenge 




int t = Convert.ToInt32(Console.ReadLine().Trim());

for (int tItr = 0; tItr < t; tItr++)
{
    int n = Convert.ToInt32(Console.ReadLine().Trim());

    int result = Result.UtopianTree(n);

    Console.WriteLine(result);
}



//Sample Input
//3
//0
//1
//4

//Sample Output
//1
//2
//7


//Period Height
//0          1
//1          2
//2          3
//3          6
//4          7
//5          14