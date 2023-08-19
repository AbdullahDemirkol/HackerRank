

//https://academy.patika.dev/tr/courses/csharp-101/15-odev-2 ödev

using System.Collections;

List<int> arrayList = new List<int>();

for (int i = 0; i < 20; i++)
{
    var number = int.Parse(Console.ReadLine());
    arrayList.Add(number);
}
List<int> littleList = new List<int>();
List<int> highList = new List<int>();

for (int i = 0;i < 3; i++)
{
    var maxElement=arrayList.Max();
    var minElement = arrayList.Min();

    highList.Add(maxElement);
    littleList.Add(minElement);

    arrayList.Remove(maxElement);
    arrayList.Remove(minElement);
}
Console.WriteLine("Küçük eleman dizisi ortalaması:"+littleList.Average());
Console.WriteLine("Büyük eleman dizisi ortalaması:" + highList.Average());
Console.WriteLine("Büyük ve küçük dizilerinin ortalamaları toplamı:" + (littleList.Average()+highList.Average()));

