


//https://www.hackerrank.com/challenges/30-queues-stacks/problem?isFullScreen=true challenge

// read the string s.
string s = Console.ReadLine();

// create the Solution class object p.
Solution obj = new Solution();

// push/enqueue all the characters of string s to stack.
foreach (char c in s)
{
    obj.PushCharacter(c);
    obj.EnqueueCharacter(c);
}

bool isPalindrome = true;

// pop the top character from stack.
// dequeue the first character from queue.
// compare both the characters.
for (int i = 0; i < s.Length / 2; i++)
{
    if (obj.PopCharacter() != obj.DequeueCharacter())
    {
        isPalindrome = false;

        break;
    }
}

// finally print whether string s is palindrome or not.
if (isPalindrome)
{
    Console.Write("The word, {0}, is a palindrome.", s);
}
else
{
    Console.Write("The word, {0}, is not a palindrome.", s);
}

//Sample Input
//racecar

//Sample Output
//The word, racecar, is a palindrome.