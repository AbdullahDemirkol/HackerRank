


//https://academy.patika.dev/tr/courses/c-projeleri/integer-ikili-toplami

Console.WriteLine("Sayıları Boşluk Bırakarak Giriniz:");
var numbers = Console.ReadLine();
var numbersArray = numbers.Split(' ');
for (int i = 0; i < numbersArray.Length; i += 2)
{
    var firstNumber = numbersArray[i];
    var secondNumber= numbersArray[i+1];
    if (firstNumber!=secondNumber)
    {
        Console.Write((int.Parse(firstNumber) + int.Parse(secondNumber))+" ");
    }
    else
    {
        Console.Write(Math.Pow(int.Parse(firstNumber) + int.Parse(secondNumber), 2)+ " ");
    }
}




//Örnek Input: 2 3 1 5 2 5 3 3

//Output: 5 6 7 81