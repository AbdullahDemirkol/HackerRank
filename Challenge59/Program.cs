



//https://www.hackerrank.com/challenges/30-binary-numbers/problem?isFullScreen=true challenge


int n = Convert.ToInt32(Console.ReadLine().Trim());


string ikili = DecimalToBinary(n);
var result = CheckConsecutiveNumber(ikili);
Console.WriteLine(result);

static string DecimalToBinary(int sayi)
{
    if (sayi == 0)
        return "0";

    string ikili = "";
    while (sayi > 0)
    {
        int kalan = sayi % 2;
        ikili = kalan.ToString() + ikili;
        sayi = sayi / 2;
    }

    return ikili;
}

static int CheckConsecutiveNumber(string ikili)
{
    var maxResult = 0;
    var result = 0;
    foreach (char character in ikili)
    {
        if (character == '1')
        {
            result++;
            if (maxResult < result)
            {
                maxResult = result;
            }
        }
        else
        {
            result = 0;
        }
    }
    return maxResult;
}





//Sample Input 1
//5

//Sample Output 1
//1

//Sample Input 2
//13

//Sample Output 2
//2
