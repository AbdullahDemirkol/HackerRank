



//https://academy.patika.dev/tr/courses/c-projeleri/karakter-degistirme


Console.WriteLine("Cümlenizi Giriniz:");
string[] stringInputs = Console.ReadLine().Split(' ');
if (stringInputs.Count() != 0)
{
    string newString;
    foreach (string stringInput in stringInputs)
    {
        if (stringInput.Length > 1)
        {
            newString = "";
            newString += stringInput.ToCharArray()[stringInput.Length - 1];
            for (int i = 1; i < stringInput.Length - 1; i++)
            {
                newString += stringInput[i];
            }
            newString += stringInput[0];
            Console.Write(newString + " ");
        }
        else if (stringInput.Length == 1) { Console.Write(stringInput+" "); }
    }
}

//Örnek: Input: Merhaba Hello Algoritma x
//Output: aerhabM oellH algoritmA x