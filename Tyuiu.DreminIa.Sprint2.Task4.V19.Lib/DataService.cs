using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DreminIa.Sprint2.Task4.V19.Lib
{
    public class DataService : ISprint2Task4V19
    {
        public double Calculate(double x, double y)
        {
            double z = Math.Round((x/2) < (y-6) ? Math.Pow(6 + 4 / (Math.Pow(y, 2)), x) : (Math.Pow(x, 2)-Math.Pow(Math.Cos(y),2) + 10) /(Math.Pow(y, 2) - Math.Pow(Math.Sin(y), 2) + 12), 3);
            return z;
        }
    }
}
