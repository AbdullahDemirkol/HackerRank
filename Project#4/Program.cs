


//https://academy.patika.dev/tr/courses/c-projeleri/string-ve-sayi-alan

start:

Console.WriteLine("Index ve ifade değerleri giriniz(Aralarını virgül ile ayırınız):");
var statement=Console.ReadLine();

if (statement != null)
{
    var statementElementArray = statement.Split(",");
    if (statementElementArray != null && Convert.ToInt32(statementElementArray[1]) < statementElementArray[0].Length)
    {
        Console.WriteLine(statementElementArray[0].Remove(Convert.ToInt32(statementElementArray[1]), 1));
    }
    else
    {
        Console.WriteLine("Index değeri ifadeden daha büyük.");
    }
    goto start;
}
else
{
    Console.WriteLine("Hatalı yazı yazıldı.");
}
