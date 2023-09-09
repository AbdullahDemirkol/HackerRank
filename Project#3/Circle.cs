internal class Circle
{
    internal void DrawACircle(int radius)
    {
        double thickness = 0.2;
        double innerCircle = radius - thickness;
        double outerCircle = radius + thickness;

        for (double y = radius; y >= -radius; --y)
        {
            for (double x = -radius; x < outerCircle; x += 0.5)
            {
                double value = x * x + y * y;
                if (value >= innerCircle * innerCircle && value <= outerCircle * outerCircle)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}