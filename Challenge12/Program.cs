

//https://www.hackerrank.com/challenges/a-very-big-sum/problem challenge

using Challenge12;

int arCount = Convert.ToInt32(Console.ReadLine().Trim());
if (arCount > 1 && arCount<10)
{
    List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

    long result = Result.VeryBigSum(ar);

    Console.WriteLine(result);
}

//Sample Input
//5
//1000000001 1000000002 1000000003 1000000004 1000000005

//Output
//5000000015