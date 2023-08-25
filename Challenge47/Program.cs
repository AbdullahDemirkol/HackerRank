



//https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/problem?isFullScreen=true challenge


string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int i = Convert.ToInt32(firstMultipleInput[0]);

int j = Convert.ToInt32(firstMultipleInput[1]);

int k = Convert.ToInt32(firstMultipleInput[2]);

int result = Result.BeautifulDays(i, j, k);

Console.WriteLine(result);

//Sample Input
//20 23 6

//Sample Output
//2