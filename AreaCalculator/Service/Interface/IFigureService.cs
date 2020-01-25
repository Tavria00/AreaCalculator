namespace AreaCalculator.Service.Interface
{
    public interface IFigureService
    {
        double GetSquareArea(double side);
        double GetTriangleArea(double sideA, double sideB, double sideC);
        bool IsSquareTriangle(double sideA, double sideB, double sideC);
    }
}
