using Challenge10;

//https://www.hackerrank.com/challenges/simple-array-sum/problem challenge

int arrCount = Convert.ToInt32(Console.ReadLine().Trim());
if (arrCount > 0 && arrCount <= 1000)
{
    List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

    int result = Result.SimpleArraySum(arr);

    Console.WriteLine(result);
}


//Sample Input
//6
//1 2 3 4 10 11

//Sample Output
//31