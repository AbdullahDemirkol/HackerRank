

//https://www.hackerrank.com/challenges/30-regex-patterns/problem?isFullScreen=true challenge


using System.Text.RegularExpressions;

int N = Convert.ToInt32(Console.ReadLine().Trim());

Regex regex = new Regex("[a-z]+@gmail\\.com");

List<string> names = new List<string>();

for (int NItr = 0; NItr < N; NItr++)
{
    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

    string firstName = firstMultipleInput[0];

    string emailID = firstMultipleInput[1];

    if (regex.IsMatch(emailID))
    {
        names.Add(firstName);
    }
}
foreach (var firstName in names.OrderBy(p=>p))
{
    Console.WriteLine(firstName);
}




//Sample Input
//6
//riya riya@gmail.com
//julia julia@julia.me
//julia sjulia@gmail.com
//julia julia@gmail.com
//samantha samantha@gmail.com
//tanya tanya@gmail.com

//Sample Output
//julia
//julia
//riya
//samantha
//tanya