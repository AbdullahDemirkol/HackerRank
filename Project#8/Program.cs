


//https://academy.patika.dev/tr/courses/c-projeleri/mutlak-kare


Console.WriteLine("Aralarında Boşluk Bırakarak Sayılar Giriniz:");
var numbers = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

double smallResult = 0;
double bigResult = 0;
foreach (var number in numbers)
{
    if (number < 67)
    {
        smallResult += (67-number);
    }
    else if (number > 67)
    {
        bigResult += Math.Pow((number - 67), 2);
    }
}
Console.Write(smallResult + " " + bigResult);



//Örnek: Input: 56 45 68 77
//Output: 33 101