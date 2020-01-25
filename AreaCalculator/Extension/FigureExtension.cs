using AreaCalculator.Model;
using System;

namespace AreaCalculator.Extension
{
    public static class FigureExtension
    {
        public static bool IsSquare(this Triangle triangle)
        {
            if (triangle.ASide == triangle.BSide && triangle.BSide == triangle.CSide)
                return false;
            if (triangle.Biggest == triangle.ASide)
            {
                return Math.Pow(triangle.ASide, 2) == Math.Pow(triangle.BSide, 2) + Math.Pow(triangle.CSide, 2);
            }
            else if (triangle.Biggest == triangle.BSide)
            {
                return Math.Pow(triangle.BSide, 2) == Math.Pow(triangle.ASide, 2) + Math.Pow(triangle.CSide, 2);
            }
            else if (triangle.Biggest == triangle.CSide)
            {
                return Math.Pow(triangle.CSide, 2) == Math.Pow(triangle.ASide, 2) + Math.Pow(triangle.BSide, 2);
            }
            return false;
        }

    }
}
