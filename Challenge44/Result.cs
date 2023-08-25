internal class Result
{
    internal static int DesignerPdfViewer(List<int> h, string? word)
    {
        int result = 0;
        var elementList= new List<string>() 
        { 
            "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"
        };

        for(int i=0;i<word.Length;i++)
        {
            var element = elementList.IndexOf(word[i].ToString());
            var findElement = h[element];
            result = Math.Max(result, findElement);
        }
        return result*word.Length;
    }
}