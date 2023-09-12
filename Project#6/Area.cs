using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_6
{
    internal class Area
    {
        internal static double CalculateCircle(double radius)
        {
            var result=double.Pi*Math.Pow(radius, 2);
            return result;
        }

        internal static double CalculateRectangle(double sideLengtha, double sideLengthb)
        {
            var result = sideLengtha * sideLengthb;
            return result;
        }

        internal static double CalculateSquare(double sideLength)
        {
            var result=Math.Pow(sideLength, 2);
            return result;
        }

        internal static double CalculateTriangle(double width, double height)
        {
            var result=(width*height)/2;
            return result;
        }
    }
}
