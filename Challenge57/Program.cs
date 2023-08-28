


//https://www.hackerrank.com/challenges/library-fine/problem?isFullScreen=true challenge



string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int d1 = Convert.ToInt32(firstMultipleInput[0]);

int m1 = Convert.ToInt32(firstMultipleInput[1]);

int y1 = Convert.ToInt32(firstMultipleInput[2]);

string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int d2 = Convert.ToInt32(secondMultipleInput[0]);

int m2 = Convert.ToInt32(secondMultipleInput[1]);

int y2 = Convert.ToInt32(secondMultipleInput[2]);

int result = Result.LibraryFine(d1, m1, y1, d2, m2, y2);

Console.WriteLine(result);

//Sample Input
//9 6 2015
//6 6 2015

//Sample Output
//45