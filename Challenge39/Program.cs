

//https://www.hackerrank.com/challenges/cats-and-a-mouse/problem?isFullScreen=true challenge

using System.Collections.Generic;
using System.Threading.Channels;

int q = Convert.ToInt32(Console.ReadLine());
List<string> list = new List<string>();

for (int qItr = 0; qItr < q; qItr++)
{
    string[] xyz = Console.ReadLine().Split(' ');

    int x = Convert.ToInt32(xyz[0]);

    int y = Convert.ToInt32(xyz[1]);

    int z = Convert.ToInt32(xyz[2]);

    string result = CatAndMouse(x, y, z);
    list.Add(result);
}
list.ForEach(element => Console.WriteLine(element));

string CatAndMouse(int x, int y, int z)
{
    var result = string.Empty;
    int catA=Math.Abs(x - z);
    int catB=Math.Abs(y - z);
    if (catA > catB)
    {
        result = "Cat B";
    }
    else if (catB>catA)
    {
        result = "Cat A";
    }
    else
    {
        result = "Mouse C";
    }
    return result;
}

//Sample Input 0
//2
//1 2 3
//1 3 2

//Sample Output 0
//Cat B
//Mouse C