using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DreminIa.Sprint2.Task4.V17.Lib
{
    public class DataService : ISprint2Task3V17
    {
        public double Calculate(double x)
        {
            if (x > 1)
            {
                return Math.Round(Math.Pow(x,2) * Math.Pow(((x + 1) / (x - 1)), 8), 3);
            }

            if (x == 0)
            {
                return Math.Round(((2+x-3*x)/(x-7)), 3);
            }

            if (x > -21 && x < 2)
            {
                return Math.Round((Math.Pow(1+(1/ Math.Pow(x,2)),4)), 3);
            }

            else
            {
                return Math.Round(x+10*x-(1/x), 3);
            }
        }
    }
}