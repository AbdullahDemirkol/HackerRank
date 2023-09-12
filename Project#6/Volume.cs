internal class Volume
{
    internal static double CalculateCircle(double radius, double h)
    {
        var result = double.Pi * h * Math.Pow(radius, 2); 
        return result;
    }

    internal static double CalculateRectangle(double sideLengtha, double sideLengthb, double h)
    {
        var result =  sideLengtha * sideLengthb * h;
        return result;
    }

    internal static double CalculateSquare(double sideLength)
    {
        var result = Math.Pow(sideLength, 3);
        return result;
    }

    internal static double CalculateTriangle(double width, double height, double h)
    {
        var result = ((width * height) / 2) * h;
        return result;
    }
}