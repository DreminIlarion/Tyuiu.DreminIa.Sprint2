using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DreminIa.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Проверка, находится ли точка в заштрихованной области.
            // Область ограничена функциями y=x^2-2, y=-x и y=x.

            bool isAboveParabola = y >= x * x - 2;
            bool isBelowLine = y <= -x;
            bool isRightOfYEqualsX = x >= y;

            return isAboveParabola && isBelowLine && isRightOfYEqualsX;
        }
    }
}
