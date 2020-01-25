using AreaCalculator.Handler.Interface;
using AreaCalculator.Model.Interface;
using AreaCalculator.Service;
using Moq;
using System;
using Xunit;

namespace AreaCalculator.Test.Service
{
    public class FigureServiceTest
    {
        private readonly Mock<IAreaHandler> _areaHandlerMock = new Mock<IAreaHandler>();
        private readonly FigureService _figureService;

        public FigureServiceTest()
        {
            _figureService = new FigureService(_areaHandlerMock.Object);
        }
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(99.9)]
        public void GetCircleArea_ValidData_ReturnResult(double radius)
        {
            _areaHandlerMock.Setup(s => s.GetFigureArea(It.IsAny<IFigure>())).Returns(It.IsAny<double>());

            var result = _figureService.GetCircleArea(radius);

            Assert.IsType<double>(result);
            _areaHandlerMock.Verify(v => v.GetFigureArea(It.IsAny<IFigure>()), Times.Once);
        }
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(99.9)]
        public void GetSquareArea_ValidData_ReturnResult(double radius)
        {
            _areaHandlerMock.Setup(s => s.GetFigureArea(It.IsAny<IFigure>())).Returns(It.IsAny<double>());

            var result = _figureService.GetSquareArea(radius);

            Assert.IsType<double>(result);
            _areaHandlerMock.Verify(v => v.GetFigureArea(It.IsAny<IFigure>()), Times.Once);
        }
        [InlineData(0,0,0)]
        [InlineData(1,1,1)]
        [InlineData(99.9,6,77.9)]
        public void GetTriangleArea_ValidData_ReturnResult(double sideA, double sideB, double sideC)
        {
            _areaHandlerMock.Setup(s => s.GetFigureArea(It.IsAny<IFigure>())).Returns(It.IsAny<double>());

            var result = _figureService.GetTriangleArea(sideA, sideB, sideC);

            Assert.IsType<double>(result);
            _areaHandlerMock.Verify(v => v.GetFigureArea(It.IsAny<IFigure>()), Times.Once);
        }
        [InlineData(0, 0, 0)]
        [InlineData(1, 1, 1)]
        [InlineData(99.9, 6, 77.9)]
        public void IsSquareTriangle_ValidData_ReturnResult(double sideA, double sideB, double sideC)
        {
            var result = _figureService.IsSquareTriangle(sideA, sideB, sideC);
            Assert.IsType<bool>(result);

        }

        [InlineData(-3, "Радиус круга должен быть положительным числом")]
        public void GetCircleArea_InvalidData_ThrowError(double radius, string message)
        {

            var result = Assert.Throws<ArgumentOutOfRangeException>(()=>_figureService.GetCircleArea(radius));

            Assert.Equal(message, result.Message);
            _areaHandlerMock.Verify(v => v.GetFigureArea(It.IsAny<IFigure>()), Times.Never);
        }
        [InlineData(-3, "Сторона квадрата должна быть положительным числом")]
        public void GetSquareArea_InvalidData_ThrowError(double side, string message)
        {

            var result = Assert.Throws<ArgumentOutOfRangeException>(() => _figureService.GetSquareArea(side));

            Assert.Equal(message, result.Message);
            _areaHandlerMock.Verify(v => v.GetFigureArea(It.IsAny<IFigure>()), Times.Never);
        }
        [InlineData(-3,0,2 , "Все стороны треугольника должны быть положительными числами")]
        public void GetTriangleArea_InvalidData_ThrowError(double sideA, double sideB, double sideC, string message)
        {

            var result = Assert.Throws<ArgumentOutOfRangeException>(() => _figureService.GetTriangleArea(sideA, sideB, sideC));

            Assert.Equal(message, result.Message);
            _areaHandlerMock.Verify(v => v.GetFigureArea(It.IsAny<IFigure>()), Times.Never);
        }

        [InlineData(-3, 0, 2, "Все стороны треугольника должны быть положительными числами")]
        public void IsSquareTriangle_InvalidData_ThrowError(double sideA, double sideB, double sideC, string message)
        {

            var result = Assert.Throws<ArgumentOutOfRangeException>(() => _figureService.IsSquareTriangle(sideA, sideB, sideC));

            Assert.Equal(message, result.Message);
        }
    }
}
