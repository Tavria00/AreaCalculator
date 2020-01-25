using AreaCalculator.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator.Handler.Interface
{
    public interface IAreaHandler
    {
        double GetFigureArea(IFigure figure);
    }
}
