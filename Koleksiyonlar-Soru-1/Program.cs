
//https://academy.patika.dev/tr/courses/csharp-101/15-odev-2 ödev

using Koleksiyonlar_Soru_1;

List<int> primeNumber = new();
List<int> nonPrimeNumber= new();

for (int i = 0; i < 20; i++)
{
    var number= int.Parse(Console.ReadLine());
    var isPrime= Operation.IsPrime(number);
    if (isPrime)
    {
        primeNumber.Add(number);
    }
    else 
    {
        nonPrimeNumber.Add(number);
    }
}
Operation.Print(primeNumber, "Asal Sayılar:");
Operation.Print(nonPrimeNumber, "Asal Olmayan Sayılar:");
