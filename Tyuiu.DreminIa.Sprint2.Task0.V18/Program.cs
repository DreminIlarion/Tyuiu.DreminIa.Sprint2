using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DreminIa.Sprint2.Task0.V18.Lib;

namespace Tyuiu.DreminIa.Sprint2.Task0.V18
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            int x = 5105;
            int y = 475;
            bool[] result = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #2 | Выполнил: Дремин И.А | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения.                                               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Дремин Иларион Алексеевич | АСОиУб-23-3                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и арифметических выражений,    *");
            Console.WriteLine("* которая вернет логическую последовательность(массив):                   *");
            Console.WriteLine("* (True, False, True, True, False, True),  при x = 5105, y = 475          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"x {DataService.Operations[i]} y: {result[i]}");
            }
            Console.ReadKey();
        }
    }
}
