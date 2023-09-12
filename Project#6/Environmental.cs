using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_6
{
    internal class Environmental
    {
        internal static double CalculateCircle(double radius)
        {
            var result = 2 * radius * double.Pi;
            return result;
        }

        internal static double CalculateRectangle(double sideLengtha, double sideLengthb)
        {
            var result=(sideLengtha+sideLengthb)*2;
            return result;
        }

        internal static double CalculateSquare(double sideLength)
        {
            var result = 4 * sideLength;
            return result;
        }

        internal static double CalculateTringle(double width, double v1, double v2)
        {
            var result = width + v1 + v2;
            return result;
        }
    }
}
