

//https://www.hackerrank.com/challenges/30-scope/problem?isFullScreen=true challenge


using System.Drawing;

Convert.ToInt32(Console.ReadLine());

int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

Difference d = new Difference(a);

d.ComputeDifference();

Console.Write(d.maximumDifference);


//Sample Input
//STDIN   Function
//-----   --------
//3       __elements[] size N = 3
//1 2 5   __elements = [1, 2, 5]

//Sample Output
//4