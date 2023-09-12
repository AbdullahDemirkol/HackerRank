


//https://academy.patika.dev/tr/courses/c-projeleri/alan-hesaplama

//İşlem yapılmak istenen geometrik şekli kullanıcıdan alınmalı(Daire, Üçgen, Kare, Dikdörtgen vb..)
//Seçilen şekle göre, kenar bilgilerin kullanıcıdan alınmalı
//Hesaplanmak istenen boyutu kullanıcıdan alınmalı(Çevre, Alan, Hacim vb..)
//Hesap sonucunu anlaşılır şekilde geri döndürmeli.

using Project_6;

Start:
Console.WriteLine("İşlem Yapılmak Istenilen Geometrik Sekli Seciniz:\n" +
    "1- Daire\n" +
    "2- Üçgen\n" +
    "3- Kare\n" +
    "4- Dikdörtgen");
var geometricChoice = Console.ReadLine();
switch (geometricChoice)
{
    case "1":
        StartCircle:
        Console.WriteLine("Yarıçap Değerini Giriniz:");
        var radius=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Yapılmak Istenilen Islemi Seciniz:\n" +
            "1- Çevre\n" +
            "2- Alan\n" +
            "3- Hacim");
        var choice=Console.ReadLine();
        var result=0.0;
        switch (choice)
        {
            case "1":
                result = Environmental.CalculateCircle(radius);
                Console.WriteLine(result);
                break;

            case "2":
                result = Area.CalculateCircle(radius);
                Console.WriteLine(result);
                break;

            case "3":
                Console.WriteLine("Yükseklik Giriniz:");
                double h = Convert.ToDouble(Console.ReadLine());
                result = Volume.CalculateCircle(radius,h);
                Console.WriteLine(result);
                break;

            default:
                Console.WriteLine("Hatalı Tuşlama Yapıldı.");
                goto StartCircle;
        }
        break;
    case "2":
        StartTriangle:
        Console.WriteLine("Taban Uzunluğu Değerini Giriniz:");
        var width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Diğer İki Kenarın Uzunluklarını Boşluk Bırakarak Giriniz:");
        var sides = Console.ReadLine().TrimEnd().Split(' ').ToList();
        Console.WriteLine("Yükseklik Değerini Giriniz:");
        var height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Yapılmak Istenilen Islemi Seciniz:\n" +
            "1- Çevre\n" +
            "2- Alan\n" +
            "3- Hacim");
        choice = Console.ReadLine();
        result = 0.0;
        switch (choice)
        {
            case "1":
                
                result = Environmental.CalculateTringle(width, Convert.ToDouble(sides[0]), Convert.ToDouble(sides[1]));
                Console.WriteLine(result);
                break;

            case "2":
                result = Area.CalculateTriangle(width,height);
                Console.WriteLine(result);
                break;

            case "3":
                Console.WriteLine("Prizma Yükseklik Değerini Giriniz:");
                double h = Convert.ToDouble(Console.ReadLine());
                result = Volume.CalculateTriangle(width, height, h);
                Console.WriteLine(result);
                break;

            default:
                Console.WriteLine("Hatalı Tuşlama Yapıldı.");
                goto StartTriangle;
        }
        break;
    case "3":
        StartSquare:
        Console.WriteLine("Karenin Bir Kenar Uzunluğu Değerini Giriniz:");
        var sideLength = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Yapılmak Istenilen Islemi Seciniz:\n" +
            "1- Çevre\n" +
            "2- Alan\n" +
            "3- Hacim");
        choice = Console.ReadLine();
        result = 0.0;
        switch (choice)
        {
            case "1":

                result = Environmental.CalculateSquare(sideLength);
                Console.WriteLine(result);
                break;

            case "2":
                result = Area.CalculateSquare(sideLength);
                Console.WriteLine(result);
                break;

            case "3":
                result = Volume.CalculateSquare(sideLength);
                Console.WriteLine(result);
                break;

            default:
                Console.WriteLine("Hatalı Tuşlama Yapıldı.");
                goto StartSquare;
        }
        break;
    case "4":
        StartRectangle:
        Console.WriteLine("Dikdörtgenin Bir Kenar Uzunluğu Değerini Giriniz:");
        var sideLengtha = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Dikdörtgenin Diğer Bir Kenar Uzunluğu Değerini Giriniz:");
        var sideLengthb = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Yapılmak Istenilen Islemi Seciniz:\n" +
            "1- Çevre\n" +
            "2- Alan\n" +
            "3- Hacim");
        choice = Console.ReadLine();
        result = 0.0;
        switch (choice)
        {
            case "1":

                result = Environmental.CalculateRectangle(sideLengtha, sideLengthb);
                Console.WriteLine(result);
                break;

            case "2":
                result = Area.CalculateRectangle(sideLengtha, sideLengthb);
                Console.WriteLine(result);
                break;

            case "3":
                Console.WriteLine("Dikdörtgen Prizmasının Yükseklik Değerini Giriniz:");
                var h=Convert.ToDouble(Console.ReadLine());
                result = Volume.CalculateRectangle(sideLengtha, sideLengthb, h);
                Console.WriteLine(result);
                break;

            default:
                Console.WriteLine("Hatalı Tuşlama Yapıldı.");
                goto StartRectangle;
        }
        break;
    default:
        Console.WriteLine("Hatalı Tuşlama Yapıldı.");
        goto Start;
}
