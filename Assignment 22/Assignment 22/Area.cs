using System;

namespace Assignment_22
{
    internal static class Area
    {
        public static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double CalculateArea(double width, double length)
        {
            return width * length;
        }

        public static double CalculateArea(double radius, double height, bool isCylinder)
        {
            return Math.PI * radius * radius * height;
        }
    }
}
