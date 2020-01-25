using AreaCalculator.Extension;
using AreaCalculator.Handler.Interface;
using AreaCalculator.Model;
using AreaCalculator.Service.Interface;
using System;

namespace AreaCalculator.Service
{
    public class FigureService : IFigureService
    {
        private readonly IAreaHandler _areaHandler;
        public FigureService(IAreaHandler areaHandler)
        {
            _areaHandler = areaHandler ?? throw new ArgumentNullException(nameof(areaHandler));
        }
        /// <summary>
        /// Вычислить площадь круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <returns></returns>
        public double GetCircleArea(double radius)
        {
            if (radius < 0) throw new ArgumentOutOfRangeException(message: "Радиус круга должен быть положительным числом", null);
            return _areaHandler.GetFigureArea(new Circle(radius));
        }
        /// <summary>
        /// Вычислить площадь квадрата
        /// </summary>
        /// <param name="side">Сторона квадрата</param>
        /// <returns></returns>
        public double GetSquareArea(double side)
        {
            if (side < 0) throw new ArgumentOutOfRangeException(message: "Сторона квадрата должна быть положительным числом", null);
            return _areaHandler.GetFigureArea(new Square(side));
        }
        /// <summary>
        /// Вычислить площадт треугольника по 3 сторонам
        /// </summary>
        /// <param name="sideA">Сторона 1</param>
        /// <param name="sideB">Сторона 2</param>
        /// <param name="sideC">Сторона 3</param>
        /// <returns></returns>
        public double GetTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA < 0 || sideB < 0 || sideC < 0 ) throw new ArgumentOutOfRangeException(message: "Все стороны треугольника должны быть положительными числами", null);
            return _areaHandler.GetFigureArea(new Triangle(sideA, sideB, sideC));
        }
        /// <summary>
        /// Проверить является ли треугольник прямоугольным
        /// </summary>
        /// <param name="sideA">Сторона 1</param>
        /// <param name="sideB">Сторона 2</param>
        /// <param name="sideC">Сторона 3</param>
        /// <returns></returns>
        public bool IsSquareTriangle(double sideA, double sideB, double sideC)
        {
            if (sideA < 0 || sideB < 0 || sideC < 0) throw new ArgumentOutOfRangeException(message: "Все стороны треугольника должны быть положительными числами", null);
            var triangle = new Triangle(sideA, sideB, sideC);
            return triangle.IsSquare();

        }
    }
}
