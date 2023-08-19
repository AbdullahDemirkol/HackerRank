
//https://academy.patika.dev/tr/courses/csharp-101/15-odev-2 ödev


using System.Threading.Channels;

string word=Console.ReadLine();
if (word != null)
{
	List<char> words = new List<char>();
    char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
    foreach (char character in word)
	{
		if (sesliHarfler.Contains(character))
		{
			words.Add(character);
		}
	}
    words.OrderBy(p => p).ToList().ForEach(element => Console.WriteLine(element));
}