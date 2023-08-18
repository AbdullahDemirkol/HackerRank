

//https://www.hackerrank.com/challenges/30-generics/problem challenge

using Challenge21;

int n = Convert.ToInt32(Console.ReadLine());
int[] intArray = new int[n];
for (int i = 0; i < n; i++)
{
    intArray[i] = Convert.ToInt32(Console.ReadLine());
}

n = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[n];
for (int i = 0; i < n; i++)
{
    stringArray[i] = Console.ReadLine();
}

Result.PrintArray<Int32>(intArray);
Result.PrintArray<String>(stringArray);

