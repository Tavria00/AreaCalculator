using AreaCalculator.Model.Interface;
using System;

namespace AreaCalculator.Model
{
    internal sealed class Circle : IFigure
    {
        private double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;

        }
        public double Area => Math.Pow(Radius, 2) * Math.PI;

    }
}
