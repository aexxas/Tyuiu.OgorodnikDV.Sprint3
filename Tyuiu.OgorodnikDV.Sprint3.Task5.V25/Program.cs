﻿using Tyuiu.OgorodnikDV.Sprint3.Task5.V25.Lib;

namespace Tyuiu.OgorodnikDV.Sprint3.Task5.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Огородник Д.В. | ИСПб-24-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                         *");
            Console.WriteLine("* Тема:Вложенные циклы                                                              *");
            Console.WriteLine("* Задание #5                                                                        *");
            Console.WriteLine("* Вариант #25                                                                       *");
            Console.WriteLine("* Выполнила: Огородник Дарья Вячеславовна | ИСПб-24-1                               *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, используя вложенные циклы, которая вычисляет сумму ряда       *");
            Console.WriteLine("* по формуле при x = 2                                                              *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;
            int x = 2;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Console.WriteLine("Переменная X = " + x);
            Console.WriteLine("Старт шага первой суммы ряда " + startValue1);
            Console.WriteLine("Стоп шага первой суммы ряда " + stopValue1);
            Console.WriteLine("Старт шага второй суммы ряда " + startValue2);
            Console.WriteLine("Стоп шага второй суммы ряда " + stopValue2);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Сумма ряда = " + res);
            Console.ReadKey();
        }
    }
}
