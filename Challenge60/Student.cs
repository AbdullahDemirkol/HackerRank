internal class Student:Person
{
    private int[] testScores;

    public Student(int id, string firstName, string lastName, int[] testScores):base(firstName, lastName,id)
    {
        this.testScores = testScores;
    }
    
    internal string Calculate()
    {
        var avarageGrade=testScores.Sum()/testScores.Count();
        if (avarageGrade>=90 && avarageGrade<=100)
        {
            return "O";
        }
        else if (avarageGrade>=80 && avarageGrade < 90)
        {
            return "E";
        }
        else if (avarageGrade >= 70 && avarageGrade < 80)
        {
            return "A";
        }
        else if (avarageGrade >= 55 && avarageGrade < 70)
        {
            return "P";
        }
        else if (avarageGrade >= 40 && avarageGrade < 55)
        {
            return "D";
        }
        else if (avarageGrade < 40)
        {
            return "T";
        }
        return "";
    }
}
