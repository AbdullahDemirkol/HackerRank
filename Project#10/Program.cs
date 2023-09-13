


//https://academy.patika.dev/tr/courses/c-projeleri/sessiz-harf

using System.Linq;
using System.Threading.Channels;

Console.WriteLine("Kelimeleri giriniz:");
var stringInputs=Console.ReadLine().Split(' ');
// Sessiz harfleri bir char dizisine atayın
char[] sessizHarfler = { 'b', 'c', 'ç', 'd', 'f', 'g', 'ğ', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 'ş', 't', 'v', 'y', 'z','w','q' };

foreach (var stringInput in stringInputs)
{
    var value = new string(stringInput.ToLower());
    bool isTrue = false;
    for (int i = 0; i < value.Length-1; i++)
    {
        var firstChar = value[i];
        var secondChar = value[i + 1];
        if (sessizHarfler.Any(p=>p==firstChar) && sessizHarfler.Any(p=>p == secondChar))
        {
            isTrue = true;
            break;
        }
    }

    if (isTrue)
    {
        Console.Write("True ");
    }
    else
    {
        Console.Write("False ");
    }
}


//Örnek: Input: Merhaba Umut Arya
//Output: True False True