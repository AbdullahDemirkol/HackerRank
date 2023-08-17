

//https://www.hackerrank.com/challenges/compare-the-triplets/problem challenge

using Challenge13;

List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

List<int> result = Result.CompareTriplets(a, b);

Console.WriteLine(String.Join(" ", result));



//a[0] > b[0], so Alice receives  point.
//a[1] = b[1], so nobody receives a point.
//a[2] < b[2], so Bob receives  point.

//Sample Input 0
//5 6 7
//3 6 10

//Sample Output 0
//1 1

//Sample Input 1
//17 28 30
//99 16 8

//Sample Output 1
//2 1