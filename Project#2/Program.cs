


//https://academy.patika.dev/tr/courses/c-projeleri/ucgen-cizme

using Project_2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Üçgen Boyutunu Yazınız:");
        var size = Convert.ToInt32(Console.ReadLine());
        Triangle triangle = new Triangle(); 
        triangle.DrawATriangle(size);
    }
}