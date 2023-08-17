using Challenge2;
using System.Drawing;

//https://www.hackerrank.com/challenges/cut-the-sticks/problem?h_r=next-challenge&h_v=zen challenge


int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
List<int> result = Result.CutTheSticks(arr);

Console.WriteLine(String.Join("\n", result));

Console.ReadLine();


//Sample Input 0
//6               arr[] size n = 6
//5 4 4 2 2 8     arr = [5, 4, 4, 2, 2, 8]

//Sample Output 0
//6
//4
//2
//1
//-----------------------------------------------------------
//Sample Input 1
//8                arr[] size n = 6
//1 2 3 4 3 3 2 1  arr = [1, 2, 3, 4, 3, 3, 2, 1]

//Sample Output 1
//8
//6
//4
//1