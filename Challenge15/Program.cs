
//https://www.hackerrank.com/challenges/migratory-birds/problem challenge 

using Challenge15;


int arrCount = Convert.ToInt32(Console.ReadLine().Trim());
if (arrCount >= 5 && arrCount <= 2 * (Math.Pow(10, 5)))
{
    List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

    int result = Result.MigratoryBirds(arr);

    Console.WriteLine(result);
}


//Örnek Giriş 0
//6 
//1 4 4 4 5 3

//Örnek Çıktı 0
//4

//Örnek Giriş 1
//11 
//1 2 3 4 5 4 3 2 1 3 4

//Örnek Çıktı 1
//3