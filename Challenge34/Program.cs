

//https://www.hackerrank.com/challenges/bon-appetit/problem?isFullScreen=true challenge

using Challenge34;

string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);

int k = Convert.ToInt32(firstMultipleInput[1]);

List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

int b = Convert.ToInt32(Console.ReadLine().Trim());

Result.BonAppetit(bill, k, b);


//Sample Input 0
//4 1
//3 10 2 9
//12

//Sample Output 0
//5

//Sample Input 1
//4 1
//3 10 2 9
//7

//Sample Output 1
//Bon Appetit