


//https://www.hackerrank.com/challenges/halloween-party/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign challenge


using Challenge75;

int t = Convert.ToInt32(Console.ReadLine().Trim());

for (int tItr = 0; tItr < t; tItr++)
{
    int k = Convert.ToInt32(Console.ReadLine().Trim());

    long result = Result.HalloweenParty(k);

    Console.WriteLine(result);
}


//Sample Input
//4
//5
//6
//7
//8

//Sample Output 
//6
//9
//12
//16