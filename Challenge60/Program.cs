


//https://www.hackerrank.com/challenges/30-inheritance/problem?isFullScreen=true challenge


string[] inputs = Console.ReadLine().Split();
string firstName = inputs[0];
string lastName = inputs[1];
int id = Convert.ToInt32(inputs[2]);
int numScores = Convert.ToInt32(Console.ReadLine());
inputs = Console.ReadLine().Split();
int[] scores = new int[numScores];
for (int i = 0; i < numScores; i++)
{
    scores[i] = Convert.ToInt32(inputs[i]);
}

Student s = new Student(id, firstName, lastName,  scores);
s.PrintPerson();
Console.WriteLine("Grade: " + s.Calculate() + "\n");

//Sample Input
//Heraldo Memelli 8135627
//2
//100 80

//Sample Output
//Name: Memelli, Heraldo
//ID: 8135627
//Grade: O