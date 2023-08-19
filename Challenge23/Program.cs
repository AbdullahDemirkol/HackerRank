

//https://www.hackerrank.com/challenges/30-class-vs-instance/problem challenge

using Challenge23;

int T = int.Parse(Console.In.ReadLine());
for (int i = 0; i < T; i++)
{
    int age = int.Parse(Console.In.ReadLine());
    Person person = new Person(age);
    person.amIOld();
    for (int j = 0; j < 3; j++)
    {
        person.yearPasses();
    }
    person.amIOld();
    Console.WriteLine();
}




//Sample Input
//4
//-1
//10
//16
//18

//Sample Output
//Age is not valid, setting age to 0.
//You are young.
//You are young.

//You are young.
//You are a teenager.

//You are a teenager.
//You are old.

//You are old.
//You are old.