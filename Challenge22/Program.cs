

//https://www.hackerrank.com/challenges/30-dictionaries-and-maps/problem challenge


int n = Convert.ToInt32(Console.ReadLine());
if (n <= Math.Pow(10, 5) && n >= 1)
{
    IDictionary<string, string> directory = new Dictionary<string, string>(n);
    for (int i = 0; i < n; i++)
    {
        var inputValue = Console.ReadLine().Split(' ');
        directory[inputValue[0]] = $"{inputValue[0]}={inputValue[1]}";
    }
    string searchName = "";
    while ((searchName = Console.ReadLine()) != null)
    {
        if (directory.ContainsKey(searchName))
        {
            Console.WriteLine(directory[searchName]);
        }
        else
        {
            Console.WriteLine("Not found");

        }
    }
}




//Sample Input
//3
//sam 99912222
//tom 11122222
//harry 12299933
//sam
//edward
//harry

//Sample Output
//sam=99912222
//Not found
//harry=12299933
