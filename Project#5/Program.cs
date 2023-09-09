


//https://academy.patika.dev/tr/courses/c-projeleri/karakter



Console.WriteLine("Ifadenizi Yazınız:");
var statement = Console.ReadLine();

if (statement != null)
{
    var statementSplitForSpace=statement.Split(' ');
    foreach (var line in statementSplitForSpace)
    {
        if (line.Length>0)
        {
            var lineChars = line.ToCharArray();
            var tempChar = lineChars[0];
            for (int i = 0; i < lineChars.Length-1; i++)
            {
                lineChars[i] = lineChars[i+1];
            }
            lineChars[lineChars.Length-1] = tempChar;

            var newLine = new string(lineChars);
            Console.Write(newLine + " ");
        }
    }
}