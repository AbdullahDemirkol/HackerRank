

//https://www.hackerrank.com/challenges/grading/problem?isFullScreen=true challenge

using Challenge26;

int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

List<int> grades = new List<int>();

for (int i = 0; i < gradesCount; i++)
{
    int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
    grades.Add(gradesItem);
}

List<int> result = Result.GradingStudents(grades);

Console.WriteLine(String.Join("\n", result));


//Sample Input 0
//4
//73
//67
//38
//33

//Sample Output 0
//75                ==>75-73<3  =75
//67                ==>70-67=3  =67
//40                ==>40-38<3  =40
//33                ==>35-33<3  =35