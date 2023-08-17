
//https://www.hackerrank.com/challenges/plus-minus/problem challenge

using Challenge8;

int n = Convert.ToInt32(Console.ReadLine().Trim());
if (n > 0 && n <=100)
{
    List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

    Result.PlusMinus(arr);
}

//Sample Input
//6                arr[] size n = 6
//- 4 3 -9 0 4 1   arr = [-4, 3, -9, 0, 4, 1]

//Sample Output
//0.500000                    ==> 3/6
//0.333333                    ==> 2/6
//0.166667                    ==> 1/6