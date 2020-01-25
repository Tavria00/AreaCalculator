using AreaCalculator.Handler.Interface;
using AreaCalculator.Model.Interface;
using System;

namespace AreaCalculator.Handler
{
    internal sealed class AreaHandler : IAreaHandler
    {
        public double GetFigureArea(IFigure figure)
        {
            if (figure == null) throw new ArgumentNullException(nameof(figure));
            return figure.Area;
        }
    }
}
