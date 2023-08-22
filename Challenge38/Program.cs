

//https://www.hackerrank.com/challenges/electronics-shop/problem?isFullScreen=true challenge

string[] bnm = Console.ReadLine().Split(' ');

int b = Convert.ToInt32(bnm[0]);

int n = Convert.ToInt32(bnm[1]);

int m = Convert.ToInt32(bnm[2]);

int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
;

int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
;
/*
 * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
 */

int moneySpent = GetMoneySpent(keyboards, drives, b);

int GetMoneySpent(int[] keyboards, int[] drives, int b)
{
    var maxPrice = 0;
    foreach (int i in keyboards)
    {
        foreach (int j in drives)
        {
            if (b>=(j+i) && maxPrice< (j + i))
            {
                maxPrice = (j + i);
            }
        }
    }
    if (maxPrice == 0)
    {
        return -1;
    }
    else
    {
        return maxPrice;
    }
}

Console.WriteLine(moneySpent);


//Sample Input 0
//10 2 3
//3 1
//5 2 8

//Sample Output 0

//9

//Sample Input 1
//5 1 1
//4
//5

//Sample Output 1
//-1