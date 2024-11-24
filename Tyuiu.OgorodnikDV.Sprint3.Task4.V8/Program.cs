using Tyuiu.OgorodnikDV.Sprint3.Task4.V8.Lib;

namespace Tyuiu.OgorodnikDV.Sprint3.Task4.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Огородник Д.В | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: continue/break                                                    *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Огородник Дарья Вячеславовна | ИСПб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет результат по     *");
            Console.WriteLine("* формуле.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            int s = -5, e = 5;
            Console.WriteLine("* Начальное значение " + s);
            Console.WriteLine("* Конечное значение " + e);
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.Calculate(s, e));
        }
    }
}
