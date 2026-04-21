using System;

namespace Assignment_22
{
    public static class Area
    {
        /// <summary>
        /// Calculates the area of a circle: A = πr²
        /// </summary>
        public static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        /// <summary>
        /// Calculates the area of a rectangle: A = Width × Length
        /// </summary>
        public static double CalculateAreaRectangle(double width, double length)
        {
            return width * length;
        }

        /// <summary>
        /// Calculates the area of a cylinder: A = πr²h
        /// </summary>
        public static double CalculateAreaCylinder(double radius, double height)
        {
            return Math.PI * radius * radius * height;
        }
    }
}
