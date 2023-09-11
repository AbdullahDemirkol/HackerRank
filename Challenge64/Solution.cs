internal class Solution
{
    protected string word = "";
    List<char> wordCharacters = new List<char>();
    
    internal char DequeueCharacter()
    {
        var character= word[word.Length-1];
        word = new string(word.Substring(0, word.Length - 1));
        return character;

    }

    internal void EnqueueCharacter(char c)
    {
        word += c;
    }

    internal char PopCharacter()
    {
        var character = wordCharacters[0];
        wordCharacters.Remove(wordCharacters[0]);
        return character;
    }

    internal void PushCharacter(char c)
    {
        wordCharacters.Add(c);
    }
}