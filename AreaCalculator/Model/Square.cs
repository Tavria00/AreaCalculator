using AreaCalculator.Model.Interface;

namespace AreaCalculator.Model
{
    internal sealed class Square : IFigure
    {
        private double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public double Area => Side * Side;

    }
}
