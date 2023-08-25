
//https://www.hackerrank.com/challenges/angry-professor/problem?isFullScreen=true challenge


int t = Convert.ToInt32(Console.ReadLine().Trim());

for (int tItr = 0; tItr < t; tItr++)
{
    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

    int n = Convert.ToInt32(firstMultipleInput[0]);

    int k = Convert.ToInt32(firstMultipleInput[1]);

    List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

    string result = Result.AngryProfessor(k, a);

    Console.WriteLine(result);
}



//Sample Input
//2
//4 3
//-1 -3 4 2
//4 2
//0 -1 2 1

//Sample Output
//YES
//NO