using AreaCalculator.Model.Interface;
using System;

namespace AreaCalculator.Model
{
    public sealed class Triangle : IFigure
    {
        private double HalfPerimeter => (ASide + BSide + CSide) / 2;
        public double Biggest => Math.Max(ASide, Math.Max(BSide, CSide));

        public double ASide { get; set; }

        public double BSide { get; set; }

        public double CSide { get; set; }

        public Triangle(double aSide, double bSide, double cSide)
        {
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
        }

        public double Area => Math.Pow(HalfPerimeter * (HalfPerimeter - ASide) * (HalfPerimeter - BSide) * (HalfPerimeter - CSide), 0.5);

    }
}
