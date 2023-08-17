

//https://www.hackerrank.com/challenges/birthday-cake-candles/problem challenge

using Challenge9;

int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());
if (candlesCount >= 1 && candlesCount<= Math.Pow(10, 5))
{
    List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

    int result = Result.BirthdayCakeCandles(candles);

    Console.WriteLine(result);
}



//Sample Input 0
//4
//3 2 1 3

//Sample Output 0
//2