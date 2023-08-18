
//https://www.hackerrank.com/challenges/30-review-loop/problem challenge

int wordCount = Convert.ToInt32(Console.ReadLine());

if (wordCount >= 1 && wordCount<=10)
{
    string[] words = new string[wordCount];
    for (int i = 0; i < wordCount; i++)
    {
        string word = Console.ReadLine();
        if (word.Length>=2 && word.Length<=10000)
        {
            words[i] = word;
        }
    }
    foreach (string word in words)
    {
        string doubleDigit = null, firstDigit = null;
        for (int i = 0;i < word.Length;i++)
        {
            if (i%2==0)
            {
                doubleDigit += word[i];
            }
            else
            {
                firstDigit += word[i];
            }
        }
        Console.WriteLine(doubleDigit + " " + firstDigit);
    }
}



//Sample Input
//2
//Hacker
//Rank

//Sample Output
//Hce akr
//Rn ak