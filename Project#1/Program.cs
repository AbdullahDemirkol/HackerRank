


//https://academy.patika.dev/tr/courses/c-projeleri/ortalama-hesaplama


using Project_1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Değer giriniz:");
        var param = Convert.ToInt32(Console.ReadLine());

        Fibonacci fibonacci = new Fibonacci();
        int[] fibonacciResults = fibonacci.FibonacciToCreate(param);

        Avarage avarage = new Avarage();
        avarage.AvarageOfFibonacci(fibonacciResults);
    }


}