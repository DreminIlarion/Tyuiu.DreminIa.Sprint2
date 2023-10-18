using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.DreminIa.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            switch (m)
            {
                case 2:
                    if (n >= 28 || (n == 27 && !IsLeapYear(g)))
                    {
                        m = 3;
                        n = 1;
                    }
                    else
                    {
                        n++;
                    }
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    if (n == 30)
                    {
                        m++;
                        n = 1;
                    }
                    else
                    {
                        n++;
                    }
                    break;

                case 12:
                    if (n == 31)
                    {
                        g++;
                        m = 1;
                        n = 1;
                    }
                    else
                    {
                        n++;
                    }
                    break;

                default:
                    if (n == 31)
                    {
                        m++;
                        n = 1;
                    }
                    else
                    {
                        n++;
                    }
                    break;
            }

            return $"{g}-{m:D2}-{n:D2}";
        }

        private bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
    }
}
