using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DreminIa.Sprint2.Task5.V12.Lib
{
    public class DataService 
    {
        public DateTime FindDateOfPreviousDay(int g, int n, int m)
        {
            switch (m)
            {
                case 1:
                    if (n == 1)
                    {
                        m = 12;
                        n = 31;
                        g--;
                    }
                    else
                    {
                        n--;
                    }
                    break;

                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (n == 1)
                    {
                        m--;
                        n = 31;
                    }
                    else
                    {
                        n--;
                    }
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    if (n == 1)
                    {
                        m--;
                        n = 30;
                    }
                    else
                    {
                        n--;
                    }
                    break;

                case 2:
                    if (IsLeapYear(g))
                    {
                        if (n == 1)
                        {
                            m--;
                            n = 31;
                        }
                        else
                        {
                            n--;
                        }
                    }
                    else
                    {
                        if (n == 1)
                        {
                            m--;
                            n = 28;
                        }
                        else
                        {
                            n--;
                        }
                    }
                    break;
            }

            return new DateTime(g, m, n);
        }

        private bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }


    }
}
